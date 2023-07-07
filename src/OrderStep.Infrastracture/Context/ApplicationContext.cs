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
        #region Права доступа

        /// <summary>
        /// Пользователь
        /// </summary>
        public DbSet<UserDao> Users { get; set; }

        /// <summary>
        /// Права доступа
        /// </summary>
        public DbSet<RightDao> Rights { get; set; }

        /// <summary>
        /// Действия
        /// </summary>
        public DbSet<ActionsDao> Actions { get; set; }

        /// <summary>
        /// Пользователи и права доступа
        /// </summary>
        public DbSet<UserAndRightDao> UserAndRights { get; set; }
        
        /// <summary>
        /// Данные для входа
        /// </summary>
        public DbSet<CredentialDao> Credits { get; set; }

        #endregion

        private string _connectionString;

        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
