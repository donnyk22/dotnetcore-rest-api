using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using dotnetcore_web_api.Models.Enums;

namespace dotnetcore_web_api.Models.Forms.Teachers;

public class TeachersCreateForm
{
    [Required(ErrorMessage = "User ID is required")]
    public int? UserId { get; set; }

    [Required(ErrorMessage = "Full name is required")]
    public string? FullName { get; set; }

    [Required(ErrorMessage = "Gender is required")]
    [Description("Allowable values: M, F")]
    public UserGender? Gender { get; set; }

    [Required(ErrorMessage = "Phone is required")]
    [Description("Example: 081234567890")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "Address is required")]
    public string? Address { get; set; }

    public IFormFile? Photo { get; set; }
}
