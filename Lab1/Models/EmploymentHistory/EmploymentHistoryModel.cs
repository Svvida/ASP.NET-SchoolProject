using Employee_App.Models.Employee;
using Employee_App.Models.Employer;
using Employee_App.Models.EmploymentHistory;
using System;
using System.ComponentModel.DataAnnotations;

namespace Employee_App.Models.EmploymentHistory
{
    public class EmploymentHistoryModel
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }

        [Required(ErrorMessage = "Data zatrudnienia jest wymagana.")]
        [DataType(DataType.Date)]
        public DateTime EmploymentDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TerminationDate { get; set; }

        [Required(ErrorMessage = "Stanowisko jest wymagane.")]
        [StringLength(100, ErrorMessage = "Nazwa stanowiska nie może być dłuższa niż 100 znaków.")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Dział jest wymagany.")]
        [StringLength(100, ErrorMessage = "Nazwa działu nie może być dłuższa niż 100 znaków.")]
        public string Department { get; set; }

        public int EmployerId { get; set; }
        public EmployerModel Employer { get; set; }
    }
}