using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using OrderStep.Core.Extension;
using OrderStep.Domain.Service;
using OrderStep.Infrastracture.Repository.Credential;
using OrderStep.Infrastracture.Repository.User;
using OrderStep.WebApi.Extension;
using System.Reflection;

namespace OrderStep.Application.Configuration.Profiles
{
    public static class DIProfile
    {
        public static void AddOperationService(this IServiceCollection services)
        {
            services.AddTransient<IAuthentificationService, AuthentificationService>();

            //Infrastracture
            services.AddRepositoryService();
        }

        private static void AddRepositoryService(this IServiceCollection services)
        {
            services.AddTransient<IUserAndRightRepository, UserAndRightRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICredentialRepository, CredentialRepository>();
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
