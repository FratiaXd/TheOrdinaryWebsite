using iap2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iap2.Pages
{
    public class addProductModel : PageModel
    {
        [BindProperty]
        public Product item { get; set; }

        private readonly AppDataContext _db;

        public addProductModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Products.Add(item);
            _db.SaveChanges();
            return RedirectToPage("products");
        }
    }
}
