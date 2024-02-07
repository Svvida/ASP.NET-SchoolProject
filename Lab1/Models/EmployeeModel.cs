using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Employee_App.Models
{
    public class EmployeeModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [HiddenInput]
        public DateTime Created { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Imię jest wymagane.")]
        [Display(Name = "Imię")]
        [StringLength(100, ErrorMessage = "Imię nie może być dłuższe niż 100 znaków.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [Display(Name = "Nazwisko")]
        [StringLength(100, ErrorMessage = "Nazwisko nie może być dłuższe niż 100 znaków.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "PESEL jest wymagany.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "PESEL musi składać się z 11 cyfr.")]
        [Display(Name = "PESEL")]
        public string PESEL { get; set; }

        [Required(ErrorMessage = "Stanowisko jest wymagane.")]
        [Display(Name = "Stanowisko")]
        [StringLength(100, ErrorMessage = "Nazwa stanowiska nie może być dłuższa niż 100 znaków.")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Dział jest wymagany.")]
        [Display(Name = "Dział")]
        [StringLength(100, ErrorMessage = "Nazwa działu nie może być dłuższa niż 100 znaków.")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Data zatrudnienia jest wymagana.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadź prawidłową datę zatrudnienia.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data zatrudnienia")]
        public DateTime HireDate { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data zakończenia musi być datą.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data zakończenia")]
        [ValidateTermination(ErrorMessage = "Data zakończenia musi być późniejsza niż data zatrudnienia.")]
        public DateTime? TerminationDate { get; set; }
        public int? EmployerId { get; set; }
        public EmployerEntity? Employer { get; set; }
    }
    public class ValidateTerminationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (EmployeeModel)validationContext.ObjectInstance;

            if (model.TerminationDate.HasValue && model.TerminationDate < model.HireDate)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
