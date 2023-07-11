using Microsoft.EntityFrameworkCore;
using OrderStep.Core.Model;
using OrderStep.Infrastracture.Context;
using OrderStep.Infrastracture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Repository.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context;

        public OrderRepository(ApplicationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<int> GetFreeOrderId(CancellationToken cancellationToken)
        {
            var lastOrderId = 1;
            try
            {
                lastOrderId = await _context.Orders.MaxAsync(x => x.OrderId, cancellationToken) + 1;
            }
            catch 
            { 
                //silent
            }

            var orderDao = new OrderDao() 
            { 
                OrderId = lastOrderId,
            };

            await _context.Orders.AddAsync(orderDao, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return lastOrderId;
        }

        /// <inheritdoc/>
        public async Task<bool> SaveOrderList(IList<OrderDao> order, CancellationToken cancellationToken)
        {
            _context.Orders.UpdateRange(order);
            var result = await _context.SaveChangesAsync(cancellationToken);

            return result > 0;
        }
    }
}
