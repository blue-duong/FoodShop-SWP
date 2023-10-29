using FoodShop_SWP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FoodShop_SWP.Controllers
{
    
    public class HomeController : Controller
    {
        ShopDaiContext db = new ShopDaiContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {   
            var listAllProduct = db.Products.Include(p => p.ProductImages).ToList();

            return View(listAllProduct);
        }
        //public IActionResult GetImgByProductId(int a)
        //{
        //    var productImage = db.ProductImages.FirstOrDefault(pi => pi.ProductId == a);
        //    if (productImage != null) {
        //        string imgUrl = productImage.Url;
        //        return Content(imgUrl);
        //    }
        //    return Content(null);
        //}
        //public IActionResult Index(int productId)
        //{
        //    string imageUrl = GetImgByProductId(productId);
        //    ViewBag.ProductImageUrl = imageUrl;

        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}