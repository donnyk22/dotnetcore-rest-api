using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms.HomeroomTeachers;

public class HomeroomTeachersCreateForm
{
    [Required(ErrorMessage = "Class ID is required")]
    public int? ClassId { get; set; }

    [Required(ErrorMessage = "Teacher ID is required")]
    public int? TeacherId { get; set; }
}
