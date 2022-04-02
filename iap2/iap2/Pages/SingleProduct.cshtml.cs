using iap2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iap2.Pages
{
    public class SingleProductModel : PageModel
    {
        [BindProperty]
        public Product item { get; set; }
        [BindProperty (SupportsGet = true)]
        public int Id { get; set; }
        private readonly AppDataContext _db;

        public SingleProductModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            item = _db.Products.Find(Id);
        }
    }
}
