using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Model
{
    internal class OrderDao
    {
        [Key]
        public int Id { get; set; }

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
        /// Дата последнего обновления
        /// </summary>
        public DateTime DateLastUpdate { get; set; } = DateTime.Now;

        /// <summary>
        /// Статус заказа
        /// </summary>
        public TransferStatusDao TransferStatus { get; set; }
    }
}
