using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class StudentModel
    {
        //create student model
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grades { get; set; }
    }
}
