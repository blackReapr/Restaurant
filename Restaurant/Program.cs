using Restaurant.Core.Enums;
using Restaurant.Service.Services;

Console.WriteLine("salam");


MenuItemService menuItemService = new();

menuItemService.Add(new()
{
    Name = "Soup",
    Category = Category.Breakfast,
    Price = 10
});



void MainMenu()
{
    Console.WriteLine("1. Operations on the Menu");
    Console.WriteLine("2. Operations on the Orders");
    Console.WriteLine("0. Quit");
}

void MenuMenu()
{
    Console.WriteLine("1. Add New Item");
    Console.WriteLine("2. Update Item");
    Console.WriteLine("3. Delete Item");
    Console.WriteLine("4. Show All Items");
    Console.WriteLine("5. Show Items By Category");
    Console.WriteLine("6. Show Items By Price Interval");
    Console.WriteLine("7. Search By Names");
    Console.WriteLine("0. Return to the previous menu");
}

void OrderMenu()
{
    Console.WriteLine("1. Add New Order");
    Console.WriteLine("2. Cancel Order");
    Console.WriteLine("3. Show All Orders");
    Console.WriteLine("4. Show Orders By Date Interval");
    Console.WriteLine("5. Show Orders By Price Interval");
    Console.WriteLine("6. Show Orders By Specific Date");
    Console.WriteLine("7. Show Order By Id Number");
    Console.WriteLine("0. Return to the previous menu");
}