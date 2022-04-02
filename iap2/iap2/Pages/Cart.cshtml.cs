using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iap2.Pages
{
    [Authorize(Roles = "AdminManager, Visitor")]
    public class CartModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
