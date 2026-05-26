using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using dotnetcore_web_api.Models.Enums;

namespace dotnetcore_web_api.Models.Forms.Users;

public class UsersUpdateForm
{
    [Required(ErrorMessage = "Username is required")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Role is required")]
    [Description("Allowable values: ADMIN, STUDENT, TEACHER")]
    public UserRole? Role { get; set; }

    public IFormFile? Photo { get; set; }

    [Required(ErrorMessage = "Active status is required")]
    public bool? IsActive { get; set; }

    [Required(ErrorMessage = "Version is required")]
    [Description("Example: 1")]
    public int? Version { get; set; }
}
