using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AHBC.SampleLab.Inventory.DAL
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext() : base("InventoryContext")
        {
            Database.SetInitializer(new InventoryDBIntializer());
        }

        public DbSet<Models.Inventory> Inventories { get; set; }

    }
}