using Employee_App.Models.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Employee_App.Models.Employer;
using Microsoft.EntityFrameworkCore;
using Data;
using Microsoft.AspNetCore.Authorization;

namespace Employee_App.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IEmployeeService _employeeService;
        private readonly IEmployerService _employerService;

        public EmployeeController(AppDbContext context, IEmployeeService employeeService, IEmployerService employerService)
        {
            _context = context;
            _employeeService = employeeService;
            _employerService = employerService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var employees = _employeeService.GetAllEmployees();
            if (employees == null)
            {
                return View(new List<EmployeeModel>()); // Pass an empty list to the view
            }
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var employers = _employerService.GetAllEmployers();
            ViewBag.Employers = new SelectList(employers, "EmployerId", "CompanyName");
            var model = new EmployeeModel
            {
                HireDate = DateTime.Today,
            };
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.AddEmployee(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        public IActionResult CreateApi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateApi(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            var employers = _employerService.GetAllEmployers();
            ViewBag.Employers = new SelectList(employers, "EmployerId", "CompanyName", employee.EmployerId);

            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(int id, EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.UpdateEmployee(model);
                return RedirectToAction("Index");
            }

            var employers = _employerService.GetAllEmployers();
            ViewBag.Employers = new SelectList(employers, "EmployerId", "CompanyName", model.EmployerId);
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ConfirmDelete(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }


    }
}
