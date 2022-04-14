using iap2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace iap2.Pages
{
    public class productsModel : PageModel
    {
        [BindProperty]
        public string searchString { get; set; }
        [BindProperty]
        public string searchCategory { get; set; }
        public IEnumerable<Product> itemsList { get; set; }
        public IEnumerable<string> ProdCategories { get; set; }

        [BindProperty (SupportsGet = true)]
        public int Id { get; set; }

        private readonly AppDataContext _db;

        public productsModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            itemsList = _db.Products.ToList();
            ProdCategories = _db.Products.Select(p => p.Category).Distinct();
        }
        public void OnPost()
        {
            itemsList = _db.Products.Where(p => p.Description.Contains(searchString));
        }
        public void OnPostCategory()
        {
            itemsList = _db.Products.Where(p => p.Category.Equals(searchCategory));
        }
        public IActionResult OnGetDelete()
        {
            _db.Remove(_db.Products.Find(Id));
            _db.SaveChanges();
            return RedirectToPage("products");
        }
    }
}
