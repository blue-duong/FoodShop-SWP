using FoodShop_SWP.Models;
using FoodShop_SWP.Models.EF;
using FoodShop_SWP.Models.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodShop_SWP.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class NewController : Controller
    {
        ShopFoodWebContext db = new ShopFoodWebContext();
        [Route("blog")]
        public IActionResult Index()
        {   
            var items = db.News.OrderByDescending(x => x.Id).ToList();
            return View(items);
        }
        [Route("blog/Add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [Route("blog/Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(News model)
        {   
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.Alias = FoodShop_SWP.Models.Common.Filter.FilterChar(model.Title);
                db.News.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [Route("blog/Edit")]
        [HttpGet]
        public IActionResult Edit(int id)
        {   
            var item = db.News.Find(id);
            return View(item);
        }
        [Route("blog/Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(News model)
        {
            if (ModelState.IsValid)
            {
                db.News.Attach(model);
                model.ModifiedDate = DateTime.Now;
                model.Alias = FoodShop_SWP.Models.Common.Filter.FilterChar(model.Title);
                db.Entry(model).Property(x => x.Title).IsModified = true;
                db.Entry(model).Property(x => x.Image).IsModified = true;
                db.Entry(model).Property(x => x.Detail).IsModified = true;
                db.Entry(model).Property(x => x.Description).IsModified = true;
                db.Entry(model).Property(x => x.Alias).IsModified = true;
                db.Entry(model).Property(x => x.SeoDescription).IsModified = true;
                db.Entry(model).Property(x => x.SeoKeywords).IsModified = true;
                db.Entry(model).Property(x => x.SeoTitle).IsModified = true;
                db.Entry(model).Property(x => x.ModifiedDate).IsModified = true;
                db.Entry(model).Property(x => x.Modifiedby).IsModified = true;
                db.Entry(model).Property(x => x.IsActive).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var validationErrors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            ViewBag.ValidationErrors = validationErrors;
            return View(model);
        }
        [Route("blog/Delete")]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.News.Find(id);
            if (item != null)
            {
                //var DeleteItem = db.Categories.Attach(item);
                db.News.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}
