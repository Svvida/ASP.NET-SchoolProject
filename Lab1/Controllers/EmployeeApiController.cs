using Data;
using Microsoft.AspNetCore.Mvc;

namespace Employee_App.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeApiController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetFiltered(string filter)
        {
            return Ok(_context.Employees.Where(e => e.FirstName.Contains(filter) || e.LastName.Contains(filter)).ToList());
        }
    }
}
