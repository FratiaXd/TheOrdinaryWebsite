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
        [BindProperty (SupportsGet = true)]
        public int Id { get; set; }
        public IEnumerable<CartItem> cartItemsList { get; set; }
        private readonly AppDataContext _db;
        private readonly UserManager<AppUser> _userManager;
        public double totalForProduct { get; set; }
        public double total { get; set; }

        public CartModel(AppDataContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public void OnGet()
        {
            string d = _userManager.GetUserId(User);
            cartItemsList = _db.ShoppingCartItems.Where(c => c.CartId == d).ToList();
            foreach (var item in cartItemsList)
            {
                item.Products = _db.Products.Find(item.ProductId);
                totalForProduct = item.Quantity * item.Products.Price;
                total += totalForProduct;
            }

        }
        public IActionResult OnGetDelete()
        {
            var it = _db.ShoppingCartItems.Find(Id);
            if (it.Quantity > 1)
            {
                it.Quantity--;
            }
            else
            {
                _db.Remove(_db.ShoppingCartItems.Find(Id));
            }
            _db.SaveChanges();
            return RedirectToPage("Cart");
        }
        public IActionResult OnGetAdd()
        {
            var it = _db.ShoppingCartItems.Find(Id);
            it.Quantity++;
            _db.SaveChanges();
            return RedirectToPage("Cart");
        }
    }
}
