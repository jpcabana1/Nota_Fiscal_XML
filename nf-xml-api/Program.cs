using Microsoft.EntityFrameworkCore;
using nf_xml_api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NotaFiscalContext>(context => context.UseSqlServer(builder.Configuration.GetConnectionString("NOTA_FISCAL")));

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
