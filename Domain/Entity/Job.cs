using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Job
{
    [Key]
    public int JobId { get; set; }
    [Required, MaxLength(50)]
    public string JobTitle { get; set; }
    public int MinSalary { get; set; }
    public int MaxSalary { get; set; }
}