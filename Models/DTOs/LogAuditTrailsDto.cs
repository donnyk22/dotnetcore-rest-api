namespace dotnetcore_web_api.Models.DTOs;

public class LogAuditTrailsDto
{
    public int? Id { get; set; }
    public MstUsersDto? User { get; set; }
    public string? Action { get; set; }
    public string? Table { get; set; }
    public string? Details { get; set; }
    public int? DataId { get; set; }
    public string? Properties { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
}
