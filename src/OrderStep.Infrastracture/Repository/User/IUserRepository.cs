using OrderStep.Infrastracture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Repository.User
{
    public interface IUserRepository
    {
        /// <summary>
        /// Получение клиента по его id
        /// </summary>
        /// <param name="clientCode">id клиента в системе</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<UserDao> GetUserById(int clientCode, CancellationToken cancellationToken);

    }
}
