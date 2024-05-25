using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zadanie7.Models;

public partial class Country
{
    [Required]public int IdCountry { get; set; }

    [Required][MaxLength(120)]public string Name { get; set; } 

    public virtual ICollection<Trip> IdTrips { get; set; } = new List<Trip>();
}