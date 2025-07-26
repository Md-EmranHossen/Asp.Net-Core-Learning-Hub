using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using ValidationExample.CustomBalidators;

namespace ValidationExample.Models
{
    public class Person : IValidatableObject
    {
        [Required(ErrorMessage = "{0} can't be null or empty")]
        [Display(Name = "Person Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} should be between {2} to {1} characters")]
        [RegularExpression("^[A-Za-z .]*$", ErrorMessage = "{0} should contaion only alphabets, space and .")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "{0} can't be null or empty")]
        [EmailAddress(ErrorMessage = "{0} should be a proper email address")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "{0} should be a proper phone number")]
        //[ValidateNever]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "{0} can't be balnk")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "{0} can't be balnk")]
        [Compare("Password", ErrorMessage = "{0}. {1} do not match")]
        [Display(Name = "Re-enter Password")]
        public string? ConfirmPassword { get; set; }


        [Range(0, 999.99, ErrorMessage = "{0} should be between ${1} and ${2}")]
        public double? Price { get; set; }

        [MinimunYearValidation(2005, ErrorMessage = "Date of Birth should not be newer thean jan 01, {0}")]
        [BindNever]
        public DateTime? DateOfBirth { get; set; }

        public int? Age { get; set; }
        public DateTime? FromDate { get; set; }

        
        public DateTime? ToDate { get; set; }

        [DateRangeValidator("FromDate",ErrorMessage = "From date should be older than or equal to date")]
        public override string ToString()
        {
            return $"Person Name: {Name} \n Email: {Email} \n Phone Number: {PhoneNumber} \n Password: {Password} \n Confirm Password{ConfirmPassword} \n Price: {Price}";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           if(DateOfBirth == null && Age == null)
            {
              yield  return new ValidationResult("Eigher of date of  birth or date should be supplied", new[]
                {
                    nameof(Age)
                });
            }
        }
    }
}
