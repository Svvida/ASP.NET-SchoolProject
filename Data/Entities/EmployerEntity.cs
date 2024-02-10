using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Employers")]
    public class EmployerEntity
    {
        [Key]
        [HiddenInput]
        public int EmployerId { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(50)]
        [Required]
        public string CompanyName { get; set; }
        [Required]
        [RegularExpression(@"^\d{10}$")]
        public string NIP { get; set; }
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public AddressEntity Address { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; }
    }
}
