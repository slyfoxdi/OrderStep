using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderStep.Infrastracture.Context;
using OrderStep.Infrastructure.App;
using System.Reflection;
using OrderStep.WebApi.Extensions;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Database
builder.Services.AddScoped<ApplicationContextFactory>();

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services
    .AddEntityFrameworkSqlServer()
    .AddDbContext<ApplicationContext>((serviceProvider, options) =>
    {
        options.UseSqlServer(connection);
    }, ServiceLifetime.Transient);


// Added MediatR
builder.Services
    .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()))
    .AddMediatorLoggingAndValidationBehavior();


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
