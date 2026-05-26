using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms.Users;

public class UserLoginForm
{
    [Required(ErrorMessage = "Username/Email is required")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; set; }
}
