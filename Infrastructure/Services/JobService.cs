using Domain.Entity;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class JobService
{
    private readonly DataContext _context;

    public JobService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Job>> GetJobAsync()
    {
        return await _context.Jobs.ToListAsync();
    }
    //Get by id
    public async Task<Job> GetJobAsync(int id)
    {
        return await _context.Jobs.FindAsync(id);
    }
    //Add
    public async Task<Job> AddJobAsync(Job job)
    {
        await _context.Jobs.AddAsync(job);
        await _context.SaveChangesAsync();
        return job;
    }
    //Update
    public async Task<Job> UpdateJobAsync(Job job)
    {
        var find = await _context.Jobs.FindAsync(job.JobId);
        find.JobTitle = job.JobTitle;
        find.MinSalary = job.MinSalary;
        find.MaxSalary = job.MaxSalary;
        await _context.SaveChangesAsync();
        return job; 
    }

    public async Task<bool> DeleteJob(int id)
    {
        var find = await _context.Jobs.FindAsync(id);
        _context.Jobs.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }

}