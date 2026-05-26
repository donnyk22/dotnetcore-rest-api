namespace dotnetcore_web_api.Models.DTOs;

public class WebSocketUserSessionDto
{
    public int? Count { get; set; }
    public List<WebSocketUserSessionDetailDto>? Detail { get; set; }
}
