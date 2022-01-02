using PetshopChallenge.Domain.Entities;
using PetshopChallenge.Infra.Data;
using PetshopChallenge.Infra.InterfacesInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetshopChallenge.Infra.Repositories
{
    public class IAddressService : IAddressRepository
    {
        private readonly PetShopContext _context;

        public IAddressService(PetShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Address> GetAddressByCEP()
        {
            return _context.Addresses;
        }

        public Address GetAddressByCEP(string CEP)
        {
            return _context.Addresses.Where(x => x.CEP == CEP).FirstOrDefault();
        }

        //public Address GetAddressByCEP(string CEP)
        //{
        //    return _context.Addresses.Where(x => x.CEP == CEP).FirstOrDefault();
        //}

    }
}
