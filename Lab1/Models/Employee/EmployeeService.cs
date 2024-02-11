using Data;
using Data.Entities;
using Employee_App.Models.Employer;
using Microsoft.EntityFrameworkCore;
using Employee_App.Models.Address;

namespace Employee_App.Models.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            var employees = _context.Employees
                .Include(e => e.Employer)
                .ThenInclude(employer => employer.Address)
                .ToList()
                .Select(e => new EmployeeModel
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    PESEL = e.PESEL,
                    Position = e.Position,
                    Department = e.Department,
                })
                .ToList();

            return employees;
        }
        public void AddEmployee(EmployeeModel employee)
        {
            var employeeEntity = new EmployeeEntity
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PESEL = employee.PESEL,
                Position = employee.Position,
                Department = employee.Department,
                TerminationDate = employee.TerminationDate,
                EmployerId = employee.EmployerId
            };

            var employer = _context.Employers.Find(employee.EmployerId);
            if (employer == null)
            {
                throw new Exception("Employer not found.");
            }
            employeeEntity.Employer = employer;
            _context.Employees.Add(employeeEntity);
            _context.SaveChanges();
        }
        public void UpdateEmployee(EmployeeModel employee)
        {
            var employeeEntity = _context.Employees.FirstOrDefault(e => e.Id == employee.Id);
            if (employeeEntity != null)
            {
                employeeEntity.FirstName = employee.FirstName;
                employeeEntity.LastName = employee.LastName;
                employeeEntity.EmployerId = employee.EmployerId;
                employeeEntity.PESEL = employee.PESEL;
                employeeEntity.Position = employee.Position;
                employeeEntity.Department = employee.Department;

                _context.SaveChanges();
            }
        }
        public void DeleteEmployee(int id)
        {
            var employeeEntity = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employeeEntity != null)
            {
                _context.Employees.Remove(employeeEntity);
                _context.SaveChanges();
            }
        }
        public EmployeeModel GetEmployeeById(int id)
        {
            var employeeEntity = _context.Employees
                .Include(e => e.Employer)
                .FirstOrDefault(e => e.Id == id);

            if (employeeEntity == null) return null;

            var employeeModel = new EmployeeModel
            {
                Id = employeeEntity.Id,
                FirstName = employeeEntity.FirstName,
                LastName = employeeEntity.LastName,
                PESEL = employeeEntity.PESEL,
                Position = employeeEntity.Position,
                Department = employeeEntity.Department,
                HireDate = employeeEntity.EmploymentDate,
                TerminationDate = employeeEntity.TerminationDate,
                Employer = new EmployerModel
                {
                    EmployerId = employeeEntity.Employer.EmployerId,
                    CompanyName = employeeEntity.Employer.CompanyName,
                    NIP = employeeEntity.Employer.NIP,
                }
            };

            return employeeModel;
        }
    }
}
