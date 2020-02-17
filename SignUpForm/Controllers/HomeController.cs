using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignUpForm.Models;
using SignUpForm.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SignUpForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/

        // Displays the Student.cshtml Razor view file.
        public IActionResult Student()
        {
            List<Lecturer> lecturers = new List<Lecturer>()
            {
                new Lecturer() { Name = "William Raffe", Class = "Computer Game Programming"},
                new Lecturer() { Name = "Max Hendriks", Class = "Lans and Routing"},
                new Lecturer() { Name = "Flavio Pileggi", Class = "Business Systems Design"}
            };

            var viewModel = new StudentLecturerViewModel()
            {
                Student = new Student(),
                Lecturers = lecturers
            };

            return View(viewModel);
        }

        // Receives values from html view with HttpPost
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Student([Bind("Name, Age")] Student model)
        {
            // ModelState.IsValid checks if the input value of the model has an error or not.
            // If the validation is true, it stores the model data into Student table.
            if (ModelState.IsValid)
            {
                
            }
            // If the validation is false, shows the error.
            else
            {
            }
            return View();
        }
    }
}
