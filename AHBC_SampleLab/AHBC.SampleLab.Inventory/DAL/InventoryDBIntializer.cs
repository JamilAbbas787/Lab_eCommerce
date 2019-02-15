using System.Collections.Generic;
using System.Data.Entity;

namespace AHBC.SampleLab.Inventory.DAL
{
    internal class InventoryDBIntializer : CreateDatabaseIfNotExists<InventoryDBContext>
    {

        protected override void Seed(InventoryDBContext context)
        {
            var inventories = new List<Models.Inventory>
            {
                new Models.Inventory{ ID = 1, Quantity = 12},
                new Models.Inventory{ ID = 2, Quantity = 13},
                new Models.Inventory{ ID = 3, Quantity = 12},
                new Models.Inventory{ ID = 4, Quantity = 12},
                new Models.Inventory{ ID = 5, Quantity = 12},
                new Models.Inventory{ ID = 6, Quantity = 12}
            };

            context.Inventories.AddRange(inventories);
            context.SaveChanges();

        }

    }
}