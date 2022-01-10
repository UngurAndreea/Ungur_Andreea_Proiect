using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ungur_Andreea_Proiect.Models;

namespace Ungur_Andreea_Proiect.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            if (context.Products.Any())
            {
                return;
            }
            var products = new Product[]
            {
                new Product{Name="Iphone",Price=Decimal.Parse("22")},
                new Product{Name="Televizor LED",Price=Decimal.Parse("18")},
                new Product{Name="Mouse",Price=Decimal.Parse("27")}
            };
            foreach (Product s in products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();

            var customers = new Customer[] {
                 new Customer{CustomerID=1050,Name="Velcherean Mihai",BirthDate=DateTime.Parse("1985-04-03")},
            new Customer{CustomerID=1045,Name="Tagorean Marinela",BirthDate=DateTime.Parse("1996-10-08")},
            };

            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var orders = new Order[]
            {
                 new Order{ProductID=1,CustomerID=1050},
                new Order{ProductID=3,CustomerID=1045},
                new Order{ProductID=1,CustomerID=1045},
                new Order{ProductID=2,CustomerID=1050}

            };
            {

                foreach (Order e in orders)
                {
                    context.Orders.Add(e);
                }
                context.SaveChanges();

                var categories = new Category[]
                {
                    new Category { CategoryName = "Laptop, Tablete & Telefoane" },
                    new Category { CategoryName = "PC & periferice" },
                    new Category { CategoryName = "TV, Audio-Video" }


                };

                foreach (Category k in categories)
                {
                    context.Categories.Add(k);
                }
                context.SaveChanges();

                var brands = new Brand[]
                {
                    new Brand { BrandName = "Apple" },
                    new Brand { BrandName = "Asus" },
                    new Brand { BrandName = "LG" }

                };
                {


                };
                foreach (Brand b in brands)
                {
                    context.Brands.Add(b);
                }
                context.SaveChanges();
            }
        }

    }
}
