using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MundrosoftAssesment.Data;
using MundrosoftAssesment.Models;

namespace MundrosoftAssesment.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;

        public EmployeeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.Employees.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult create(Employees model)
        {
            if (ModelState.IsValid)
            {
                context.Add(model);
                context.SaveChanges();
                TempData["error"] = "Record Inserted Successfully !";
                return RedirectToAction("Index");
            }
            return View(model);

        }
        
       
        public IActionResult Delete(int id) {

            var emp = context.Employees.SingleOrDefault(e => e.Id == id);
            if (emp == null)
            {
                return NotFound(); // Return a 404 Not Found response if the employee is not found
            }

            context.Employees.Remove(emp);
            context.SaveChanges();
            TempData["error"] = "Record Deleted Successfully !";
            return RedirectToAction("Index"); 
        }

        public IActionResult Edit(int id)
        {
            var emp=context.Employees.SingleOrDefault(e=>e.Id == id);
            var result = new Employees()
            {
                Name = emp.Name,
                Email = emp.Email,
                Salary = emp.Salary,
                City = emp.City
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Employees model)
        {
            var emp = new Employees()
            { Id=model.Id,
                                        
                Name = model.Name,
                Email = model.Email,
                Salary = model.Salary,
                City = model.City
            };
            context.Employees.Update(emp);
            context.SaveChanges();
            TempData["error"] = "Record Updated Successfully !";
            return RedirectToAction("Index");
        }
    }

    }

