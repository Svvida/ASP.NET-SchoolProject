using Employee_App.Models.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Employee_App.Models.Employer;
using Microsoft.EntityFrameworkCore;
using Data;

namespace Employee_App.Controllers
{
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
    }
}
