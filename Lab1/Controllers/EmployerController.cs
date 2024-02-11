using Employee_App.Models.Employer;
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
        [HttpGet]
        public IActionResult Create()
        {
            return View(new EmployerModel());
        }

        [HttpPost]
        public IActionResult Create(EmployerModel employerModel)
        {
            if (ModelState.IsValid)
            {
                _employerService.AddEmployer(employerModel);
                return RedirectToAction("Index");
            }
            return View(employerModel);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employer = _employerService.GetEmployerById(id);
            if (employer == null)
            {
                return NotFound();
            }
            return View(employer);
        }

        [HttpPost]
        public IActionResult Edit(EmployerModel employerModel)
        {
            if (ModelState.IsValid)
            {
                _employerService.UpdateEmployer(employerModel.EmployerId, employerModel);
                return RedirectToAction("Index");
            }
            return View(employerModel);
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var employer = _employerService.GetEmployerById(id);
            if (employer == null)
            {
                return NotFound();
            }
            return View(employer);
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
