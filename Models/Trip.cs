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

    public virtual ICollection<ClientTrip> ClientTrips { get; set; } = new List<ClientTrip>();
    public virtual ICollection<Country> IdCountries { get; set; } = new List<Country>();
}