using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using IdentityApp.Models;

namespace IdentityApp.Pages
{
    public class AdminModel : PageModel 
    {
        public AdminModel(ProductDbContext context)
        {
            DbContext = context;
        }

        public ProductDbContext DbContext { get; set; }

        public IActionResult OnPost(long id)
        {
            Product p = DbContext.Find<Product>(id);
            if (p != null)
            {
                DbContext.Remove(p);
                DbContext.SaveChanges();
            }

            return Page();
        }
    }
}