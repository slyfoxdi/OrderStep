using OrderStep.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Core.Model
{
    public class Order
    {
        /// <summary>
        /// Id заказа
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Артикул
        /// </summary>
        public string VendorCode { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Вес
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// Кол-во
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Адрес доставки
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Дата создания обращения
        /// </summary>
        public DateTime DateCreate { get; set; } = DateTime.Now;

        /// <summary>
        /// Статус заказа
        /// </summary>
        public TransferType TransferStatus { get; set; }
    }
}
