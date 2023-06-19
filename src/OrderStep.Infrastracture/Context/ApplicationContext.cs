using Microsoft.EntityFrameworkCore;
using OrderStep.Infrastracture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Context
{
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Права доступа
        /// </summary>
        public DbSet<Right> Rights { get; set; }

        /// <summary>
        /// Действия
        /// </summary>
        public DbSet<Actions> Actions { get; set; }

        /// <summary>
        /// Пользователи и права доступа
        /// </summary>
        public DbSet<UserAndRight> UserAndRights { get; set; }

        public ApplicationContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
