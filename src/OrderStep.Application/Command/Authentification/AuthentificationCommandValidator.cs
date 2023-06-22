using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Command.Authentification
{
    public class AuthentificationCommandValidator : AbstractValidator<AuthentificationCommand>
    {
        public AuthentificationCommandValidator() 
        {
            RuleFor(x => x.Login).NotEmpty();
        }
    }
}
