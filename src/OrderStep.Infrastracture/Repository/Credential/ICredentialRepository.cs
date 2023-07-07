using OrderStep.Infrastracture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Repository.Credential
{
    public interface ICredentialRepository
    {
        /// <summary>
        /// Получение данных клиента по кредам
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">парот</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Id клиента в системе</returns>
        Task<int> GetUserIdByAuthentification(string login, string password, CancellationToken cancellationToken);
    }
}
