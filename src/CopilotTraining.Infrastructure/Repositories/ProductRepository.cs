using CopilotTraining.Domain.Entities;
using CopilotTraining.Domain.Interfaces;

namespace CopilotTraining.Infrastructure.Repositories;

public class ProductRepository : IRepository<Product>
{
    private readonly List<Product> _products = new();

    public Task<Product?> GetByIdAsync(Guid id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        return Task.FromResult(product);
    }

    public Task<IEnumerable<Product>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Product>>(_products);
    }

    public Task AddAsync(Product entity)
    {
        _products.Add(entity);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Product entity)
    {
        var index = _products.FindIndex(p => p.Id == entity.Id);
        if (index >= 0)
        {
            _products[index] = entity;
        }
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
        return Task.CompletedTask;
    }
}