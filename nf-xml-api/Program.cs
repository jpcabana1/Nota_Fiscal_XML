using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using nf_xml_api.Models;
using nf_xml_api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NotaFiscalContext>(context => context.UseSqlServer(builder.Configuration.GetConnectionString("NOTA_FISCAL")));
builder.Services.AddScoped<ImportacaoService, ImportacaoServiceImpl>();
builder.Services.AddScoped<ProdutoService, ProdutoServiceImpl>();
builder.Services.AddScoped<TotalNotaService, TotalNotaServiceImpl>();
builder.Services.AddScoped<XmlNotaService, XmlNotaServiceImpl>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    options =>
{
    string titulo = "";
    if (builder.Environment.IsEnvironment("LocalDevelopment"))
    {
        titulo = "NFE-Importação-LOCAL";
    }
    else if (builder.Environment.IsDevelopment())
    {
        titulo = "NFE-Importação-DEV";
    }
    else if (builder.Environment.IsStaging())
    {
        titulo = "NFE-Importação-STAGE";
    }

    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "1.0.1",
        Title = titulo,
        Description = "Projeto para gerar planilha de gasto a partir de um NFC-e.",
    });
}
);

var app = builder.Build();

Console.WriteLine("Environment: " + app.Environment.EnvironmentName);
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseExceptionHandler(options =>
    {
        options.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Response.ContentType = "application/json";
                var exceptionObject = context.Features.Get<IExceptionHandlerFeature>();
                if (null != exceptionObject)
                {
                    await context.Response.WriteAsync(JsonSerializer.Serialize(new
                    {
                        mensagem = "Erro ao importar nota: " + exceptionObject.Error.Message
                    })).ConfigureAwait(false);
                }
            });
    });

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
