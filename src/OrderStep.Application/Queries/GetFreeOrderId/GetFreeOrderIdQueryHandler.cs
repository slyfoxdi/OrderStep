using MediatR;
using Microsoft.Extensions.Logging;
using OrderStep.Application.Command.SaveOrder;
using OrderStep.Core.Model;
using OrderStep.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Queries.GetFreeOrderId
{
    public class GetFreeOrderIdQueryHandler : IRequestHandler<GetFreeOrderIdQuery, BaseResponse<int>>
    {
        private readonly ILogger<GetFreeOrderIdQueryHandler> _logger;
        private readonly IOrderService _orderService;

        public GetFreeOrderIdQueryHandler(ILogger<GetFreeOrderIdQueryHandler> logger,
            IOrderService orderService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService)); ;
        }

        public async Task<BaseResponse<int>> Handle(GetFreeOrderIdQuery query, CancellationToken cancellationToken)
        {
            var result = await _orderService.GetFreeOrderId(cancellationToken);
            return new BaseResponse<int> { Response = result, Status = Core.Enum.StatusCode.Success};
        }
    }
}
