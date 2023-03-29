using Microsoft.AspNetCore.Identity;

namespace Portfolio_WebApp.Areas.AppUsers
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
