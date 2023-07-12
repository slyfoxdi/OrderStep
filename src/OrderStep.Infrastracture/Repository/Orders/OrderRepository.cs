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
                TransferStatus = TransferStatusDao.Created
            };

            await _context.Orders.AddAsync(orderDao, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return lastOrderId;
        }

        /// <inheritdoc/>
        public async Task<bool> SaveOrder(OrderDao order, CancellationToken cancellationToken)
        {
            var orderDao = _context.Orders.FirstOrDefault(x => x.OrderId == order.OrderId);

            if (orderDao == null)
            {
                return false;
            }

            orderDao.Address = order.Address;
            orderDao.Price = order.Price;
            orderDao.VendorCode = order.VendorCode;
            orderDao.DateLastUpdate = order.DateLastUpdate;
            orderDao.Count = order.Count;
            orderDao.Weight = order.Weight;
            orderDao.Name = order.Name;
            orderDao.TransferStatus = order.TransferStatus;

            var result = await _context.SaveChangesAsync(cancellationToken);

            return result > 0;
        }
    }
}
