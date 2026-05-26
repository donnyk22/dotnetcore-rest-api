namespace dotnetcore_web_api.Models.DTOs
{
    public class ApiResponse<T>(int status, string message, T? data)
    {
        public int Status { get; set; } = status;
        public string Message { get; set; } = message;
        public T? Data { get; set; } = data;
        public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.UtcNow;
    }
}