using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class StudentViewModel
    {
        //create student model
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "last Name")]
        public string LastName { get; set; }

        public string Grades { get; set; }

        public StudentViewModel(int id)
        {
            Students = new List<StudentModel> ();
        }
        //Create student information
       public List<StudentModel> Students { get; }

      
    }
}
