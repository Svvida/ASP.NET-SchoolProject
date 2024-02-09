using System.Collections.Generic;

namespace Employee_App.Models.Employer
{
    public interface IEmployerService
    {
        IEnumerable<EmployerModel> GetAllEmployers();
        EmployerModel GetEmployerById(int employerId);
        void AddEmployer(EmployerModel employer);
        void UpdateEmployer(int id, EmployerModel employer);
        void DeleteEmployer(int employerId);
    }
}