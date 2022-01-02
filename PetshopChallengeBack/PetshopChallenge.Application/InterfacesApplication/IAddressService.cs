using PetshopChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetshopChallenge.Application.InterfacesApplication
{
    public interface IAddressService
    {
        ReturnDefault GetAllAddresses();
        ReturnDefault GetAddressByCEP(string CEP);
    }
}
