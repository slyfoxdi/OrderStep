using Microsoft.AspNetCore.Mvc;
using OrderStep.Application.Command.Authentification;
using OrderStep.WebApi.Model;

namespace OrderStep.WebApi.Controllers
{
    [ApiController]
    [Route("api/Auth")]
    public partial class BaseController
    {
        /// <summary>
        /// Авторизация клиента
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Шифрованный пароль</param>
        /// <returns>Клиентские данные</returns>
        [HttpGet(nameof(Authentification))]
        public async Task<BaseResponse<Client>> Authentification(string login, string password, CancellationToken cancellationToken)
        {
            try{
                var command = new AuthentificationCommand(login, password);
                var request = await _mediator.Send(command, cancellationToken);
                var result = _mapper.Map<BaseResponse<Client>>(request);
                throw new Exception();
                return result;
            }
            catch(Exception ex)
            {
                _logger.LogDebug("Ошибка при вызове метода авторизации");
                return null;
            }
        }
    }
}
