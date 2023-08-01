using Microsoft.AspNetCore.Mvc;
using ST_WebApp.Models;

namespace ST_WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult GetById(int id)
        {
            Employee employee = SampleData.Employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }


        // Action to get all employees
        public IActionResult GetAll()
        {
            return View(SampleData.Employees);
        }

    }
}
