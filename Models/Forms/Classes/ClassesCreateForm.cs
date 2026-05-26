using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms.Classes;

public class ClassesCreateForm
{
    [Required(ErrorMessage = "Class name is required")]
    [Description("Example: 10-IPA-1")]
    public string? ClassName { get; set; }

    [Required(ErrorMessage = "Grade level is required")]
    [Description("Example: 10")]
    public int? GradeLevel { get; set; }

    [Required(ErrorMessage = "Academic year is required")]
    [Description("Academic Year (YYYY/YYYY). Example: 2025/2026")]
    public string? AcademicYear { get; set; }
}
