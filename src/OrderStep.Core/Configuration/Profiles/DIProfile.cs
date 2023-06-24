using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OrderStep.Core.Extension;
using OrderStep.WebApi.Extension;
using System.Reflection;

namespace OrderStep.Core.Configuration.Profiles
{
    public static class DIProfile
    {
        public static void AddOperationService(IServiceCollection services)
        {
            
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
