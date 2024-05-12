using System.ComponentModel.DataAnnotations;

namespace Zadanie7.Models;

public class Trip
{
    [Required] public int IdTrip { get; set; }
    [Required] [MaxLength(120)] public string Name { get; set; }
    [Required] [MaxLength(120)] public string Description { get; set; }
    [Required] public DateTime  DateFrom { get; set; }
    [Required] public DateTime DateTo { get; set; }
    [Required] public int MaxPeople { get; set; }

    public Trip(int idTrip, string name, string description, DateTime dateFrom, DateTime dateTo, int maxPeople)
    {
        IdTrip = idTrip;
        Name = name;
        Description = description;
        DateFrom = dateFrom;
        DateTo = dateTo;
        MaxPeople = maxPeople;
    }
}