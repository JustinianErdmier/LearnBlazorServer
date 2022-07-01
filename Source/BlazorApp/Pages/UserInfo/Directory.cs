using BlazorApp.Models;

namespace BlazorApp.Pages.UserInfo;

public partial class Directory
{
    public List<PersonModel> People { get; set; }

    public Directory() => People = new List<PersonModel>
                                   {
                                       new PersonModel
                                       {
                                           FirstName = "Tim",
                                           LastName  = "Corey",
                                           Addresses = new List<AddressModel>
                                                       {
                                                           new AddressModel
                                                           {
                                                               Type   = "Home",
                                                               Street = "123 Oak Street",
                                                               City   = "Scranton",
                                                               State  = "PA",
                                                               Zip    = "18512"
                                                           },
                                                           new AddressModel
                                                           {
                                                               Type   = "Vacation Home",
                                                               Street = "101 Beachfront Ave",
                                                               City   = "Miami",
                                                               State  = "FL",
                                                               Zip    = "12562"
                                                           }
                                                       }
                                       },
                                       new PersonModel
                                       {
                                           FirstName = "Sue",
                                           LastName  = "Storm",
                                           Addresses = new List<AddressModel>
                                                       {
                                                           new AddressModel
                                                           {
                                                               Type   = "Home",
                                                               Street = "115 Justice Way",
                                                               City   = "LA",
                                                               State  = "CA",
                                                               Zip    = "88547"
                                                           }
                                                       }
                                       },
                                       new PersonModel { FirstName = "Bob", LastName = "Smith" }
                                   };
}
