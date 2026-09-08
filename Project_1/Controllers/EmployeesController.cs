using Microsoft.AspNetCore.Mvc;
using Project_1.Models;
using System.Net;

namespace Project_1.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.EmployeeName = "Fatimah";
            //ViewBag.EmployeeID = "12345";
            //ViewBag.EmployeeEmail = "fatimah@example.com";
            //ViewBag.EmployeePhone = "123-456-7890";
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee { 

            Id = 1,
            Name = "Fatimah",
            Email = "fatimah@example.com",
            Phone = "123-456-7890",
            Address = "123 Main St",
            City = "New York"
            };

            Employee employee2 = new Employee { 

            Id = 2,
            Name = "Fatimah",
            Email = "fatimah@example.com",
            Phone = "123-456-7890",
            Address = "123 Main St",
            City = "New York"
            };

        Employee employee3 = new Employee {

            Id = 3,
            Name = "Fatimah",
            Email = "fatimah@example.com",
            Phone = "123-456-7890",
            Address = "123 Main St",
            City = "New York"
        };

            Employee employee4 = new Employee { 

            Id = 4,
            Name = "Fatimah",
            Email = "fatimah@example.com",
            Phone = "123-456-7890",
            Address = "123 Main St",
            City = "New York"
            };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);

            return View(employees);
        }
    }
}
