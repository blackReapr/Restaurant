using Restaurant.Core.Entities;
using Restaurant.Core.Enums;
using Restaurant.Data.Interfaces;

namespace Restaurant.Data.Repositories;

public class MenuItemRepository:Repository<MenuItem>, IRepository<MenuItem>
{
    IEnumerable<MenuItem> GetMenuItemsByCategory(Category category) => _table.Where(x => x.Category == category);
    IEnumerable<MenuItem> GetMenuItemsByPriceInterval(int startPrice, int endPrice) => _table.Where(x => x.Price > startPrice && x.Price < endPrice);
}
