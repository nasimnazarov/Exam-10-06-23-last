using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Location
{
    [Key]
    public int LocationId { get; set; }
    [Required, MaxLength(100)]
    public string StreetAddress { get; set; }
    [Required, MaxLength(100)]
    public string PostalCode { get; set; }
    [Required, MaxLength(100)]
    public string City { get; set; }
    [Required, MaxLength(100)]
    public string StateProvince { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
}