using System;
using System.ComponentModel.DataAnnotations;
using CollegeApp.Validators;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CollegeApp.Models
{
	public class StudentDTO
	{
        [ValidateNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Student Name is Required")]
        [StringLength(30)]
        public string StudentName { get; set; }

        [EmailAddress(ErrorMessage = "Please enter Valid Email Address")]
        public string Email { get; set; }

        [Range(10, 20)]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }

        // [DateCheck]

        public DateTime AdmissionDate { get; set; }

        /*
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        */
    }
}

