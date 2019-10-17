using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class HouseViewModel
    {
        //cCreating house view model
        
        public int Id { get; set; }

        [Required]
        [Display(Name = "Bedrooms")]
        [Range(1,10, ErrorMessage = "Must be an integer!")]
        public int BedRooms { get; set; }

        [Required]
        [Display(Name = "Square Feet")]
        [Range(1, 10000, ErrorMessage = "Must be an integer!")]
        public int SquareFeet { get; set; }

        [DataType(DataType.Date)]
        public string DateBuilt { get; set; }

        [Required]
        public string Flooring { get; set; }
    }
}
