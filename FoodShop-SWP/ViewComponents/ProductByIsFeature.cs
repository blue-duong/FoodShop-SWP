using FoodShop_SWP.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop_SWP.ViewComponents
{
    public class ProductByIsFeature : ViewComponent
    {
        private readonly ShopFoodWebContext _context;
        public ProductByIsFeature(ShopFoodWebContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(int cateId)
        {
            var items = _context.Products.Where(x => x.IsFeature && x.IsActive).Take(8).ToList();
            return View(items);
        }
    }
}
