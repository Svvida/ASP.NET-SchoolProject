using Data.Entities;
using Employee_App.Models;
using Employee_App.Models.Employee;
using Employee_App.Models.Employer;
using Employee_App.Models.EmploymentHistory;

namespace Employee_App.Mappers
{
    public class EmploymentHistoryMapper
    {
        public static EmploymentHistoryEntity ToEntity(EmploymentHistoryModel model)
        {
            return new EmploymentHistoryEntity
            {
                Id = model.Id,
                EmployeeId = model.EmployeeId,
                EmploymentDate = model.EmploymentDate,
                TerminationDate = model.TerminationDate,
                Position = model.Position,
                Department = model.Department,
                EmployerId = model.EmployerId
            };
        }

        public static EmploymentHistoryModel FromEntity(EmploymentHistoryEntity entity)
        {
            return new EmploymentHistoryModel
            {
                Id = entity.Id,
                EmployeeId = entity.EmployeeId,
                EmploymentDate = entity.EmploymentDate,
                TerminationDate = entity.TerminationDate,
                Position = entity.Position,
                Department = entity.Department,
                EmployerId = entity.EmployerId
            };
        }
    }
}
