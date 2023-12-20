using System.ComponentModel.DataAnnotations;

namespace DevEmpower_AspNetWebAPI_JwtAu.Core.Dtos
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "User is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
