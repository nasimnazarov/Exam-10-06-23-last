using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Employee
{
    public int EmployeeId { get; set; }
    [Required, MaxLength(100)]
    public string FirstName { get; set; }
    [Required, MaxLength(100)]
    public string LastName { get; set; }
    [Required, MaxLength(50)]
    public string Email { get; set; }
    [Required, MaxLength(50)]
    public string PhoneNumber { get; set; }
    [Required, MaxLength(100)]
    public DateTime HireDate { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
    public int Salary { get; set; }
    public int ComissionPct { get; set; }
    public int ManagerId { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}