using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models;

public class PersonModel
{
    [ Required, StringLength(10, MinimumLength = 5, ErrorMessage = "Invalid first name length.") ]
    public string? FirstName { get; set; }

    [ Required, StringLength(5, MinimumLength = 2, ErrorMessage = "Invalid first name length.") ]
    public string? LastName { get; set; }

    [ Range(0, 125, ErrorMessage = "You need to enter a valid age.") ]
    public int Age { get; set; }

    [ Required, Range(typeof(bool), "true", "true", ErrorMessage = "You need to give consent to continue.") ]
    public bool ConsentGiven { get; set; }

    public List<AddressModel>? Addresses { get; set; }
}
