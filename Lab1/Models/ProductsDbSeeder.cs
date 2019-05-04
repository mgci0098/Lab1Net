using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class ProductsDbSeeder
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Apa",
                    Description = "Plata",
                    Category = "Sticla",
                    Price = 10
                },
                new Product
                {
                    Name = "Laptop",
                    Description = "Asus",
                    Category = "Electronice",
                    Price = 500
                }
            );
            context.SaveChanges();
        }



    }
}
