using System.Collections.Generic;

namespace Employee_App.Models.EmploymentHistory
{
    public interface IEmploymentHistoryService
    {
        IEnumerable<EmploymentHistoryModel> GetAllEmploymentHistories();
        EmploymentHistoryModel GetEmploymentHistoryById(int historyId);
        void AddEmploymentHistory(EmploymentHistoryModel employmentHistory);
        void UpdateEmploymentHistory(int id, EmploymentHistoryModel employmentHistory);
        void DeleteEmploymentHistory(int historyId);
    }
}
