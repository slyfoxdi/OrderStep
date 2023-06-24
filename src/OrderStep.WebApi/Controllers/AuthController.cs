using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderStep.Application.Command.Authentification;
using OrderStep.WebApi.Model;

namespace OrderStep.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

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

                return result;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
