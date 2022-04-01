using iap2.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iap2.Pages
{
    [Authorize (Roles = "AdminManager")]
    public class addProductModel : PageModel
    {
        [BindProperty]
        public Product item { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        private readonly AppDataContext _db;

        public addProductModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            item = _db.Products.Find(Id);
        }
        public IActionResult OnPost()
        {
            _db.Products.Add(item);
            _db.SaveChanges();
            return RedirectToPage("products");
        }
        public IActionResult OnPostUpdate()
        {
            _db.Products.Update(item);
            _db.SaveChanges();
            return RedirectToPage("products");
        }
    }
}
