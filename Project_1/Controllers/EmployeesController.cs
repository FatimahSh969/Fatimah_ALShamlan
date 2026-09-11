using Microsoft.AspNetCore.Mvc;
using Project_1.Data;
using Project_1.Models;
using System.Net;

namespace Project_1.Controllers
{
    public class EmployeesController : Controller

    {
        private readonly ApplicationDbContext _dbcontext;

        public EmployeesController(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.EmployeeName = "Fatimah";
            //ViewBag.EmployeeID = "12345";
            //ViewBag.EmployeeEmail = "fatimah@example.com";
            //ViewBag.EmployeePhone = "123-456-7890";
            //List<Employee> employees = new List<Employee>();

            //    Employee employee1 = new Employee { 

            //    Id = 1,
            //    Name = "Fatimah",
            //    Email = "fatimah@example.com",
            //    Phone = "123-456-7890",
            //    Address = "123 Main St",
            //    Salary = 5000.0
            //    };

            //    Employee employee2 = new Employee { 

            //    Id = 2,
            //    Name = "Fatimah",
            //    Email = "fatimah@example.com",
            //    Phone = "123-456-7890",
            //    Address = "123 Main St",
            //    Salary = 10000.0
            //    };

            //Employee employee3 = new Employee {

            //    Id = 3,
            //    Name = "Fatimah",
            //    Email = "fatimah@example.com",
            //    Phone = "123-456-7890",
            //    Address = "123 Main St",
            //    Salary = 7500.0
            //};

            //    Employee employee4 = new Employee { 

            //    Id = 4,
            //    Name = "Fatimah",
            //    Email = "fatimah@example.com",
            //    Phone = "123-456-7890",
            //    Address = "123 Main St",
            //    Salary = 12000.0
            //    };

            //    employees.Add(employee1);
            //    employees.Add(employee2);
            //    employees.Add(employee3);
            //    employees.Add(employee4);

            //    return View(employees);
            
            List<Employee> employees = _dbcontext.Employees.ToList();

            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();    
        }
        
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            _dbcontext.Employees.Add(emp);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
