using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms;

public class WebSocketForm
{
    [Required(ErrorMessage = "Subject is required")]
    public string? Subject { get; set; }

    [Required(ErrorMessage = "Content is required")]
    public string? Content { get; set; }

    public WebSocketForm() { }

    public WebSocketForm(string? subject, string? content)
    {
        Subject = subject;
        Content = content;
    }
}
