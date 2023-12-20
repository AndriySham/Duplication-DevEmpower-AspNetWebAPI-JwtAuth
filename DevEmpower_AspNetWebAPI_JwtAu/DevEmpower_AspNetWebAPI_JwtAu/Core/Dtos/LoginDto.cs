using System.ComponentModel.DataAnnotations;

namespace DevEmpower_AspNetWebAPI_JwtAu.Core.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "User is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
