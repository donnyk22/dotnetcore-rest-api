namespace dotnetcore_web_api.Models.DTOs;

public class MstAttendancesDto
{
    public int? Id { get; set; }
    public int? StudentId { get; set; }
    public MstStudentsDto? Student { get; set; }
    public DateOnly? Date { get; set; }
    public string? Status { get; set; }
    public string? Note { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
}
