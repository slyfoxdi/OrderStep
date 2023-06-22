using MediatR;
using OrderStep.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Command.Authentification
{
    public class AuthentificationCommand : IRequest<Client>
    {
        public string Login { get; set; }

        public string Password { get; set; }
    }
}
