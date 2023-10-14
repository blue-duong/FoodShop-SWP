using FoodShop_SWP.Models;
using FoodShop_SWP.Models.EF;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop_SWP.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class CategoryController : Controller
    {
        ShopFoodWebContext db = new ShopFoodWebContext();
        [Route("category")]
        public IActionResult Index()
        {   
            var items = db.Categories.ToList();
            return View(items);
        }
        [Route("category/Add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [Route("category/Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}
