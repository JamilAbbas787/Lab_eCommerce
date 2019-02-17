using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AHBC_SampleLab.eCommerce.DAL;
using AHBC_SampleLab.eCommerce.Models;
using System.Web.Http.Description;
using System.Web.Http;
using AHBC.SampleLab.Inventory.Models;
using System.Net.Http;

namespace AHBC_SampleLab.eCommerce.Controllers
{
    public class ProductsController : Controller
    {
        private ProductsDBContext db = new ProductsDBContext();
        static HttpClient client = new HttpClient();


        // GET: Products
        public async Task<ActionResult> Index()
        {
            return View(await db.Products.ToListAsync());
        }


        // GET: Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
