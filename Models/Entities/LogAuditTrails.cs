using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_web_api.Models.Entities;

[Table("log_audit_trails")]
public class LogAuditTrails : BaseTimestampCreate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    public string? Method { get; set; }

    [Column("table")] // handle reserved keyword
    public string? Table { get; set; }

    public string? Details { get; set; }

    [Column("data_id")]
    public int? DataId { get; set; }

    [Column(TypeName = "TEXT")]
    public string? Properties { get; set; }

    // ==== Relation ====

    [ForeignKey(nameof(UserId))]
    public MstUsers? UserData { get; set; }
}
