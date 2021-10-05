using Microsoft.AspNetCore.Mvc;

using IdentityApp.Models;

namespace IdentityApp.Controllers
{
    public class HomeController : Controller 
    {
        private ProductDbContext _context;

        public HomeController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Products);
        }
    }
}