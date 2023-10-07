using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCondoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var market = new Market();

            // Меню
            while (true)
            {
                Console.WriteLine("Menu:\n" +
                    "1. Mehsul elave et\n" +
                    "2. Mehsul satmaq\n" +
                    "3. ПMehsula baxmaq\n" +
                    "4. Menyudan cixmaq");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                       
                        Console.WriteLine("Mehsulun nomresin daxil et:");
                        var number = Console.ReadLine();

                        Console.WriteLine("Mehsulun adin daxil et:");
                        var name = Console.ReadLine();

                        Console.WriteLine("Mehsulun qiymetin daxil et:");
                        var price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Mehsulun sayin daxil et:");
                        var quantity = int.Parse(Console.ReadLine());

                        market.AddProduct(new Product(number, name, price, quantity));
                        break;

                    case "2":
                    
                        Console.WriteLine("Satmaq istediyiniz mehsulun nomresin daxil edin:");
                        var numberToSell = Console.ReadLine();

                        market.SellProduct(numberToSell);
                        break;

                    case "3":
                    
                        foreach (var product in market.Products)
                        {
                            Console.WriteLine("Ad: {0}, Nomre: {1}, Qiymet: {2}, Say: {3}", product.Name, product.Number, product.Price, product.Quantity);
                        }
                        break;

                    case "4":
                        
                        Environment.Exit(0);
                        break;

                    default:
                       
                        Console.WriteLine("Sehv.");
                        break;
                }
            }
        }
    }
}


