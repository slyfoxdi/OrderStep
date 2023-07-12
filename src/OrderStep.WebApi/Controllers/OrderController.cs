using Microsoft.AspNetCore.Mvc;
using OrderStep.Application.Command.Authentification;
using OrderStep.Application.Command.SaveOrder;
using OrderStep.Application.Queries.GetFreeOrderId;
using OrderStep.WebApi.Model;
using CoreApp = OrderStep.Core.Model;

namespace OrderStep.WebApi.Controllers
{
    [Route("api/Order")]
    public partial class BaseController
    {
        [HttpPost(nameof(SaveOrder))]
        public async Task<BaseResponse<bool>> SaveOrder(Order order, CancellationToken cancellationToken)
        {
            try
            {
                var command = new SaveOrderCommand()
                {
                    Request = _mapper.Map<CoreApp.Order>(order),
                };

                var request = await _mediator.Send(command, cancellationToken);
                var result = _mapper.Map<BaseResponse<bool>>(request);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogDebug("Ошибка при вызове метода сохранинея заказа");
                return new BaseResponse<bool>() { Status = Enum.StatusCode.FailedSaveOrder, Response = false };
            }
        }

        [HttpGet(nameof(GetFreeOrderId))]
        public async Task<BaseResponse<int>> GetFreeOrderId(CancellationToken cancellationToken)
        {
            try
            {
                var query = new GetFreeOrderIdQuery();
                var request = await _mediator.Send(query, cancellationToken);
                var result = _mapper.Map<BaseResponse<int>>(request);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogDebug("Ошибка при вызове метода авторизации");
                return null;
            }
        }
    }
}
