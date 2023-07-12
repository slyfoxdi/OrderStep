using OrderStep.Infrastracture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Repository.Orders
{
    public interface IOrderRepository
    {
        /// <summary>
        /// Сохранение заказа
        /// </summary>
        /// <param name="order"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> SaveOrder(OrderDao order, CancellationToken cancellationToken);

        /// <summary>
        /// Получение свободного id документа
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> GetFreeOrderId(CancellationToken cancellationToken);
    }
}
