using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Makonisoft.Models
{
    public class PersonalInformationDTO
    {
        public int Id { get; set; }

        [Display(Name ="Firstname:")]
        [Required(ErrorMessage = "Firstname is required.")]
        [MaxLength(100)]
        [RegularExpression(@"^[a-zA-Z\s]+$",ErrorMessage ="Enter valid Firstname")]
        public string FirstName { get; set; }

        [Display(Name = "Lastname:")]
        [Required(ErrorMessage ="Lastname is required.")]
        [MaxLength(100)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter valid Lastname")]
        public string LastName { get; set; }
    }
}