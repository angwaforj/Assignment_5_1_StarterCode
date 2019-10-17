using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<StudentModel> _students = new List<StudentModel>()
        {

            new StudentModel()
            {
              
                FirstName = "Alattore",
                LastName = "vernon",
                Grades = "A"
            },
            new StudentModel()
            {
               
                FirstName = "Jackson",
                LastName = "Angwafor",
                Grades = "A+"
            },
            new StudentModel()
            {
               
                FirstName = "Mary",
                LastName = "Jane",
                Grades = "B+"
            },
            new StudentModel()
            {
               
                FirstName = "Madison",
                LastName = "Clifton",
                Grades = "C+"
            },
            new StudentModel()
            {
               
                FirstName = "Joshua",
                LastName = "Obama",
                Grades = "B"
            }
        };
       

      
        public IActionResult Student(int id)

        {
            return View(_students);

        }
    

    }
    
}

  