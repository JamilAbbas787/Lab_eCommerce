using AHBC_SampleLab.eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AHBC_SampleLab.eCommerce.DAL
{
    public class ProductsDBContext : DbContext
    {
        public ProductsDBContext() : base("ProductContext")
        {
            Database.SetInitializer(new ProductDbIntializer());
        }

        public DbSet<Product> Products { get; set; }

    }
}