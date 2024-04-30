﻿using Restaurant.Core.Entities;
using Restaurant.Core.Enums;
using Restaurant.Enums;
using Restaurant.Service.Services;



MenuItemService menuItemService = new();
OrderService orderService = new();

bool isRunning = true;
MenuEnum menu = MenuEnum.MainMenu;

while (isRunning)
{
    switch (menu)
    {
        case MenuEnum.MainMenu:
            MainMenu();
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0) isRunning = false;
                menu = choice switch
                {
                    1 => MenuEnum.MenuMenu,
                    2 => MenuEnum.OrderMenu,
                    _ => MenuEnum.MainMenu
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case MenuEnum.MenuMenu:
            MenuMenu();
            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    AddMenuItem:
                        try
                        {
                            Console.WriteLine("Enter the name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the price");
                            int price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Select category: ");
                            Category category = (Category)int.Parse(Console.ReadLine());
                            menuItemService.Add(new() { Category = category, Name = name, Price = price });
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto AddMenuItem;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the id of the item you want to update: ");
                        try
                        {
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the name: ");
                            string name = Console.ReadLine();
                            int price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Select category: ");
                            Category category = (Category)int.Parse(Console.ReadLine());
                            menuItemService.Update(id, new() { Name = name, Category = category, Price = price });
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the id of the item you want to delete");
                        try
                        {
                            int id = int.Parse(Console.ReadLine());
                            menuItemService.Remove(id);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 4:
                        foreach (MenuItem item in menuItemService.Get())
                            Console.WriteLine(item);
                        break;
                    case 5:
                        Console.WriteLine("Enter category");
                        try
                        {
                            Category category = (Category)int.Parse(Console.ReadLine());
                            foreach (MenuItem item in menuItemService.GetItemsByCategory(category))
                            {
                                Console.WriteLine(item);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 6:
                        try
                        {
                            Console.WriteLine("Enter start price: ");
                            int startPrice = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter end price: ");
                            int endPrice = int.Parse(Console.ReadLine());
                            menuItemService.GetItemsByPriceInterval(startPrice, endPrice);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Enter the name: ");
                        try
                        {
                            string name = Console.ReadLine();
                            foreach (MenuItem item in menuItemService.GetItemsByName(name))
                            {
                                Console.WriteLine(item);
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 0:
                        menu = MenuEnum.MainMenu;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;
        case MenuEnum.OrderMenu:
            OrderMenu();
            break;
        default:
            break;
    }
}



void MainMenu()
{
    Console.WriteLine("1. Operations on the Menu");
    Console.WriteLine("2. Operations on the Orders");
    Console.WriteLine("0. Quit");
}

void MenuMenu()
{
    Console.WriteLine("1. Add Item");
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