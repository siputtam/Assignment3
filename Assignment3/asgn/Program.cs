using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asgn
{
    class Program
    { 
            static void Main(string[] args)
            {
                List<Product> list_products = new List<Product>();
                var p1 = new Product("Lettuce", 10.5, 50, "Leafy Green");
                list_products.Add(p1);
                var p2 = new Product("Cabbage", 20, 100, "Cruciferous");
                list_products.Add(p2);
                var p3 = new Product("Pumpkin", 30, 30, "Marrow");
                list_products.Add(p3);
                var p4 = new Product("Cauliflower", 10, 25, "Cruciferous");
                list_products.Add(p4);
                var p5 = new Product("Zucchini", 20.5, 50, "Marrow");
                list_products.Add(p5);
                var p6 = new Product("Yam", 30, 50, "Root");
                list_products.Add(p6);
                var p7 = new Product("Spinach", 10, 100, "Leafy Green");
                list_products.Add(p7);
                var p8 = new Product("Broccoli", 20.2, 75, "Cruciferous");
                list_products.Add(p8);
                var p9 = new Product("Garlic", 30, 20, "Leafy Green");
                list_products.Add(p9);
                var p10 = new Product("Silverbeet", 10, 50, "Marrow");
                list_products.Add(p10);
                Console.WriteLine("Total list_products:" + list_products.Count);
                var p11 = new Product("Potato", 10, 50, "Root");
                list_products.Add(p11);
                Console.WriteLine("Afterr Adding total list_products:" + list_products.Count);
                foreach (Product p in list_products)
                {
                    Console.WriteLine(p.name + ":" + p.price + ":" + p.quantity + ":" + p.type);
                }
                Console.WriteLine("list_products of type Leafy green");
                foreach (Product p in list_products)
                {
                    if (p.type == "Leafy Green")
                    {
                        Console.WriteLine(p.name + ":" + p.price + ":" + p.quantity + ":" + p.type);
                    }
                }
                list_products.RemoveAll(x => x.name == "Garlic");
                Console.WriteLine("Now no of list_products:" + list_products.Count);
                for (int i = 0; i < list_products.Count; i++)
                {
                    if (list_products[i].name == "Cabbage")
                    {
			list_products[i].quantity += 50;
                        Console.WriteLine(list_products[i].quantity);

                    }
                }
                double total = 0;
                for (int i = 0; i < list_products.Count; i++)
                {
                    if (list_products[i].name == "Lettuce")
                    {
                        total = 1 * list_products[i].price;
                    }
                    if (list_products[i].name == "Zucchini")
                    {
                        total = total + 2 * list_products[i].price;
                    }
                    if (list_products[i].name == "Broccoli")
                    {
                        total = total + 1 * list_products[i].price;

                    }
                }
                Console.WriteLine(Convert.ToInt32(total));

            }
        }
}
