using Restaurant.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Entities;

public class MenuItem: BaseEntity
{
    [Required]
    public string Name { get; set; }

    [Required]
    public int Price { get; set; }

    [Required]
    public Category Category { get; set; }
}
