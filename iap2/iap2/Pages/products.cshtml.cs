using iap2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace iap2.Pages
{
    public class productsModel : PageModel
    {
        public List<Product> itemsList { get; set; }

        private readonly AppDataContext _db;

        public productsModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            itemsList = _db.Products.ToList();
        }
    }
}
