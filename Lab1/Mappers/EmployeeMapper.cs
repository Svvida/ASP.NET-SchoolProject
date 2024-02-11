using Data.Entities;
using Employee_App.Models.Employee;
using Employee_App.Models.Employer;

public static class EmployeeMapper
{
    public static EmployeeModel FromEntity(EmployeeEntity entity)
    {
                        return new EmployeeModel
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            HireDate=entity.EmploymentDate,
            TerminationDate=entity.TerminationDate,
            //Employer = entity.Employer == null ? null : new EmployerModel
            //{
            //    EmployerId = entity.Employer.EmployerId,
            //    FirstName = entity.Employer.FirstName,
            //    LastName = entity.Employer.LastName,
            //    CompanyName = entity.Employer.CompanyName,
            //    NIP = entity.Employer.NIP,
            //    City = entity.Employer.Address?.City,
            //    Street = entity.Employer.Address?.Street,
            //    PostalCode = entity.Employer.Address?.PostalCode
            //}
        };
    }

    public static EmployeeEntity ToEntity(EmployeeModel model)
    {
        return new EmployeeEntity
        {
            Id = model.Id,
            FirstName = model.FirstName,
            LastName = model.LastName,
            EmploymentDate=model.HireDate,
            TerminationDate=model.TerminationDate,
            //Employer = model.Employer == null ? null : new EmployerEntity
            //{
            //    EmployerId = model.Employer.EmployerId,
            //    FirstName = model.Employer.FirstName,
            //    LastName = model.Employer.LastName,
            //    CompanyName = model.Employer.CompanyName,
            //    NIP = model.Employer.NIP,
            //    Address = new AddressEntity
            //    {
            //        City = model.Employer.City,
            //        Street = model.Employer.Street,
            //        PostalCode = model.Employer.PostalCode
            //    }
            //}
        };
    }
}