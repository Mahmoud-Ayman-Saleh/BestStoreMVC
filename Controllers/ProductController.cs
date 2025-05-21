using BestStoreMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var product_list = context.Products.ToList();
            return View(product_list);
        }
    }
}
