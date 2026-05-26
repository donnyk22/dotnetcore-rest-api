using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using dotnetcore_web_api.Models.Enums;

namespace dotnetcore_web_api.Models.Forms.Students;

public class StudentsCreateForm
{
    [Required(ErrorMessage = "User ID is required")]
    public int? UserId { get; set; }

    [Required(ErrorMessage = "Class ID is required")]
    public int? ClassId { get; set; }

    [Required(ErrorMessage = "Full name is required")]
    public string? FullName { get; set; }

    [Required(ErrorMessage = "Gender is required")]
    [Description("Allowable values: M, F")]
    public UserGender? Gender { get; set; }

    [Required(ErrorMessage = "Address is required")]
    public string? Address { get; set; }

    [Description("Example: 081234567890")]
    public string? Phone { get; set; }

    // MultipartFile -> IFormFile (Microsoft.AspNetCore.Http, available via implicit usings).
    // Bind with [FromForm] on the controller action when consuming multipart/form-data.
    public IFormFile? Photo { get; set; }
}
