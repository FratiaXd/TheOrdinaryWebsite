using Microsoft.AspNetCore.Identity;

namespace iap2.Model
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    

    }
}
