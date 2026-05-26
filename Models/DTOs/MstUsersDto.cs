namespace dotnetcore_web_api.Models.DTOs;

public class MstUsersDto
{
    public int? Id { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Photo { get; set; }
    public string? Name { get; set; }
    public string? Role { get; set; }
    public bool? MfaEnabled { get; set; }
    public MstStudentsDto? Student { get; set; }
    public MstTeachersDto? Teacher { get; set; }
    public int? Version { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? Token { get; set; }
    public DateTimeOffset? IssuedAt { get; set; }
    public DateTimeOffset? ExpiresAt { get; set; }
}
