using System.ComponentModel;

namespace dotnetcore_web_api.Models.Forms.Students;

public class StudentsFindForm : SearchForm
{
    [Description("Academic Year (YYYY/YYYY). Example: 2025/2026")]
    public string? AcademicYear { get; set; }
}
