using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using static OrderStep.Core.Helper.MessageFormatterHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Core.Behavior
{
    public class LoggingAndValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<LoggingAndValidationBehavior<TRequest, TResponse>> _logger;
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public LoggingAndValidationBehavior(
            ILogger<LoggingAndValidationBehavior<TRequest, TResponse>> logger, 
            IEnumerable<IValidator<TRequest>> validators)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _validators = validators ?? throw new ArgumentNullException(nameof(validators));
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);
            var validationResults = await Task.WhenAll(_validators.Select(x => x.ValidateAsync(context, cancellationToken)));
            var failures = validationResults
                .SelectMany(x => x.Errors)
                .Where(x => x != null)
                .ToList();

            if(failures.Count != 0)
            {
                throw new ValidationException(failures);
            }

            var title = $"LoggingAndValidationBehavior<{typeof(TRequest).Name}, {typeof(TResponse)}.Name>";
            _logger.LogInformation(Format(title, "Request:", request));
            var response = await next.Invoke();
            _logger.LogInformation(Format(title, "Response:", response));

            return response;
        }
    }
}
