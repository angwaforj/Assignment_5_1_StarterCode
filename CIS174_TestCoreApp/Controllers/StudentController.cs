using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<StudentModel> students = new List<StudentModel>()
        {

            new StudentModel()
            {
               ID = 2,
                FirstName = "Alattore",
                LastName = "vernon",
                Grades = "A"
            },
            new StudentModel()
            {
                ID = 3,
                FirstName = "Jackson",
                LastName = "Angwafor",
                Grades = "A+"
            },
            new StudentModel()
            {
                ID = 4,
                FirstName = "Mary",
                LastName = "Jane",
                Grades = "B+"
            },
            new StudentModel()
            {
                ID = 5,
                FirstName = "Madison",
                LastName = "Clifton",
                Grades = "C+"
            },
            new StudentModel()
            {
                ID = 6,
                FirstName = "Joshua",
                LastName = "Obama",
                Grades = "B"
            }
        };
        
        
        public IActionResult Student(IList<int> id)

        {
          IList<int> ID = new List<int>(){1,2,3,4,5,6,7,8,9,10};
          ID = id;

           
           
            return View(students);
    }
    /*  {
          StudentModel student = new StudentModel();
          {
              student.FirstName = "Alattore";
              student.LastName = "vernon";
              student.Grades = "A";
              studentModel.Add(student);

              student = new StudentModel();

              student.FirstName = "Jackson";
              student.LastName = "Angwafor";
              student.Grades = "A+";
              studentModel.Add(student);

              student = new StudentModel();

              student.FirstName = "Jude";
              student.LastName = "Sama";
              student.Grades = "B+";
              studentModel.Add(student);

              student = new StudentModel();

              student.FirstName = "Jane";
              student.LastName = "Bitterleaf";
              student.Grades = "C+";
              studentModel.Add(student);

              student = new StudentModel();

              student.FirstName = "Madison";
              student.LastName = "Obama";
              student.Grades = "B";
              studentModel.Add(student);  */


    }
    
}

  