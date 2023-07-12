using OrderStep.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Domain.Service
{
    public interface IOrderService
    {
        /// <summary>
        /// Сохранение заказа
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        Task<bool> SaveNewOrder(Order order, CancellationToken cancellationToken);

        /// <summary>
        /// Получение последнего id
        /// </summary>
        /// <returns></returns>
        Task<int> GetFreeOrderId(CancellationToken cancellationToken);
    }
}
