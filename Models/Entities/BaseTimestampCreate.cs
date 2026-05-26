using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_web_api.Models.Entities;

public abstract class BaseTimestampCreate
{
    [Column("created_at")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
