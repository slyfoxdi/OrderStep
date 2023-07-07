using OrderStep.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Intregration
{
    public interface IAuthReference
    {
        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        BaseResponse<Client> Authentification(string login, string password);
    }
}
