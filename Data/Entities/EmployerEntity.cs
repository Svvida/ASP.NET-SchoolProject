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
        [MinLength(10)]
        [MaxLength(10)]
        [Required]
        public string NIP { get; set; }
        public ICollection <EmployeeEntity> Employees { get; set; }

        public ICollection<EmploymentHistoryEntity> Employments { get; set; }

    }
}
