using Domain.Entity;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class DepartmentService
{
    private readonly DataContext _context;

    public DepartmentService(DataContext context)
    {
        _context = context;
    }
    //GetList of Department
    public async Task<List<Department>> GetDepartmentsAsync()
    {
        return await _context.Departments.ToListAsync();
    }
    //Get by Id
    public async Task<Department> GetDepartmentById(int id)
    {
        return await _context.Departments.FindAsync(id);
    }
    //Add
    public async Task<Department> AddDepartmentAsync(Department department)
    {
        await _context.Departments.AddAsync(department);
        await _context.SaveChangesAsync();
        return department;
    }
    //Update
    public async Task<Department> UpdateDepartmentAsync(Department department)
    {
        var find = await _context.Departments.FindAsync(department.DepartmentId);
        find.Departmentname = department.Departmentname;
        find.LocationId = department.LocationId;
        find.ManagerId = department.ManagerId;
        await _context.SaveChangesAsync();
        return department;
    }

    public async Task<bool> DeleteDepartment(int id)
    {
        var find = await _context.Departments.FindAsync(id);
        _context.Departments.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }

}