using System.ComponentModel.DataAnnotations;

namespace dotnetcore_web_api.Models.Forms;

public class WebSocketUsersForm : WebSocketForm
{
    [Required(ErrorMessage = "User IDs must not be null")]
    [MinLength(1, ErrorMessage = "User IDs must contain at least one user")]
    public List<int>? UserIds { get; set; }

    public WebSocketUsersForm() { }

    public WebSocketUsersForm(string? subject, string? content, List<int>? userIds)
        : base(subject, content)
    {
        UserIds = userIds;
    }

    // @EqualsAndHashCode(callSuper = true): include base fields (Subject, Content)
    // alongside UserIds in value equality.
    public override bool Equals(object? obj)
    {
        if (obj is not WebSocketUsersForm other) return false;
        if (Subject != other.Subject) return false;
        if (Content != other.Content) return false;
        if (ReferenceEquals(UserIds, other.UserIds)) return true;
        if (UserIds is null || other.UserIds is null) return false;
        return UserIds.SequenceEqual(other.UserIds);
    }

    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(Subject);
        hash.Add(Content);
        if (UserIds is not null)
        {
            foreach (var id in UserIds) hash.Add(id);
        }
        return hash.ToHashCode();
    }
}
