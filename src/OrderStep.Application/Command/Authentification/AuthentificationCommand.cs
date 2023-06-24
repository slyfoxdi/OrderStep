using MediatR;
using OrderStep.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Application.Command.Authentification
{
    public class AuthentificationCommand : IRequest<BaseResponse<Client>>
    {
        public AuthentificationCommand(string login, string password)
        {
            Login = login;
            Password = password;
        }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
    }
}
