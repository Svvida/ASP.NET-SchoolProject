using System.ComponentModel.DataAnnotations;

public class InputModel
{
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [Display(Name = "Company Name")]
    public string CompanyName { get; set; }

    [Required]
    [Display(Name = "NIP")]
    public string NIP { get; set; }
}
