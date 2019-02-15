using AHBC_SampleLab.eCommerce.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace AHBC_SampleLab.eCommerce.DAL
{
    internal class ProductDbIntializer : CreateDatabaseIfNotExists<ProductsDBContext>
    {
        protected override void Seed(ProductsDBContext context)
        {
            var products = new List<Product>
            {
                new Product{ ItemId = "1" , Name = "White T-Shirt", Descriptions = "A cozy shirt with tags", Price = 5.00},
                new Product{ ItemId = "2" , Name = "Socks", Descriptions = "Ankle Socks", Price = 5.00},
                new Product{ ItemId = "3" , Name = "Blue Hat", Descriptions = "The coolest blue hat ever", Price = 5.00},
                new Product{ ItemId = "4" , Name = "Skateboard", Descriptions = "Sick tricks", Price = 5.00},
                new Product{ ItemId = "5" , Name = "Biker Helmet", Descriptions = "With a flame", Price = 5.00},
                new Product{ ItemId = "6" , Name = "Khaki Dockers", Descriptions = "Pants or Containers, you decide", Price = 5.00}
            };

            context.Products.AddRange(products);
            context.SaveChanges();

        }

    }
}