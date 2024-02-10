using Data.Entities;
using Employee_App.Models.Address;

public static class AddressMapper
{
    public static AddressModel FromEntity(AddressEntity entity)
    {
        return new AddressModel
        {
            Id = entity.Id,
            City = entity.City,
            Street = entity.Street,
            PostalCode = entity.PostalCode
        };
    }

    public static AddressEntity ToEntity(AddressModel model)
    {
        return new AddressEntity
        {
            Id = model.Id,
            City = model.City,
            Street = model.Street,
            PostalCode = model.PostalCode
        };
    }
}