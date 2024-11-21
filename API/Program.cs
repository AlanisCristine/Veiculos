using Carros.Repository;
using Carros.Repository.Data;
using Carros.Repository.Interfaces;
using Carros.Service;
using Carros.Service.Interface;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


InicializadorBd.Inicializar();


builder.Services.AddScoped<ICaminhao, CaminhaoRepository>();
builder.Services.AddScoped<ICarro, CarroRepository>();

builder.Services.AddScoped<ICaminhaoService, CaminhaoService>();
builder.Services.AddScoped<ICarroService, CarroService>();

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
