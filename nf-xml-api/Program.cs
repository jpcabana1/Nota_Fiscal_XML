using Microsoft.EntityFrameworkCore;
using nf_xml_api.Models;
using nf_xml_api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NotaFiscalContext>(context => context.UseSqlServer(builder.Configuration.GetConnectionString("NOTA_FISCAL")));
builder.Services.AddTransient<ImportacaoServiceImpl>();
builder.Services.AddTransient<ProdutoServiceImpl>();
builder.Services.AddTransient<TotalNotaServiceImpl>();
builder.Services.AddTransient<XmlNotaServiceImpl>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
