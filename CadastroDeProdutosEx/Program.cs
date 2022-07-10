using System;
using System.Collections.Generic;
using System.Globalization;
using CadastroDeProdutosEx.Entities;

namespace CadastroDeProdutosEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Product>  products = new List <Product> ();

            Console.Write("Enter the number of Products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, Used or Imported (c/u/i)? ");
                char cui = char.Parse(Console.ReadLine());
                string name = "";
                double price = 0.0;
                DateTime manufacture = new DateTime();
                double customFee = 0.0;
                if(cui == 'c')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                else if (cui == 'u')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    manufacture = DateTime.Parse(Console.ReadLine()); 
                    UsedProduct usedProduct = new UsedProduct(name,price,manufacture);
                    products.Add(usedProduct);
                }
                else
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    customFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    ImportedProduct importedProduct = new ImportedProduct(name,price,customFee);
                    products.Add(importedProduct);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
            
        }
    }
}