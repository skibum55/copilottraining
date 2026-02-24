using CopilotTraining.Domain.Entities;
using CopilotTraining.Domain.Interfaces;

namespace CopilotTraining.Infrastructure.Repositories;

public class OrderRepository : IRepository<Order>
{
    private readonly List<Order> _orders = new();

    public Task<Order?> GetByIdAsync(Guid id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        return Task.FromResult(order);
    }

    public Task<IEnumerable<Order>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Order>>(_orders);
    }

    public Task AddAsync(Order entity)
    {
        _orders.Add(entity);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Order entity)
    {
        var index = _orders.FindIndex(o => o.Id == entity.Id);
        if (index >= 0)
        {
            _orders[index] = entity;
        }
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        if (order != null)
        {
            _orders.Remove(order);
        }
        return Task.CompletedTask;
    }
}