using MediatR;
using Microsoft.Extensions.Logging;
using OrderStep.Core.Model;
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
        public AuthentificationCommandHandler(ILogger<AuthentificationCommandHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<BaseResponse<Client>> Handle(AuthentificationCommand command, CancellationToken cancellationToken)
        {
            return new BaseResponse<Client>()
            {
                SessionId = "123ASD",
                Status = 200,
                Response = new Client()
                {
                    Id = 1,
                    FitstName = "Дмитрий",
                }
            };
        }
    }
}
