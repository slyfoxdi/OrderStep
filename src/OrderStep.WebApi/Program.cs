using Microsoft.EntityFrameworkCore;
using OrderStep.Infrastracture.Context;
using OrderStep.Infrastructure.App;
using AutoMapper;
using OrderStep.WebApi.Configuration.Profiles;
using NLog;
using NLog.Web;
using OrderStep.Application.Configuration.Profiles;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

try
{
    logger.Debug("Init main");
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

    // Added DI
    builder.Services
        .AddOperationService();

    // Added MediatR
    builder.Services
        .AddMediator();

    // Added Mapper
    var mapperConfig = new MapperConfiguration(mc =>
    {
        mc.AddProfile(new ApiProfile());
    });

    IMapper mapper = mapperConfig.CreateMapper();
    builder.Services.AddSingleton(mapper);

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
}
catch (Exception ex)
{
    logger.Error(ex, "Stopped program because of exception");
}
finally
{
    LogManager.Shutdown();
}