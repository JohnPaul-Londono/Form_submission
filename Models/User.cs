using System;
using System.ComponentModel.DataAnnotations;

namespace Form_submission.Models
{

    public class Form
    {
        [Required(ErrorMessage = "What's your first name?")]
        [MinLength(4, ErrorMessage = "First name must be 4 characters long.")]
        public string firstName{ get; set; }

        [Required(ErrorMessage = "What's your last name?")]
        [MinLength(4, ErrorMessage = "Last name must be 4 characters long.")]
        public string lastName{ get; set; }

        [Required(ErrorMessage = "How old are you?")]
        [Range(1, int.MaxValue, ErrorMessage = "Age must be greater than 0.")]
        public int age{ get; set; }

        [Required(ErrorMessage = "Please put your email.")]
        [EmailAddress]
        public string email{ get; set; }

        [Required(ErrorMessage = "Please set a password.")]
        [MinLength(8,ErrorMessage ="Password must be at least 8 chracters.")]
        [DataType(DataType.Password)]
        public string password { get; set; }

    }
}