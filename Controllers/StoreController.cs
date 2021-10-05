using Microsoft.AspNetCore.Mvc;

using IdentityApp.Models;

namespace IdentityApp.Controllers
{
    public class StoreController : Controller 
    {
        private ProductDbContext _context;

        public StoreController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Products);
        }
    }
}