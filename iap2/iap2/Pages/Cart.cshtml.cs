using iap2.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace iap2.Pages
{
    [Authorize(Roles = "AdminManager, Visitor")]
    public class CartModel : PageModel
    {
        public IEnumerable<CartItem> cartItemsList { get; set; }
        private readonly AppDataContext _db;
        private readonly UserManager<AppUser> _userManager;

        public CartModel(AppDataContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public void OnGet()
        {
            string d = _userManager.GetUserId(User);
            cartItemsList = _db.ShoppingCartItems.Where(c => c.CartId == d).ToList();
        }
    }
}
