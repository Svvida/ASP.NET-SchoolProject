using Employee_App.Models.Address;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_App.Models.Employer
{
    public class EmployerModel
    {
        public int EmployerId { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane.")]
        [StringLength(50, ErrorMessage = "Imię nie może być dłuższe niż 50 znaków.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [StringLength(50, ErrorMessage = "Nazwisko nie może być dłuższe niż 50 znaków.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Nazwa firmy jest wymagana.")]
        [StringLength(50, ErrorMessage = "Nazwa firmy nie może być dłuższa niż 50 znaków.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "NIP jest wymagany.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "NIP musi składać się z dokładnie 10 znaków.")]
        public string NIP { get; set; }
        [ForeignKey("Addresses")]
        public AddressModel Address { get; set; }
        [Required(ErrorMessage = "Miasto jest wymagane")]
        public string City { get; set; }

        [Required(ErrorMessage = "Ulica jest wymagana")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Kod pocztowy musi być w formacie XX-XXX")]
        public string PostalCode { get; set; }
    }
}
