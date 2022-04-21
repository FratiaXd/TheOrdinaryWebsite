using iap2.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iap2.Pages
{
    public class ManageModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        public ManageModel(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [BindProperty(SupportsGet = true)]       
        public string Id { get; set; }
        [BindProperty (SupportsGet = true)]
        public bool Selected { get; set; }
        public AppUser Indicate { get; set; }
        public List<ManageUserRolesViewModel> model { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            Indicate = await _userManager.FindByIdAsync(Id);
            model = new List<ManageUserRolesViewModel>();
            foreach (var role in _roleManager.Roles.ToList())
            {
                var userRolesViewModel = new ManageUserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                if (await _userManager.IsInRoleAsync(Indicate, role.Name))
                {
                    userRolesViewModel.Selected = true;
                }
                else
                {
                    userRolesViewModel.Selected = false;
                }
                model.Add(userRolesViewModel);
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null)
            {
                return Page();
            }
            var roles = await _userManager.GetRolesAsync(user);
            if (roles == null)
            {
                return Page();
            }
            /*
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return Page();
            }
            var new_roles1 = model.Where(s => s.Selected == true);
            var new_roles2 = new_roles1.Select(y => y.RoleName);
            result = await _userManager.AddToRolesAsync(user, new_roles2);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return Page();
            }*/
            return RedirectToPage("AdminDash");
        }
    }
}
