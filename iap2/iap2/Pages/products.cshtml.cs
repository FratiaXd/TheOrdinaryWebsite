using iap2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iap2.Pages
{
    public class productsModel : PageModel
    {
        [BindProperty]
        public string searchString { get; set; }
        [BindProperty (SupportsGet = true)]
        public string category { get; set; }
        public IEnumerable<Product> itemsList { get; set; }
        public List<Product> products { get; set; }
        public IEnumerable<string> ProdCategories { get; set; }

        [BindProperty (SupportsGet = true)]
        public int Id { get; set; }
        public Product Recommen1 { get; set; }

        public Product Recommen2 { get; set; }

        private readonly AppDataContext _db;

        static Random rnd = new Random();
        public productsModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            itemsList = _db.Products.ToList();
            products = _db.Products.ToList();
            int r = rnd.Next(products.Count);
            if (r == products.Count-1)
            {
                Recommen1 = products[r];
                Recommen2 = products[r-1];
            }
            else
            {
                Recommen1 = products[r];
                Recommen2 = products[r+1];
            }           
            ProdCategories = _db.Products.Select(p => p.Category).Distinct();
        }
        public void OnPost()
        {
            ProdCategories = _db.Products.Select(p => p.Category).Distinct();
            itemsList = _db.Products.Where(p => p.Description.Contains(searchString));
        }
        public void OnPostCategory()
        {
            ProdCategories = _db.Products.Select(p => p.Category).Distinct();
            string ctg = Request.Form["categSearch"];
            itemsList = _db.Products.Where(p => p.Category.Contains(ctg));
        }
        public IActionResult OnGetDelete()
        {
            _db.Remove(_db.Products.Find(Id));
            _db.SaveChanges();
            return RedirectToPage("products");
        }
    }
}
