using iap2.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace iap2.Pages
{
    public class SingleProductModel : PageModel
    {
        [BindProperty]
        public Product item { get; set; }
        [BindProperty (SupportsGet = true)]
        public int Id { get; set; }
        private readonly AppDataContext _db;
        private readonly UserManager<AppUser> _userManager;

        public SingleProductModel(AppDataContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public void OnGet()
        {
            item = _db.Products.Find(Id);
        }
        public IActionResult OnPost()
        {
            string cartOwner = _userManager.GetUserId(User);
            var itemExists = _db.ShoppingCartItems.SingleOrDefault(c => c.CartId == cartOwner && c.ProductId == Id);
            if (itemExists == null)
            {
                CartItem cartItem = new CartItem()
                {
                    ProductId = Id,
                    CartId = cartOwner,
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };

                _db.ShoppingCartItems.Add(cartItem);
            }
            else
            {
                itemExists.Quantity++;
            }
            _db.SaveChanges();
            return RedirectToPage("Cart");
        }
    }
}
