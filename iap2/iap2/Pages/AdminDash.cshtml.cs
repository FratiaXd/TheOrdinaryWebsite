using iap2.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iap2.Pages
{
    public class AdminDashModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public List<IdentityRole> roles { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public string roleName { get; set; }

        public AdminDashModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            roles = await _roleManager.Roles.ToListAsync();
            return Page();
        }
        public async Task<IActionResult> OnGetDelete()
        {
            var role = await _roleManager.FindByIdAsync(Id);
            var result = await _roleManager.DeleteAsync(role);
            return RedirectToPage("AdminDash");
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (roleName != null)
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
            }
            else
            {
                ModelState.AddModelError("", "No role specified");
            }
            return RedirectToPage("AdminDash");
        }
    }
}
