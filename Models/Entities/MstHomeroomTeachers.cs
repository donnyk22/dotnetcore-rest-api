using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_web_api.Models.Entities;

// auditing (equivalent to Hibernate @Audited / Envers) is not built-in to EF Core;
// integrate via an interceptor or a package such as Audit.NET.EntityFramework.
[Table("mst_homeroom_teachers")]
public class MstHomeroomTeachers : BaseTimestampCreate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("class_id")]
    public int? ClassId { get; set; }

    [Column("teacher_id")]
    public int? TeacherId { get; set; }

    // ==== Relation ====

    [ForeignKey(nameof(ClassId))]
    public MstClasses? ClassData { get; set; }

    [ForeignKey(nameof(TeacherId))]
    public MstTeachers? TeacherData { get; set; }
}
