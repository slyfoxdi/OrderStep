using MediatR;
using OrderStep.Core.Behavior;

namespace OrderStep.WebApi.Extensions
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
