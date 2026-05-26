namespace dotnetcore_web_api.Models.DTOs;

public class MstClassesDto
{
    public int? Id { get; set; }
    public string? ClassName { get; set; }
    public int? GradeLevel { get; set; }
    public string? AcademicYear { get; set; }
    public int? Version { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public List<MstHomeroomTeachersDto>? HomeroomTeachers { get; set; }
    public List<MstStudentsDto>? Students { get; set; }
}
