using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms.Classes;

public class ClassesUpdateForm : ClassesCreateForm
{
    [Required(ErrorMessage = "Version is required")]
    [Description("Example: 1")]
    public int? Version { get; set; }
}
