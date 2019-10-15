using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using UrlAttribute = System.ComponentModel.DataAnnotations.UrlAttribute;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePersonViewModel
    {
    
    [Required]
    [StringLength(25)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [StringLength(25)]
    [Display(Name = "Middle Name")]
    public string MiddleName { get; set; }

    [Required]
    [StringLength(25)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [Range(1, 120)]
    public int Age { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Confirm Email")]
    [Compare(nameof(Email), ErrorMessage = "Must have the same value as the email field.")]
    public string ConfirmEmail { get; set; }


    public string Website { get; set; }

    public string School { get; set; }  
}  
}
