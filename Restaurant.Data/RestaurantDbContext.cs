using Microsoft.EntityFrameworkCore;

namespace Restaurant.Data;

public class RestaurantDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-C20TBEU;Database=Restaurant;Trusted_Connection=Yes;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
}
