using Microsoft.AspNetCore.Mvc.RazorPages;

using IdentityApp.Models;

namespace IdentityApp.Pages
{
    public class LandingModel : PageModel 
    {
        public LandingModel(ProductDbContext context)
        {
            DbContext = context;
        }

        public ProductDbContext DbContext { get; set; }
    }
}