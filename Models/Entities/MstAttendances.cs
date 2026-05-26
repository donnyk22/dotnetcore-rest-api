using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_web_api.Models.Entities;

// auditing (equivalent to Hibernate @Audited / Envers) is not built-in to EF Core;
// integrate via an interceptor or a package such as Audit.NET.EntityFramework.
[Table("mst_attendances")]
public class MstAttendances : BaseTimestampCreate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("student_id")]
    public int? StudentId { get; set; }

    public DateOnly Date { get; set; }
    public string? Status { get; set; }
    public string? Note { get; set; }

    // ==== Relation ====

    [ForeignKey(nameof(StudentId))]
    public MstStudents? StudentData { get; set; }
}
