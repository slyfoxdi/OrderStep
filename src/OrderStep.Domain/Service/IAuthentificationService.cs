using OrderStep.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Domain.Service
{
    public interface IAuthentificationService
    {
        /// <summary>
        /// Авторизация клиента в системе
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<BaseResponse<Client>> AuthentificationUser(string login, string password, CancellationToken cancellationToken);

    }
}
