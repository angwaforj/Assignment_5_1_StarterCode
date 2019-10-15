using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class ProfileController : Controller
    {
        [HttpPost]
        public IActionResult CreatePerson()
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}