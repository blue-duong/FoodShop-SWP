using FoodShop_SWP.Models;
using FoodShop_SWP.Models.EF;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop_SWP.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    
    public class PostController : Controller
    {
        ShopFoodWebContext db = new ShopFoodWebContext();
        [Route("post")]   
        
        public IActionResult Index()
        {
            return View();
        }
        [Route("post/Add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [Route("post/Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Posts model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [Route("post/Edit")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = db.Posts.Find(id);
            return View(item);
        }
        [Route("post/Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Posts model)
        {
            if (ModelState.IsValid) 
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
