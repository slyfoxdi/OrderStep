using AutoMapper;
using OrderStep.Core.Model;
using OrderStep.Infrastracture.Model;
using OrderStep.Infrastracture.Repository.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Domain.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<int> GetFreeOrderId(CancellationToken cancellationToken)
        {
            return await _orderRepository.GetFreeOrderId(cancellationToken);
        }

        public async Task<bool> SaveNewOrder(Order order, CancellationToken cancellationToken)
        {
            var orderModel = _mapper.Map<OrderDao>(order);
            orderModel.TransferStatus = TransferStatusDao.New;

            return await _orderRepository.SaveOrder(orderModel, cancellationToken);
        }
    }
}
