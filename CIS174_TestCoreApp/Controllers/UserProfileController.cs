using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class UserProfileController : Controller
    {
        
        
        public IActionResult CreatePerson(PersonProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Message"] = "Your Profile has been created Successfully!";
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}