using MediatR;
using OrderStep.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Command.Authentification
{
    public class AuthentificationCommandHandler : IRequestHandler<AuthentificationCommand, Client>
    {
        public AuthentificationCommandHandler() { }

        public async Task<Client> Handle(AuthentificationCommand command, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
