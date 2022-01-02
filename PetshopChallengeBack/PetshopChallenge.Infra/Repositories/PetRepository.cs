using PetshopChallenge.Domain.Entities;
using PetshopChallenge.Infra.Data;
using PetshopChallenge.Infra.InterfacesInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetshopChallenge.Infra.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly PetShopContext _context;

        public PetRepository(PetShopContext context)
        {
            _context = context;
        }

        public void AddPet(Pet pet)
        {
            _context.Add(pet);
            _context.SaveChanges();
        }


        public void DeletePet(Pet pet)
        {
            _context.Remove(pet);
            _context.SaveChanges();
        }


        public IEnumerable<Pet> GetAllPets()
        {
            return _context.Pets;
        }

        public Pet GetPetById(int Id)
        {
            return _context.Pets.Where(x => x.PetId == Id).FirstOrDefault();
        }


        public void UpdatePet(Pet pet)
        {
            _context.Update(pet);
            _context.SaveChanges();
        }



    }
}
