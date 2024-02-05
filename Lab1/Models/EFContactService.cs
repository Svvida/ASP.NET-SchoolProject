using Data;
using Employee_App.Mappers;

namespace Employee_App.Models
{
    public class EFContactService : IEmployeeService
    {
        private readonly AppDbContext _context;

        public EFContactService(AppDbContext employeeService)
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
            return (IEnumerable<EmployeeModel>)_context.Employees.Select(e => EmployeeMapper.FromEntity(e)).ToList();
        }

        public EmployeeModel? GetEmployeeById(int employeeid)
        {
            var entity = _context.Employees.Find(employeeid);
            if (entity != null)
            {
                return (EmployeeModel?)EmployeeMapper.FromEntity(_context.Employees.Find(employeeid));
            }
            else return null;

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
