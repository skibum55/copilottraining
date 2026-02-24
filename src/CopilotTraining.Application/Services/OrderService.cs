using CopilotTraining.Domain.Entities;
using CopilotTraining.Domain.Interfaces;

namespace CopilotTraining.Application.Services;

public class OrderService
{
    private readonly IRepository<Order> _orderRepository;
    private readonly IRepository<Product> _productRepository;

    public OrderService(
        IRepository<Order> orderRepository,
        IRepository<Product> productRepository)
    {
        _orderRepository = orderRepository;
        _productRepository = productRepository;
    }

    public async Task<Order?> GetOrderAsync(Guid id)
    {
        return await _orderRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Order>> GetAllOrdersAsync()
    {
        return await _orderRepository.GetAllAsync();
    }

    // TODO: Implement CreateOrderAsync
    // TODO: Implement UpdateOrderStatusAsync
    // TODO: Implement CalculateOrderTotalAsync
}