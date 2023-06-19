using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Model
{
    public class UserAndRight
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Клиент
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Действие
        /// </summary>
        public Actions? Action { get; set; }

        /// <summary>
        /// Статус доступности
        /// </summary>
        public Right? Right { get; set; }
    }
}
