namespace Employee_App.Models.Employer
{
    public interface IEmployerService
    {
        public void AddEmployer(EmployerModel employerModel);
        public void UpdateEmployer(int id, EmployerModel employerModel);
        public void DeleteEmployer(int id);
        public List<EmployerModel> GetAllEmployers();
        public EmployerModel GetEmployerById(int employerId);

    }
}
