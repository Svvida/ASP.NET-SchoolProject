using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Data.Entities
{
    [Table("Employees")]
    public class EmployeeEntity
    {
        [Key]
        [HiddenInput]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(11)]
        [MinLength(11)]
        [Required]
        public string PESEL { get; set; }

        [MaxLength(50)]
        public string Position { get; set; }

        [MaxLength(50)]
        public string Department { get; set; }

        [Column("employment_date")]
        public DateTime EmploymentDate { get; set; }

        [Column("termination_date")]
        public DateTime? TerminationDate { get; set; } // Nullable, ponieważ data zwolnienia może nie być znana
        [HiddenInput]
        public int? EmployerId { get; set; }
        [ForeignKey("EmployerId")]
        public EmployerEntity? Employer { get; set; }
        public ICollection<EmploymentHistoryEntity> EmploymentHistory { get; set; }
    }
}
