using Restaurant.Core.Entities;
using Restaurant.Data.Repositories;

namespace Restaurant.Service.Services;

public class OrderService
{
    public OrderRepository OrderRepository { get; set; }

    public OrderService()
    {
        OrderRepository = new();
    }

    void Add(Order order)
    {
        OrderRepository.Add(order);
    }

    void Update(int? id, Order order)
    {
        if (order == null) throw new IdNotGivenException("Id is not given");
        OrderRepository.Update(order);
    }
}
