using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

using IdentityApp.Models;

namespace IdentityApp.Pages
{
    [Authorize]
    public class StoreModel : PageModel 
    {
        public StoreModel(ProductDbContext context)
        {
            DbContext = context;
        }

        public ProductDbContext DbContext { get; set; }
    }
}