using MediatR;
using Microsoft.Extensions.Logging;
using static OrderStep.Core.Helper.MessageFormatterHelper;

namespace OrderStep.Core.Behavior
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<LoggingBehavior<TRequest,TResponse>> _logger;
    
        /// <summary>
        ///  Initializes a new instance of the <see cref="LoggingBehavior
        /// </summary>
        /// <param name="logger"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        
        /// <inheritdoc />
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancelationToken)
        {
            var title = $"LoggingBehavior<{typeof(TRequest).Name}, {typeof(TResponse)}.Name>";
            _logger.LogInformation(Format(title, "Request:", request));
            var response = await next.Invoke();
            _logger.LogInformation(Format(title, "Response:", response));

            return response;
        }
    }
}
