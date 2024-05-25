using System.ComponentModel.DataAnnotations;

namespace Zadanie7.Models;

public partial class Client
{
    [Required]public int IdClient { get; set; }

    [Required][MaxLength(120)]public string FirstName { get; set; } = null!;

    [Required][MaxLength(120)]public string LastName { get; set; } = null!;

    [Required][MaxLength(120)]public string Email { get; set; } = null!;

    [Required][MaxLength(120)]public string Telephone { get; set; } = null!;

    [Required][MaxLength(120)]public string Pesel { get; set; } = null!;

    public virtual ICollection<ClientTrip> ClientTrips { get; set; } = new List<ClientTrip>();

    public Client(string firstName, string lastName, string email, string telephone, string pesel)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Telephone = telephone;
        Pesel = pesel;
    }
}