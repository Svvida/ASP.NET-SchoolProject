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
                .ToList() // Fetch the data from the database
                .Select(e => new EmployeeModel
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    PESEL = e.PESEL,
                    Position = e.Position,
                    Department = e.Department,
                    Employer = e.Employer != null ? new EmployerModel
                    {
                        EmployerId = e.Employer.EmployerId,
                        CompanyName = e.Employer.CompanyName,
                        FirstName = e.Employer.FirstName,
                        LastName = e.Employer.LastName,
                        NIP = e.Employer.NIP,
                        Address = e.Employer.Address != null ? new AddressModel
                        {
                            City = e.Employer.Address.City,
                            Street = e.Employer.Address.Street,
                            PostalCode = e.Employer.Address.PostalCode
                        } : null
                    } : null
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
            var employee = _context.Employees
                .Include(e => e.Employer)
                .ThenInclude(e => e.Address)
                .FirstOrDefault(e => e.Id == id);

            return employee != null ? new EmployeeModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PESEL = employee.PESEL,
                Position = employee.Position,
                Department = employee.Department,
                Employer = employee.Employer != null ? new EmployerModel
                {
                    EmployerId = employee.Employer.EmployerId,
                    CompanyName = employee.Employer.CompanyName,
                    FirstName = employee.Employer.FirstName,
                    LastName = employee.Employer.LastName,
                    NIP = employee.Employer.NIP,
                    Address = employee.Employer.Address != null ? new AddressModel
                    {
                        City = employee.Employer.Address.City,
                        Street = employee.Employer.Address.Street,
                        PostalCode = employee.Employer.Address.PostalCode
                    } : null,
                } : null,
            } : null;
        }
    }
}
