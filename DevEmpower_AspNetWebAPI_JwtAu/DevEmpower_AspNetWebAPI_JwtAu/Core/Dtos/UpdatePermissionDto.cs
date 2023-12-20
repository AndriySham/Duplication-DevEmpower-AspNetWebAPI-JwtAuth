using System.ComponentModel.DataAnnotations;

namespace DevEmpower_AspNetWebAPI_JwtAu.Core.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "User is required")]
        public string UserName { get; set; }
    }
}
