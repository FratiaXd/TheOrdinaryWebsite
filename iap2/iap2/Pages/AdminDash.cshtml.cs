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
        private readonly UserManager<AppUser> _userManager;
        public List<IdentityRole> roles { get; set; }
        public List<AppUser> users { get; set;}
        public List<UserRolesViewModel> rolesViewModel { get; set; }
        public List<UserRolesViewModel> userRolesViewModel { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public string passwordString { get; set; }
        [BindProperty]
        public string roleName { get; set; }
        public AdminDashModel(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            roles = await _roleManager.Roles.ToListAsync();
            users = await _userManager.Users.ToListAsync();
            userRolesViewModel = new List<UserRolesViewModel>();
            foreach (AppUser user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.Id = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesViewModel.Add(thisViewModel);
            }
            return Page();
        }
        public async Task<IActionResult> OnGetDelete()
        {
            var role = await _roleManager.FindByIdAsync(Id);
            var user = await _userManager.FindByIdAsync(Id);
            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
            else if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
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
        public async Task<IActionResult> OnPostUpdateAsync()
        {
            var users = await _userManager.FindByIdAsync(Id);
            await _userManager.RemovePasswordAsync(users);
            await _userManager.AddPasswordAsync(users, passwordString);
            return RedirectToPage("AdminDash");
        }

        private async Task<List<string>> GetUserRoles(AppUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }
    }
}

//var a = await _userManager.GetRolesAsync(user);