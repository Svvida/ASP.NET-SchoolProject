using Employee_App.Models;
using Employee_App.Models.Employee;
using Employee_App.Models.Employer;
using Employee_App.Models.EmploymentHistory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Employee_App.Controllers
{
    [Authorize]
    public class EmploymentHistoryController : Controller
    {
        private readonly IEmploymentHistoryService _employmentHistoryService;

        public EmploymentHistoryController(IEmploymentHistoryService employmentHistoryService)
        {
            _employmentHistoryService = employmentHistoryService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var histories = _employmentHistoryService.GetAllEmploymentHistories();
            return View(histories);
        }

        public IActionResult Details(int id)
        {
            var history = _employmentHistoryService.GetEmploymentHistoryById(id);

            if (history == null)
            {
                return NotFound();
            }

            return View(history);
        }
    }
}
