namespace Employee_App.Models.Address
{
    public interface IAddressService
    {
        IEnumerable<AddressModel> GetAllAddresses();

        AddressModel? GetAddressById(int id);
    }
}
