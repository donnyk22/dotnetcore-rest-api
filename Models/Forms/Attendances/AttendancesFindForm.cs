using System.ComponentModel;

namespace dotnetcore_web_api.Models.Forms.Attendances;

public class AttendancesFindForm : SearchForm
{
    [Description("Academic Year (YYYY/YYYY). Example: 2025/2026")]
    public string? AcademicYear { get; set; }

    // For Query Param (GET). DateOnly binds from ISO yyyy-MM-dd query strings natively.
    [Description("Start date for filtering (YYYY-MM-DD). Example: 2026-01-21")]
    public DateOnly? StartRangeDate { get; set; }

    [Description("End date for filtering (YYYY-MM-DD). Example: 2026-01-31")]
    public DateOnly? EndRangeDate { get; set; }
}
