using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_web_api.Models.Entities;

public abstract class BaseTimestampCreateUpdate : BaseTimestampCreate
{
    [Column("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
}
