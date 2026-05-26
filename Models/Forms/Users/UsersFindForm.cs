using System.ComponentModel;

namespace dotnetcore_web_api.Models.Forms.Users;

public class UsersFindForm : SearchForm
{
    [Description("Allowable values: ADMIN, STUDENT, TEACHER")]
    public string? Role { get; set; }

    public bool? IsActive { get; set; }
}
