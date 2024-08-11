using DDDStudy.Infra.CrossCutting.IOC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServices();
builder.Services.AddAppServices();
builder.Services.AddRepositories();

var defaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");
if(!string.IsNullOrEmpty(defaultConnection)) builder.Services.AddContext(defaultConnection);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//TODO - Everything

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
