using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Configurando o Pomelo
var connectionString = builder.Configuration.GetConnectionString("Conexao");
var serverVersion = new MariaDbServerVersion(ServerVersion.AutoDetect(connectionString));

builder.Services.AddDbContext<OrganizadorContext>(
    dbContextOptions => dbContextOptions.UseMySql(connectionString, serverVersion)
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();