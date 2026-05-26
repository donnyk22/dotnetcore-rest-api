namespace dotnetcore_web_api.Models.DTOs;

public class MstHomeroomTeachersDto
{
    public int? Id { get; set; }
    public int? ClassId { get; set; }
    public MstClassesDto? Classroom { get; set; }
    public int? TeacherId { get; set; }
    public MstTeachersDto? Teacher { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
}
