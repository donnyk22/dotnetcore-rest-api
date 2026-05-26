using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_web_api.Models.Entities;

// auditing (equivalent to Hibernate @Audited / Envers) is not built-in to EF Core;
// integrate via an interceptor or a package such as Audit.NET.EntityFramework.
// Soft delete: apply a global query filter on IsDeleted in your DbContext.
[Table("mst_students")]
public class MstStudents : BaseTimestampCreateUpdate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("class_id")]
    public int? ClassId { get; set; }

    [Column("full_name")]
    public string? FullName { get; set; }

    public char? Gender { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Photo { get; set; }

    // handle versioning (optimistic concurrency)
    [ConcurrencyCheck]
    public int Version { get; set; }

    // soft delete flag
    [Column("is_deleted")]
    public bool IsDeleted { get; set; }

    // ==== Relation ====

    [ForeignKey(nameof(ClassId))]
    public MstClasses? Classroom { get; set; }

    [ForeignKey(nameof(UserId))]
    public MstUsers? User { get; set; }

    public ICollection<MstAttendances> Attendances { get; set; } = new List<MstAttendances>();
}
