using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Model
{
    public class UserAndRightDao
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Клиент
        /// </summary>
        public UserDao? User { get; set; }

        /// <summary>
        /// Действие
        /// </summary>
        public ActionsDao? Action { get; set; }

        /// <summary>
        /// Статус доступности
        /// </summary>
        public RightDao? Right { get; set; }
    }
}
