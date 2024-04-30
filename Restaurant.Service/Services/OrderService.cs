using Restaurant.Core.Entities;
using Restaurant.Data.Repositories;
using Restaurant.Service.Exceptions;

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
        if (id == null) throw new IdNotGivenException("Id is not given");
        if (order.Date > DateTime.Now) throw new InvalidDateException("Date is not valid");
        OrderRepository.Update(order);
    }

    void Remove(int? id)
    {
        if (id == null) throw new IdNotGivenException("Id is not given");

    }


}
