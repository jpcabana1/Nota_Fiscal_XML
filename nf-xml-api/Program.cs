using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
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
builder.Services.AddSwaggerGen();

var app = builder.Build();

Console.WriteLine("Environment: " + app.Environment.EnvironmentName);
if (app.Environment.IsDevelopment()
    || app.Environment.IsEnvironment("LocalDevelopment")
    || app.Environment.IsStaging())
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
