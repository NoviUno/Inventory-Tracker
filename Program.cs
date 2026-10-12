using System;
using System.ComponentModel.Design;

namespace InventoryTracker
{
  class Program
  {
    static List<Products> inventory = new List<Products>();

    static void Main(string[] args)
    {
      Console.WriteLine("Hello User! Welcome to Inventory Tracker Console App!");
      Console.WriteLine();
      int userChoice;
      bool running = true;
      void Menu()
        {    
            string[] menu =
            {
                "Exit",
                "Add Product",
                "View Product",
                "Search Product",
                "Delete Product",
                "Update Product",
                "View Inventory Summary",
                "View Low stock Product"
            };
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("======== MENU ========");
                Console.WriteLine();
            for(int i=0; i<menu.Length;i++)
                {
                    Console.WriteLine(i + " " + menu[i]);  
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Enter a Number: ");
                userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        AddProduct();
                        running = whatsNext();
                        break;
                    case 2:
                        ViewProduct();
                        running = whatsNext();
                        break;
                    case 3:
                        searchProduct();
                        break;
                    case 4:
                        DeleteProduct();
                        break;
                    case 5:
                        UpdateProduct();
                        break;
                    case 6:
                        ViewInventorySummary();
                        break;
                    case 7:
                        ViewLowStockProduct();
                        break;

                    default:
                        Console.WriteLine("Please try again");
                        break;
                } 
            }
        }
        Menu();
        static void AddProduct()
        {
            Console.WriteLine("======== Add Product ========");
            Console.WriteLine();
            Console.Write("Enter Product Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            string Name = (Console.ReadLine() ?? "").Trim();
            if (string.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("Name Required!");
                return;
            }
            Console.Write("Enter Product Price: ");
            decimal Price = Convert.ToDecimal(Console.ReadLine());
            if(Price < 0)
            {
                Console.WriteLine("Price must not be Negative!");
                return;
            }
            Console.Write("Enter Product Quantity: ");
            int Quantity = Convert.ToInt32(Console.ReadLine());
            if(Quantity < 0)
            {
                Console.WriteLine("Quantity must not be Negative!");
                return;
            }

            Products products = new Products(Id,Name,Price,Quantity);
            inventory.Add(products);
            Console.WriteLine("Product Added Successfully!");
            Console.WriteLine("Add New Products? ");
            Console.Write("Y/N?");
            string yn = (Console.ReadLine()) ?? "".Trim();
            if(yn == "y" || yn== "Y")
            {
                AddProduct();
            }

        }
        static void ViewProduct()
        {
            Console.WriteLine("View Products: ");

            if(inventory.Count == 0)
            {
                Console.WriteLine("No Product Available");
                return;
            }
            foreach(Products products in inventory)
            {
                Console.WriteLine($"Id: {products.Id}");
                Console.WriteLine($"Name: {products.Name}");
                Console.WriteLine($"Price: ${products.Price}");
                Console.WriteLine($"Quantity: {products.Quantity}");
                Console.WriteLine();
                
            }
        }
        static void searchProduct()
            {
                return;
            }
        static void DeleteProduct()
            {
                return;
            }
        static void UpdateProduct()
            {
                return;
            }
        static void ViewInventorySummary()
            {
                return;
            }
        static void ViewLowStockProduct()
            {
                return;
            }
        static bool whatsNext()
        {
            Console.WriteLine();
            Console.Write("[0] Menu | [1] Exit: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                return false; // Exit the program
            }

            return true; // Return to the menu
        }
    }
  }
}





