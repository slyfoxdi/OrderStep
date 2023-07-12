using OrderStep.Api.Model;
using OrderStep.Api.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Intregration
{
    internal interface IOrderReference
    {
        /// <summary>
        /// Сохранение заказа
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        BaseResponse<bool> SaveOrder(OrderRequest order);

        /// <summary>
        /// Получение свободного Id
        /// </summary>
        /// <returns></returns>
        BaseResponse<int> GetFreeOrderId();
    }
}
