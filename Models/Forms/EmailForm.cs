using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms;

public class EmailForm : IValidatableObject
{
    public List<string>? Recipients { get; set; }

    [Description("Email subject. Example: Subject")]
    public string? Subject { get; set; }

    [Required(ErrorMessage = "Message is required")]
    [Description("""
        Email message. Example:
        Lorem ipsum dolor sit amet, consectetur adipiscing elit, <br/>
        sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. <br/>
        Ut enim ad minim veniam, <br/>
        quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. <br/>
        Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. <br/>
        Excepteur sint occaecat cupidatat non proident, <br/>
        sunt in culpa qui officia deserunt mollit anim id est laborum.
        """)]
    public string? Message { get; set; }

    // Java's `List<@Email String>` validates each element; DataAnnotations can't
    // express that declaratively, so we do it via IValidatableObject.
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Recipients is null || Recipients.Count < 1)
        {
            yield return new ValidationResult(
                "Must contain at least one recipient",
                new[] { nameof(Recipients) });
            yield break;
        }

        var emailAttr = new EmailAddressAttribute();
        foreach (var recipient in Recipients)
        {
            if (!emailAttr.IsValid(recipient))
            {
                yield return new ValidationResult(
                    "One or more email has invalid format",
                    new[] { nameof(Recipients) });
                yield break;
            }
        }
    }
}
