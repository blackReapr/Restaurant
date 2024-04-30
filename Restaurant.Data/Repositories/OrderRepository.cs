using Restaurant.Core.Entities;
using Restaurant.Data.Interfaces;

namespace Restaurant.Data.Repositories;

public class OrderRepository:Repository<Order>, IRepository<Order>
{
    IEnumerable<Order> GetOrdersByDatesInterval(DateTime startDate, DateTime endDate) => RestaurantDbContext.Set<Order>().Where(o => o.Date > startDate && o.Date < endDate);
    IEnumerable<Order> GetOrderByDate(DateTime dateTime) => RestaurantDbContext.Set<Order>().Where(o => o.Date == dateTime);
    IEnumerable<Order> GetOrdersByPriceInterval(int startPrice, int endPrice) => RestaurantDbContext.Set<Order>().Where(o => o.TotalAmount > startPrice && o.TotalAmount < endPrice);
    IEnumerable<Order> GetOrderByNo(int Id) => RestaurantDbContext.Set<Order>().Where(o => o.Id == Id);
}
