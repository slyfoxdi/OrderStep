using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using OrderStep.Core.Extension;
using OrderStep.Domain.Service;
using OrderStep.Infrastracture.Repository.Credentials;
using OrderStep.Infrastracture.Repository.Orders;
using OrderStep.Infrastracture.Repository.Users;
using OrderStep.WebApi.Extension;
using System.Reflection;

namespace OrderStep.Application.Configuration.Profiles
{
    public static class DIProfile
    {
        public static void AddOperationService(this IServiceCollection services)
        {
            services.AddTransient<IAuthentificationService, AuthentificationService>();
            services.AddTransient< IOrderService, OrderService>();

            //Infrastracture
            services.AddRepositoryService();
        }

        private static void AddRepositoryService(this IServiceCollection services)
        {
            services.AddTransient<IUserAndRightRepository, UserAndRightRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICredentialRepository, CredentialRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
        }

        public static void AddMediator(this IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("OrderStep.Application");
            services
                .AddMediatR(assembly)
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
                .AddMediatorLoggingBehavior();
        }
    }
}
