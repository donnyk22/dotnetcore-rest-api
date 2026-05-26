using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms;

public class ApplicationLetterForm
{
    [Required(ErrorMessage = "Applicant name is required")]
    [DefaultValue("John Doe")]
    [Description("Example: John Doe")]
    public string? ApplicantName { get; set; }

    [Required(ErrorMessage = "Applicant address is required")]
    [DefaultValue("Jakarta, Indonesia")]
    [Description("Example: Jakarta, Indonesia")]
    public string? ApplicantAddress { get; set; }

    [Required(ErrorMessage = "Applicant phone is required")]
    [DefaultValue("+628123456789")]
    [Description("Example: +628123456789")]
    public string? ApplicantPhone { get; set; }

    [Required(ErrorMessage = "Applicant email is required")]
    [DefaultValue("johndoe@gmail.com")]
    [Description("Example: johndoe@gmail.com")]
    public string? ApplicantEmail { get; set; }

    [Required(ErrorMessage = "Recipient name is required")]
    [DefaultValue("Hiring Manager")]
    [Description("Example: Hiring Manager")]
    public string? RecipientName { get; set; }

    [Required(ErrorMessage = "Recipient title is required")]
    [DefaultValue("Human Resources Manager")]
    [Description("Example: Human Resources Manager")]
    public string? RecipientTitle { get; set; }

    [Required(ErrorMessage = "Company name is required")]
    [DefaultValue("PT Gudang Garam Tbk")]
    [Description("Example: PT Gudang Garam Tbk")]
    public string? RecipientCompany { get; set; }

    [Required(ErrorMessage = "Source media is required")]
    [DefaultValue("LinkedIn")]
    [Description("Example: LinkedIn")]
    public string? SourceMedia { get; set; }

    [Required(ErrorMessage = "Target position is required")]
    [DefaultValue("Software Engineer")]
    [Description("Example: Software Engineer")]
    public string? TargetPosition { get; set; }
}
