using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Employee_App.Models.Address
{
    public class AddressModel
    {
        [Required]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane")]
        public string City { get; set; }

        [Required(ErrorMessage = "Ulica jest wymagana")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Kod pocztowy musi być w formacie XX-XXX")]
        public string PostalCode { get; set; }
    }
}
