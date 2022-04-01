using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace iap2.Pages
{
    public class AdminDashModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public List<IdentityRole> roles { get; set; }

        public AdminDashModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public void OnGet()
        {
            roles = _roleManager.Roles.ToList();
        }
    }
}
