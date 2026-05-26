using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using dotnetcore_web_api.Models.Enums;

namespace dotnetcore_web_api.Models.Forms.Attendances;

public class AttendancesCreateForm
{
    [Required(ErrorMessage = "Student ID is required")]
    public int? StudentId { get; set; }

    // For Json body (POST). DateOnly serializes/binds as ISO yyyy-MM-dd by default.
    [Required(ErrorMessage = "Date is required")]
    [Description("Date of attendance (YYYY-MM-DD). Example: 2026-01-21")]
    public DateOnly? Date { get; set; }

    [Required(ErrorMessage = "Status is required")]
    [Description("Allowable values: PRESENT, ABSENT, LATE, SICK, PERMIT")]
    public StudentAttendanceStatus? Status { get; set; }

    public string? Note { get; set; }
}
