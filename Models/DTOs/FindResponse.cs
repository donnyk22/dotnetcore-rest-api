namespace dotnetcore_web_api.Models.DTOs;

public class FindResponse<T>
{
    public List<T>? Records { get; set; }
    public int? TotalPage { get; set; }
    public int? TotalItem { get; set; }
    public bool? HasNext { get; set; }
    public bool? HasPrev { get; set; }
}
