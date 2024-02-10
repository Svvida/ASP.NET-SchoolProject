using Data.Entities;
using Employee_App.Models.Employer;

public static class EmployerMapper
{
    public static EmployerModel FromEntity(EmployerEntity entity)
    {
        return new EmployerModel
        {
            EmployerId = entity.EmployerId,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            CompanyName = entity.CompanyName,
            NIP = entity.NIP,
            City = entity.Address?.City,
            Street = entity.Address?.Street,
            PostalCode = entity.Address?.PostalCode
        };
    }

    public static EmployerEntity ToEntity(EmployerModel model)
    {
        return new EmployerEntity
        {
            EmployerId = model.EmployerId,
            FirstName = model.FirstName,
            LastName = model.LastName,
            CompanyName = model.CompanyName,
            NIP = model.NIP,
            Address = new AddressEntity
            {
                City = model.City,
                Street = model.Street,
                PostalCode = model.PostalCode
            }
        };
    }
}