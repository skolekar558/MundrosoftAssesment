using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MundrosoftAssesment.Data;
using MundrosoftAssesment.Models;

namespace MundrosoftAssesment.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext context;
        public UserController(ApplicationDbContext context)
        {
            this.context = context;
        }
       
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
       
        public ActionResult Login(Users model)
        {
            if (ModelState.IsValid)
            {
                var user = context.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    // Set success message and redirect to the employee index page
                    TempData["SuccessMessage"] = "Login Successfully!";
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    // Set error message for invalid email or password and redirect to signup
                    TempData["error"] = "Invalid email or password.";
                    return RedirectToAction("Signup", "User");
                }
            }
            else
            {
                // ModelState is not valid, set error message and redirect to signup
                TempData["error"] = "Invalid email or password.";
                return RedirectToAction("Signup", "User");
            }
        }
        public IActionResult Registration()
        {
            return View();
        }

     
        [HttpPost]
        public IActionResult Register(Users model)
        {
            if (ModelState.IsValid)
            {
               
                context.Add(model);
                context.SaveChanges();
                TempData["SuccessMessage"] = "Registration successful!";
                return RedirectToAction("Signup", "User");
            }
            return View("Registration", model);
        }
    }
}
