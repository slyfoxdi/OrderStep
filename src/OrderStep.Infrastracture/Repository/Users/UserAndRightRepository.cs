using Microsoft.EntityFrameworkCore;
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
    public class UserAndRightRepository : IUserAndRightRepository
    {
        private readonly ApplicationContext _context;

        public UserAndRightRepository(ApplicationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<UserAndRightDao>> GetClientRights(int clientCode, CancellationToken cancellationToken)
        {
            var userAndRights = await _context.UserAndRights
                .Where(x => x.User.Id == clientCode)
                .Include(x => x.User)
                .Include(x => x.Action)
                .Include(x => x.Right)
                .ToListAsync(cancellationToken);


            if (userAndRights.Count() == 0)
            {
                throw new InfrastractureException("Не удалось загрузить права");
            }

            return userAndRights;
        }
    }
}
