namespace dotnetcore_web_api.Models.DTOs;

public class MstStudentsDto
{
    public int? Id { get; set; }
    public int? UserId { get; set; }
    public int? ClassId { get; set; }
    public MstClassesDto? Classroom { get; set; }
    public string? FullName { get; set; }
    public char? Gender { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Photo { get; set; }
    public int? Version { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}
