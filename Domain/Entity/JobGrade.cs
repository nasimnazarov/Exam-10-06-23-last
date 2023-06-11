using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class JobGrade
{
    [Key]
    public int GradeLevel { get; set; }
    public int LowestSal { get; set; }
    public int HighestSal { get; set; }
}