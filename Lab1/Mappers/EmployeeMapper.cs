using Data.Entities;
using Employee_App.Models;
namespace Employee_App.Mappers
{
    public class EmployeeMapper
    {
        public static EmployeeEntity toEntity(EmployeeModel model)
        {
            return new EmployeeEntity()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PESEL = model.PESEL,
                Position = model.Position,
                Department = model.Department,
                EmploymentDate = model.HireDate,
                TerminationDate = model.TerminationDate
            };
        }

        public static EmployeeModel FromEntity(EmployeeEntity entity)
        {
            return new EmployeeModel()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                PESEL = entity.PESEL,
                Position = entity.Position,
                Department = entity.Department,
                HireDate = entity.EmploymentDate,
                TerminationDate = entity.TerminationDate
            };
        }
    }
}
