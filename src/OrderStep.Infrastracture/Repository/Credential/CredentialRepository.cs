using Microsoft.EntityFrameworkCore;
using OrderStep.Core.Exceptions;
using OrderStep.Infrastracture.Context;
using OrderStep.Infrastracture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Repository.Credential
{
    public class CredentialRepository : ICredentialRepository
    {
        private readonly ApplicationContext _context;

        public CredentialRepository(ApplicationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<int> GetUserIdByAuthentification(string login, string password, CancellationToken cancellationToken)
        {
            var credetial = await _context.Credits
                .Where(x => x.Login == login && x.Password == password)
                .Include(x => x.User)
                .FirstOrDefaultAsync(cancellationToken);

            if(credetial == null)
            {
                throw new InfrastractureException("Неверно введен логин/пароль");
            }

            return credetial.User.Id;
        }
    }
}
