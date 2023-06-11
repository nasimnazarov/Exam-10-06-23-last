using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Country
{
    [Key]
    public int CountryId { get; set; }
    [Required, MaxLength(100)]
    public String CountryName { get; set; }
    public int RegionId { get; set; }
    public Region Region { get; set; }
}