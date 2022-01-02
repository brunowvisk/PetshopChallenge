using Microsoft.EntityFrameworkCore;
using PetshopChallenge.Domain.Entities;
using PetshopChallenge.Infra.Data;
using PetshopChallenge.Infra.InterfacesInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetshopChallenge.Infra.Repositories
{
    public class PetAccommodationRepository : IPetAccommodationRepository
    {
        private readonly PetShopContext _context;

        public PetAccommodationRepository(PetShopContext context)
        {
            _context = context;
        }

        public void AddAccommodation(PetAccommodation petAccommodation)
        {
            _context.Add(petAccommodation);
            _context.SaveChanges();
        }

        public void DeleteAccommodation(PetAccommodation petAccommodation)
        {
            _context.Remove(petAccommodation);
            _context.SaveChanges();
        }

        public IEnumerable<PetAccommodation> GetAllAccommodations()
        {
            return _context.Accommodations.Include(x => x.Pet);
        }

        public PetAccommodation GetAccommodationById(int Id)
        {
            return _context.Accommodations.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void UpdateAccommodation(PetAccommodation petAccommodation)
        {
            _context.Update(petAccommodation);
            _context.SaveChanges();
        }

    }
}
