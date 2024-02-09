using Employee_App.Models;
using Employee_App.Models.Employee;
using Employee_App.Models.Employer;
using Employee_App.Models.EmploymentHistory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Employee_App.Controllers
{
    [Authorize]
    public class EmployerController : Controller
    {
        private readonly IEmployerService _employerService;

        public EmployerController(IEmployerService employerService)
        {
            _employerService = employerService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var employers = _employerService.GetAllEmployers();
            return View(employers);
        }

        public IActionResult Details(int id)
        {
            var employer = _employerService.GetEmployerById(id);

            if (employer == null)
            {
                return NotFound();
            }

            return View(employer);
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View("Form");
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Create(EmployerModel model)
        {
            if (ModelState.IsValid)
            {
                _employerService.AddEmployer(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", model);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = _employerService.GetEmployerById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View("Edit", employee);
        }

        [HttpPost]
        public IActionResult Edit(EmployerModel model)
        {
            if (ModelState.IsValid)
            {
                _employerService.UpdateEmployer(model.EmployerId, model);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", model);
            }
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var employee = _employerService.GetEmployerById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "admin")]
        public IActionResult DeleteConfirmed(int id)
        {
            _employerService.DeleteEmployer(id);
            return RedirectToAction("Index");
        }
    }
}
