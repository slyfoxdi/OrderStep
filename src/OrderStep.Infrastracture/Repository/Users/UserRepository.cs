using OrderStep.Core.Exceptions;
using OrderStep.Infrastracture.Context;
using OrderStep.Infrastracture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Repository.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<UserDao> GetUserById(int clientCode, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .FindAsync(clientCode, cancellationToken);

            if (user == null)
            {
                throw new InfrastractureException("Не удалось авторизоваться");
            }

            return user;
        }
    }
}
