using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Addresses")]
    public class AddressEntity
    {
        [Key]
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
