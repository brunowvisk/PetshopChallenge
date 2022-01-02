using PetshopChallenge.Infra.InterfacesInfra;
using IAddressService = PetshopChallenge.Application.InterfacesApplication.IAddressService;

namespace PetshopChallenge.Application.Services
{
    public class AddressServices : IAddressService
    {
        private readonly IAddressRepository _AddressRepository;
        public AddressServices(IAddressRepository AddressRepository)
        {
            _AddressRepository = AddressRepository;
        }


        public ReturnDefault GetAllAddresses()
        {
            var cep = _AddressRepository;
            return GetReturnDefault(true, "All Zip Codes", cep);
        }

        public ReturnDefault GetAddressByCEP(string CEP)
        {
            var address = _AddressRepository.GetAddressByCEP(CEP);
            return GetReturnDefault(true, "Address found!", address);
        }

        private ReturnDefault GetReturnDefault(bool Success, string Msg, object Data)
        {
            return new ReturnDefault() 
            { 
                Success = Success, 
                Msg = Msg, 
                Data = Data };
            }

    }
}