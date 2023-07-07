using MediatR;
using Microsoft.Extensions.Logging;
using OrderStep.Core.Model;
using OrderStep.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Command.Authentification
{
    public class AuthentificationCommandHandler : IRequestHandler<AuthentificationCommand, BaseResponse<Client>>
    {
        private readonly ILogger<AuthentificationCommandHandler> _logger;
        private readonly IAuthentificationService _authService;

        public AuthentificationCommandHandler(ILogger<AuthentificationCommandHandler> logger, 
            IAuthentificationService authService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _authService = authService ?? throw new ArgumentNullException(nameof(authService)); ;
        }

        public async Task<BaseResponse<Client>> Handle(AuthentificationCommand command, CancellationToken cancellationToken)
        {
            var result = await _authService.AuthentificationUser(command.Login, command.Password, cancellationToken);

            return result;
        }
    }
}
