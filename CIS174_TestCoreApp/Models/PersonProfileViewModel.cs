using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CIS174_TestCoreApp.Models
{
    public class PersonProfileViewModel
    {
       

        //Create person profile view model with validations
        [Required]
        [MaxLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(25), MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required]
        [Range(1, 120, ErrorMessage = "Must be an integer!")]
        public int Age { get; set; }

       
        
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email confirmation is required")]
        [EmailAddress]
        [Display(Name = "Confirm Email")]
        [Compare(nameof(Email), ErrorMessage = "Must have the same value as the email field.")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        public string Country { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }

        = new List<SelectListItem>
        {
           new SelectListItem{Value = "USA", Text ="United States"},
           new SelectListItem{Value = "Mex", Text= " Mexico"},
           new SelectListItem{Value = "CA", Text = " Canada"}
        };
    }
}
