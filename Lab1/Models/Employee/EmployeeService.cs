using Data;
using Employee_App.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Employee_App.Models.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext employeeService)
        {
            _context = employeeService;
        }

        public void AddEmployee(EmployeeModel employee)
        {
            _context.Employees.Add(EmployeeMapper.toEntity(employee));
            _context.SaveChanges();
        }

        public void DeleteEmployee(int employeeid)
        {
            var entity = _context.Employees.Find(employeeid);
            if (entity != null)
            {
                _context.Employees.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return _context.Employees
                .Where(e => e.EmployerId == null)
                .Select(e => EmployeeMapper.FromEntity(e)).ToList();
        }

        public EmployeeModel? GetEmployeeById(int employeeid)
        {
            var entity = _context.Employees
                .Include(e => e.EmploymentHistory) // Załącz historię zatrudnienia
                .FirstOrDefault(e => e.Id == employeeid);

            if (entity != null)
            {
                return EmployeeMapper.FromEntity(entity);
            }
            else
            {
                return null;
            }
        }

        public void UpdateEmployee(int id, EmployeeModel employee)
        {
            _context.Employees.Update(EmployeeMapper.toEntity(employee));
            _context.SaveChanges();
        }

        public List<EmployeeModel> FindAll()
        {
            return _context.Employees.Select(e => EmployeeMapper.FromEntity(e)).ToList();
        }
    }
}
