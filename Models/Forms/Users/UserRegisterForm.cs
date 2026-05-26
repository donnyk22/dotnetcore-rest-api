using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using dotnetcore_web_api.Models.Enums;

namespace dotnetcore_web_api.Models.Forms.Users;

public class UserRegisterForm
{
    [Required(ErrorMessage = "Username is required")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Role is required")]
    [Description("Allowable values: ADMIN, STUDENT, TEACHER")]
    public UserRole? Role { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    [Description("Password must be at least 8 characters")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Please retype you password")]
    [Description("Please retype you password")]
    public string? RePassword { get; set; }
}
