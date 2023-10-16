using FoodShop_SWP.Models.EF;
using FoodShop_SWP.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FoodShop_SWP.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class ProductController : Controller
    {
        ShopFoodWebContext db = new ShopFoodWebContext();
        [Route("product")]
        public IActionResult Index(string Searchtext, int? page)
        {
            int pageSize = 6;
            if (page == null)
            {
                page = 1;
            }
            //IEnumerable<News> items = db.News.OrderByDescending(x => x.Id);
            //if (!string.IsNullOrEmpty(Searchtext))
            //{
            //    items = items.Where(x => x.Alias.Contains(Searchtext) || x.Title.Contains(Searchtext));
            //}
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var items = db.Products.AsNoTracking().OrderByDescending(x => x.Id);
            PagedList<Product> list = new(items, pageNumber, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(list);
        }
        [Route("product/Add")]
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.ProductCategory = new SelectList(db.ProductCategories.ToList(), "Id", "Title");
            return View();
        }
        [Route("product/Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.Alias = FoodShop_SWP.Models.Common.Filter.FilterChar(model.Title);
                db.Products.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            var validationErrors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            ViewBag.ValidationErrors = validationErrors;
            return View(model);
        }
        [Route("product/Edit")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            
            ViewBag.ProductCategory = new SelectList(db.ProductCategories.ToList(), "Id", "Title");
            var item = db.Products.Find(id);
            return View(item);
        }
        [Route("product/Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                db.Products.Attach(model);
                model.ModifiedDate = DateTime.Now;
                model.Alias = FoodShop_SWP.Models.Common.Filter.FilterChar(model.Title);
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var validationErrors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            ViewBag.ValidationErrors = validationErrors;
            return View(model);
        }
        [Route("product/Delete")]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Products.Find(id);
            if (item != null)
            {
                db.Products.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }
    }
}