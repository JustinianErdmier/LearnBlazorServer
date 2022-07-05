using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models;

public class MilkshakeOrderModel
{
    [ Required, MinLength(1, ErrorMessage = "You need to select a type of milkshake.") ]
    public string? Type { get; set; }

    [ Required, MinLength(1, ErrorMessage = "You need to select a milkshake size.") ]
    public string? Size { get; set; }

    [ Required, MinLength(2, ErrorMessage = "A name for this order is required.") ]
    public string? Name { get; set; }

    [Range(1, 10, ErrorMessage = "Please order a quantity between 1 and 10.")]
    public int Quantity { get; set; }

    public bool AddWhippedCream { get; set; }
}
