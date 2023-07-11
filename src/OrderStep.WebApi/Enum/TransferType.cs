using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.WebApi.Enum
{
    public enum TransferType
    {
        /// <summary>
        /// Новый
        /// </summary>
        New = 10,

        /// <summary>
        /// Принят в обработку
        /// </summary>
        Processing = 20,

        /// <summary>
        /// Доставлен
        /// </summary>
        Delivered = 30,

        /// <summary>
        /// В архиве
        /// </summary>
        Archive = 40,

        /// <summary>
        /// Отменен
        /// </summary>
        Canceled = 50
    }
}
