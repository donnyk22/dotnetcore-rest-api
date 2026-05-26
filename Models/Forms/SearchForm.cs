using System.ComponentModel;

namespace dotnetcore_web_api.Models.Forms;

public class SearchForm
{
    [DefaultValue("")]
    public string Keyword { get; set; } = "";

    [DefaultValue(0)]
    public int Page { get; set; } = 0;

    [DefaultValue(10)]
    public int Size { get; set; } = 10;
}
