using Microsoft.AspNetCore.Mvc;

using IdentityApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace IdentityApp.Controllers
{
    [Authorize]
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