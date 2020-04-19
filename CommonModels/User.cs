using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommonModels
{

    public class User
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string First_Name { get; set; }
        
        [Required]
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        [Phone]
        [Required]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="Password must be atleast 8 characters long.")]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Please enter confirm password")]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match with Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required]
        [Range(17,100)]
        public int Age { get; set; }

        [Required]
        [Display(Name = "User Type")]
        public string User_Type { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string Postal_Code { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [MinAge]
        public DateTime DOB { get; set; }
    }


    public class MinAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            value = (DateTime)value;
            if (DateTime.Now.AddYears(-17).CompareTo(value) >= 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("DOB must be atleast 17 years old!");
            }
        }
    }

}