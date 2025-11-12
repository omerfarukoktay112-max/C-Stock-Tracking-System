using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Tracking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productNames = new List<string>();
            List<int> productQuantities = new List<int>();
            List<double> productPrices = new List<double>();

            while (true)
            {
                Console.WriteLine("Stock Tracking System");
                Console.WriteLine("--------------------");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. List Products");
                Console.WriteLine("5. Total Stock Value");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option (1-6): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter price: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    productNames.Add(name);
                    productQuantities.Add(quantity);
                    productPrices.Add(price);

                    Console.WriteLine("Product added successfully!\n");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter product name to update: ");
                    string name = Console.ReadLine();

                    int index = productNames.IndexOf(name);
                    if (index != -1)
                    {
                        Console.Write("Enter new quantity: ");
                        productQuantities[index] = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter new price: ");
                        productPrices[index] = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Product updated successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("Product not found!\n");
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Enter product name to delete: ");
                    string name = Console.ReadLine();

                    int index = productNames.IndexOf(name);
                    if (index != -1)
                    {
                        productNames.RemoveAt(index);
                        productQuantities.RemoveAt(index);
                        productPrices.RemoveAt(index);

                        Console.WriteLine("Product deleted successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("Product not found!\n");
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Product List:");
                    Console.WriteLine("-------------");
                    for (int i = 0; i < productNames.Count; i++)
                    {
                        double totalValue = productQuantities[i] * productPrices[i];
                        Console.WriteLine($"{productNames[i]} - {productQuantities[i]} units - {productPrices[i]} TL - Total: {totalValue} TL");
                    }
                    Console.WriteLine();
                }
                else if (choice == "5")
                {
                    double totalStockValue = 0;
                    for (int i = 0; i < productNames.Count; i++)
                    {
                        totalStockValue += productQuantities[i] * productPrices[i];
                    }
                    Console.WriteLine("Total stock value: " + totalStockValue + " TL\n");
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please try again.\n");
                }
            }
        }
    }
}