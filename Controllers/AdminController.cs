using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using IdentityApp.Models;

namespace IdentityApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller 
    {
        private ProductDbContext _context;

        public AdminController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Edit", new Product());
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            Product p = _context.Find<Product>(id);
            if (p != null)
            {
                return View("Edit", p);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Save(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            Product p = _context.Find<Product>(id);
            if (p != null)
            {
                _context.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}