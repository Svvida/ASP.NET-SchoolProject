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
        public IActionResult GetFiltered(string category, string filter)
        {
            var query = _context.Employees.AsQueryable();

            switch (category)
            {
                case "firstName":
                    query = query.Where(e => e.FirstName.Contains(filter));
                    break;
                case "lastName":
                    query = query.Where(e => e.LastName.Contains(filter));
                    break;
                case "Position":
                    query = query.Where(e => e.Position.Contains(filter));
                    break;
                case "Department":
                    query = query.Where(e => e.Department.Contains(filter));
                    break;
            }

            return Ok(query.ToList());
        }

    }
}
