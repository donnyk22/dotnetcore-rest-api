namespace dotnetcore_web_api.Models.DTOs;

public class WebSocketUserSessionDetailDto
{
    public string? UserId { get; set; }
    public HashSet<string>? Sessions { get; set; }

    public WebSocketUserSessionDetailDto() { }

    public WebSocketUserSessionDetailDto(string? userId, HashSet<string>? sessions)
    {
        UserId = userId;
        Sessions = sessions;
    }
}
