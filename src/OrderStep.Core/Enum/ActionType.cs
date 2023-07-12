using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Core.Enum
{
    public enum ActionType
    {
        /// <summary>
        /// Авторизация
        /// </summary>
        Auth = 1,

        /// <summary>
        /// Заказ наряд
        /// </summary>
        Order = 2,

        /// <summary>
        /// Транспортировка
        /// </summary>
        Transfer = 3
    }
}
