using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OrderStep.Core.Behavior;

namespace OrderStep.WebApi.Extension
{
    public static class MediatorBehavioursExtensions
    {
        public static IServiceCollection AddMediatorLoggingBehavior(this IServiceCollection services)
        {
            return services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        }

        public static IServiceCollection AddMediatorLoggingAndValidationBehavior(this IServiceCollection services)
        {
            return services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingAndValidationBehavior<,>));
        }
    }
}
