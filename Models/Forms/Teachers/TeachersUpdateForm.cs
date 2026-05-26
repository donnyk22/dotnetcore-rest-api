using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms.Teachers;

public class TeachersUpdateForm : TeachersCreateForm
{
    [Required(ErrorMessage = "Version is required")]
    [Description("Example: 1")]
    public int? Version { get; set; }
}
