namespace Employee_App.Models.Employee
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployeeById(int employeeId);
        void AddEmployee(EmployeeModel employee);
        void UpdateEmployee(EmployeeModel employee);
        void DeleteEmployee(int employeeId);
    }
}
