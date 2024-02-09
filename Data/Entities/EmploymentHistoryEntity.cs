using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("EmploymentHistory")]
    public class EmploymentHistoryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public EmployeeEntity Employee { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        [Required]
        public int EmployerId { get; set; }
        [ForeignKey("EmployerId")]
        public EmployerEntity Employer { get; set; }

    }
}
