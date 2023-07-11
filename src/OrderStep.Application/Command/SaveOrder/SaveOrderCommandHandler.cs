using MediatR;
using Microsoft.Extensions.Logging;
using OrderStep.Application.Command.Authentification;
using OrderStep.Core.Model;
using OrderStep.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Command.SaveOrder
{
    public class SaveOrderCommandHandler : IRequestHandler<SaveOrderCommand, BaseResponse<bool>>
    {
        private readonly ILogger<SaveOrderCommandHandler> _logger;
        private readonly IOrderService _orderService;

        public SaveOrderCommandHandler(ILogger<SaveOrderCommandHandler> logger,
            IOrderService orderService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService)); ;
        }

        public async Task<BaseResponse<bool>> Handle(SaveOrderCommand command, CancellationToken cancellationToken)
        {
            var result = await _orderService.SaveNewOrder(command.Request, cancellationToken);
            return new BaseResponse<bool> { Response = result, Status = Core.Enum.StatusCode.Success, Message = "Заказ успешно создан" };
        }
    }
}
