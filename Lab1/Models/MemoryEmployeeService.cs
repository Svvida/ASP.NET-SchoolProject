using System.Globalization;

namespace Employee_App.Models
{
    public class MemoryEmployeeService : IEmployeeService
    {
        private readonly IDateTimeProvider _timeProvider;
        private readonly List<EmployeeModel> employeeList = new List<EmployeeModel>();

        public MemoryEmployeeService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;

            employeeList.Add(new EmployeeModel
            {
                Id = 1,
                Created = _timeProvider.GetDateTime(),
                FirstName = "John",
                LastName = "Doe",
                PESEL = "12345678901",
                Position = "Developer",
                Department = "IT",
                HireDate = DateTime.Now,
                TerminationDate = null,
            });

            employeeList.Add(new EmployeeModel
            {
                Id = 2,
                Created = _timeProvider.GetDateTime(),
                FirstName = "Jane",
                LastName = "Smith",
                PESEL = "98765432109",
                Position = "Manager",
                Department = "HR",
                HireDate = DateTime.Now,
                TerminationDate = DateTime.ParseExact("13-12-2042", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            });

            employeeList.Add(new EmployeeModel
            {
                Id = 4,
                Created = DateTime.ParseExact("26-09-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                FirstName = "Bob",
                LastName = "Miller",
                PESEL = "55566777888",
                Position = "Analyst",
                Department = "Finance",
                HireDate = DateTime.ParseExact("27-09-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                TerminationDate = DateTime.ParseExact("25-06-2043", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            });

            employeeList.Add(new EmployeeModel
            {
                Id = 3,
                Created = _timeProvider.GetDateTime(),
                FirstName = "Alice",
                LastName = "Johnson",
                PESEL = "11122333444",
                Position = "Designer",
                Department = "Creative",
                HireDate = DateTime.ParseExact("11-03-2002", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                TerminationDate = null,
            });
        }
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return employeeList;
        }

        public EmployeeModel GetEmployeeById(int employeeId) => employeeList.FirstOrDefault(e => e.Id == employeeId);

        public void AddEmployee(EmployeeModel model)
        {
            model.Id = employeeList.Count + 1;
            model.Created = _timeProvider.GetDateTime();
            employeeList.Add(model);
        }

        public void UpdateEmployee(int employeeId, EmployeeModel updatedEmployee)
        {
            var index = employeeList.FindIndex(e => e.Id == employeeId);

            if (index != -1)
            {
                updatedEmployee.Id = employeeId;
                employeeList[index] = updatedEmployee;
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employeeToRemove = employeeList.FirstOrDefault(e => e.Id == employeeId);

            if (employeeToRemove != null)
            {
                employeeList.Remove(employeeToRemove);
            }
        }
    }
}
