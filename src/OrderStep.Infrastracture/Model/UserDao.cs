using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Model
{
    internal class UserDao
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        ///     Имя
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        ///     Фамилия
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        ///     Очество
        /// </summary>
        public string SurName { get; set; } = string.Empty;

        /// <summary>
        ///  Маил
        /// </summary>
        public string? Email { get; set; }
    }
}
