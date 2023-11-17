using Microsoft.AspNetCore.Mvc;
using OrderStep.Application.Command.Authentification;
using OrderStep.WebApi.Model;

namespace OrderStep.WebApi.Controllers
{
    public partial class BaseController
    {
        /// <summary>
        /// Авторизация клиента
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Шифрованный пароль</param>
        /// <returns>Клиентские данные</returns>
        [HttpPost(nameof(Authentification))]
        public async Task<BaseResponse<Client>> Authentification([FromBody]Auth credential, CancellationToken cancellationToken)
        {
            try
            {
                var command = new AuthentificationCommand(credential.Login, credential.Password);
                var request = await _mediator.Send(command, cancellationToken);
                var result = _mapper.Map<BaseResponse<Client>>(request);

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
