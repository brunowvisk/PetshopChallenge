using PetshopChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetshopChallenge.Infra.InterfacesInfra
{
    public interface IAddressRepository
    {
        Address GetAddressByCEP(string CEP);
        IEnumerable<Address> GetAddressByCEP();
    }
}
