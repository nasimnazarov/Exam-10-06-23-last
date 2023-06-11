using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Department
{
    public int DepartmentId { get; set; }
    [Required, MaxLength(100)]
    public string Departmentname { get; set; }
    public int ManagerId { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
}