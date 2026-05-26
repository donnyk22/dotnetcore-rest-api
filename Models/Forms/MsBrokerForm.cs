using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms;

public class MsBrokerForm
{
    [Required(ErrorMessage = "Subject is required")]
    public string? Subject { get; set; }

    [Required(ErrorMessage = "message is required")]
    public string? Message { get; set; }
}
