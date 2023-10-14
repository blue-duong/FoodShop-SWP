using FoodShop_SWP.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
