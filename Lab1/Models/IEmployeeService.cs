namespace Employee_App.Models
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployeeById(int employeeid);
        void AddEmployee(EmployeeModel employee);
        void UpdateEmployee(int id, EmployeeModel employee);
        void DeleteEmployee(int employeeid);
    }
}
