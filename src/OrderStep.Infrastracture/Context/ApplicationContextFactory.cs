using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderStep.Infrastracture.Context;

namespace OrderStep.Infrastructure.App
{
    public class ApplicationContextFactory : IDbContextFactory<ApplicationContext>
    {
        private IConfiguration _configuration;
        public ApplicationContextFactory(
            IConfiguration configuration
            )
        {
            _configuration = configuration;
        }
        public ApplicationContext CreateDbContext()
        {
            var conntectionString = _configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
            return new ApplicationContext(conntectionString);
        }
    }
}