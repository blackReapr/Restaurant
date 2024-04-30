using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Entities;

public class Order:BaseEntity
{
    [Required]
    public int TotalAmount { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    List<OrderItem> OrderItems { get; set; }
}
