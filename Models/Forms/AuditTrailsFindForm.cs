using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms;

public class AuditTrailsFindForm : SearchForm
{
    public int? UserId { get; set; }

    public int? DataId { get; set; }

    [Description("Allowable values: mst_attendances, mst_classes, mst_homeroom_teachers, mst_students, mst_teachers, mst_users")]
    public string? Table { get; set; }

    [Description("Allowable values: POST, PUT, PATCH, DELETE")]
    public string? Method { get; set; }

    // DateTimeOffset parses ISO-8601 with offset natively (e.g. "2026-03-08T09:00:00+07:00").
    [Required(ErrorMessage = "Start Date is required")]
    [Description("Start Date with Timezone. Example: 2026-03-08T09:00:00+07:00")]
    public DateTimeOffset? StartDateTime { get; set; }

    [Required(ErrorMessage = "End Date is required")]
    [Description("End Date with Timezone. Example: 2026-03-08T18:00:00+07:00")]
    public DateTimeOffset? EndDateTime { get; set; }
}
