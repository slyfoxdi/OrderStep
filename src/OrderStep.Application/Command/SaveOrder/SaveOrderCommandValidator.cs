using FluentValidation;
using OrderStep.Application.Command.Authentification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Command.SaveOrder
{
    public class SaveOrderCommandValidator : AbstractValidator<SaveOrderCommand>
    {
        public SaveOrderCommandValidator()
        {
        }
    }
}
