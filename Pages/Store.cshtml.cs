using Microsoft.AspNetCore.Mvc.RazorPages;

using IdentityApp.Models;

namespace IdentityApp.Pages
{
    public class StoreModel : PageModel 
    {
        public StoreModel(ProductDbContext context)
        {
            DbContext = context;
        }

        public ProductDbContext DbContext { get; set; }
    }
}