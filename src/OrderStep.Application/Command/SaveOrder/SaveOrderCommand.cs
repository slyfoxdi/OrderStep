using MediatR;
using OrderStep.Core.Enum;
using OrderStep.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Command.SaveOrder
{
    public class SaveOrderCommand : IRequest<BaseResponse<bool>>
    {
        public Order Request { get; set; }
    }
}
