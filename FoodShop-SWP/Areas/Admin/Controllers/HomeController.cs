using FoodShop_SWP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace FoodShop_SWP.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class HomeController : Controller
    {
        ShopDaiContext db = new ShopDaiContext();
        [Route("")]
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("product-list")]
        public IActionResult ProductList()
        {
            var productList = db.Products.Include(a => a.ProductDetailInfos).Include(a=> a.ProductImages).ToList();

            return View(productList);
        }
        [Route("AddProduct")]
        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.CategoryGroupId = new SelectList(db.CategorGroups.ToList(), "id", "name");
            return View();
        }
        [Route("AddProduct")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("ProductList");
            }
            return View(product);
                
        }

    }
}
