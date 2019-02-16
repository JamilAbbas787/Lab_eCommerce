using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using System.Web.ModelBinding;
using AHBC.SampleLab.Inventory.DAL;
using AHBC.SampleLab.Inventory.Models;

namespace AHBC.SampleLab.Inventory.Controllers.API
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InventoriesController : ApiController
    {
        private InventoryDBContext db = new InventoryDBContext();

        // GET: api/Inventories/5

        [ResponseType(typeof(Models.Inventory))]
        public async Task<IHttpActionResult> GetInventory(int id)
        {
            Models.Inventory inventory = await db.Inventories.FindAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }

            return Ok(inventory);
        }

        
        // POST: api/Inventories
        [ResponseType(typeof(Models.Inventory))]
        public async Task<IHttpActionResult> PostInventory(Models.Inventory inventory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Inventories.Add(inventory);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = inventory.ID }, inventory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InventoryExists(int id)
        {
            return db.Inventories.Count(e => e.ID == id) > 0;
        }
    }
}