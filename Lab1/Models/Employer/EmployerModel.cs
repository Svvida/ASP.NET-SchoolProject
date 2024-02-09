using Employee_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Employee_App.Models.Employee;
using Employee_App.Models.EmploymentHistory;

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

        public List<EmployeeModel> Employees { get; set; }

        // Opcjonalnie: Historia zatrudnienia
        public List<EmploymentHistoryModel> Employments { get; set; }
    }
}