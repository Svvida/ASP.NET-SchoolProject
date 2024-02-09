using Data.Entities;
using Employee_App.Models.Employer;

namespace Employee_App.Mappers
{
    public class EmployerMapper
    {
        public static EmployerEntity ToEntity(EmployerModel model)
        {
            return new EmployerEntity
            {
                EmployerId = model.EmployerId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                CompanyName = model.CompanyName,
                NIP = model.NIP
            };
        }

        public static EmployerModel FromEntity(EmployerEntity entity)
        {
            return new EmployerModel
            {
                EmployerId = entity.EmployerId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                CompanyName = entity.CompanyName,
                NIP = entity.NIP
            };
        }
    }
}
