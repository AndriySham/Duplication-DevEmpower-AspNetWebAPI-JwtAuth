using Microsoft.AspNetCore.Identity;

namespace DevEmpower_AspNetWebAPI_JwtAu.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
