using Domain.Entity;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class CountryService
{
    private readonly DataContext _context;

    public CountryService(DataContext context)
    {
        _context = context;
    }

    //Get the country
    public async Task<List<Country>> GetCountryListAsync()
    {
        return await _context.Countries.ToListAsync();
    }
    //AddCountry
    public async Task<Country> AddCountryAsync(Country country)
    {
        await _context.Countries.AddAsync(country);
        await _context.SaveChangesAsync();
        return country;
    }
    //Update
    public async Task<Country> UpdateCountryAsync(Country country)
    {
        var find = await _context.Countries.FindAsync(country.CountryId);
        find.CountryName = country.CountryName;
        find.RegionId = country.RegionId;
        await _context.SaveChangesAsync();
        return country;
    }
    //Delete
    public async Task<bool> DeleteCountryAsync(int id)
    {
        var find = await _context.Countries.FindAsync(id);
        _context.Countries.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }



}
