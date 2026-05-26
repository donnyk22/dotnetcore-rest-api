using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms.Users;

public class UsersCreateForm : UsersUpdateForm
{
    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    [Description("Password must be at least 8 characters")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Please retype you password")]
    [Description("Please retype you password")]
    public string? RePassword { get; set; }
}
