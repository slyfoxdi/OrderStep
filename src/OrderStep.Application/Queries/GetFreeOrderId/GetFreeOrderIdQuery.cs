using MediatR;
using OrderStep.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Queries.GetFreeOrderId
{
    public class GetFreeOrderIdQuery : IRequest<BaseResponse<int>>
    {
    }
}
