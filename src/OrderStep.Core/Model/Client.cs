using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Core.Model
{
    public class Client
    {
        /// <summary>
        /// Id клиента в системе
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Описание клиента
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Id роли
        /// </summary>
        public int Role { get; set; }
    }
}
