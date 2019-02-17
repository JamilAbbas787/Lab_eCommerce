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
using System.Web.Http.Description;
using System.Web.Services.Description;
using AHBC_SampleLab.eCommerce.DAL;
using AHBC_SampleLab.eCommerce.Models;
using static System.Net.WebRequestMethods;
using AHBC.SampleLab.Inventory.Models;

namespace AHBC_SampleLab.eCommerce.Controllers
{
    public class OrderController : ApiController
    {
        private ProductsDBContext db = new ProductsDBContext();
        static HttpClient client = new HttpClient();

        // POST: api/PostProduct
        [ResponseType(typeof(Product))]
        [HttpPost]
        public async Task<IHttpActionResult> PostProduct(int quantity, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            await client.PostAsJsonAsync("http://localhost:55349/api/Inventories", new Inventory
            {
                //ID = product.Id,
                //Quantity = quantity

            });

            return RedirectToRoute("Index", "Products");
        }
 

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Products.Count(e => e.Id == id) > 0;
        }
    }
}