using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ShopModel
{
    public static class Program
    {
        public static void Main()
        {
            //Используется IoC-контейнер Autofac

            var builder = new ContainerBuilder();
            builder.RegisterType<ValueCalculator>().As<ICalculator>();
            builder.RegisterType<ShoppingCart>().AsSelf();
            builder.Register(c => new ShoppingCart(c.Resolve<ICalculator>())
                {
                    Products = new List<Product>()
                        {
                            new Product {Name = "Product 1", Category = "C1", Description = "no", ProductID = 1, Price = 100},
                            new Product {Name = "Product 2", Category = "C2", Description = "no", ProductID = 2, Price = 200}
                        }
                });
            var container1 = builder.Build();
            var cart = container1.Resolve<ShoppingCart>();
            Console.WriteLine("Standart total price  = {0}$", cart.CalculateProductTotal(0));
            Console.WriteLine("Standart total price with discount 15%  = {0}$", cart.CalculateProductTotal(15));

            builder = new ContainerBuilder();
            builder.RegisterType<AnotherValueCalculator>().As<ICalculator>();
            builder.RegisterType<ShoppingCart>().AsSelf();
            builder.Register(c => new ShoppingCart(c.Resolve<ICalculator>())
            {
                Products = new List<Product>()
                        {
                            new Product {Name = "Product 1", Category = "C1", Description = "no", ProductID = 1, Price = 100},
                            new Product {Name = "Product 2", Category = "C2", Description = "no", ProductID = 2, Price = 200}
                        }
            });
            var container2 = builder.Build();
            cart = container2.Resolve<ShoppingCart>();
            Console.WriteLine("New total price = {0}$", cart.CalculateProductTotal(0));
        }
    }
}