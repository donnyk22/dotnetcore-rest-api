using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_web_api.Models.Entities;

// auditing (equivalent to Hibernate @Audited / Envers) is not built-in to EF Core;
// integrate via an interceptor or a package such as Audit.NET.EntityFramework.
// Soft delete: apply a global query filter on IsDeleted in your DbContext.
[Table("mst_users")]
public class MstUsers : BaseTimestampCreateUpdate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }

    [Column(TypeName = "TEXT")]
    public string? Photo { get; set; }

    public string? Role { get; set; }

    [Column("mfa_enabled")]
    public bool? MfaEnabled { get; set; }

    [Column("mfa_secret")]
    public string? MfaSecret { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; } = true;

    // handle versioning (optimistic concurrency)
    [ConcurrencyCheck]
    public int Version { get; set; }

    // soft delete flag
    [Column("is_deleted")]
    public bool IsDeleted { get; set; }

    // ==== Relation ====

    public MstStudents? StudentData { get; set; }

    public MstTeachers? TeacherData { get; set; }

    public ICollection<LogAuditTrails> AuditTrailsData { get; set; } = new List<LogAuditTrails>();
}
