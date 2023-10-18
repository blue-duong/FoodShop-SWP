using FoodShop_SWP.Models;
using Microsoft.AspNetCore.Mvc;
namespace FoodShop_SWP.ViewComponents
{
    public class MenuArrivals : ViewComponent
    {
        private readonly ShopFoodWebContext _context;
        public MenuArrivals(ShopFoodWebContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var items = _context.ProductCategories.OrderBy(x => x.CreatedBy);
            return View(items);
        }
    }
}
