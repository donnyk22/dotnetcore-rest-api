using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_web_api.Models.Entities;

// auditing (equivalent to Hibernate @Audited / Envers) is not built-in to EF Core;
// integrate via an interceptor or a package such as Audit.NET.EntityFramework.
// Soft delete: apply a global query filter on IsDeleted in your DbContext.
[Table("mst_classes")]
public class MstClasses : BaseTimestampCreateUpdate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("class_name")]
    public string? ClassName { get; set; }

    [Column("grade_level")]
    public int? GradeLevel { get; set; }

    [Column("academic_year")]
    public string? AcademicYear { get; set; }

    // handle versioning (optimistic concurrency)
    [ConcurrencyCheck]
    public int Version { get; set; }

    // soft delete flag
    [Column("is_deleted")]
    public bool IsDeleted { get; set; }

    // ==== Relation ====

    public ICollection<MstHomeroomTeachers> HomeroomTeachers { get; set; } = new List<MstHomeroomTeachers>();

    // ordering (@OrderBy("id ASC")) should be applied at query time or via fluent configuration.
    public ICollection<MstStudents> Students { get; set; } = new List<MstStudents>();
}
