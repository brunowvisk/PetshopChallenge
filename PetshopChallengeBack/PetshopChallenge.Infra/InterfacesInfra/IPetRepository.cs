using PetshopChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetshopChallenge.Infra.InterfacesInfra
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAllPets();

        Pet GetPetById(int petId);

        void AddPet(Pet pet);

        void UpdatePet(Pet pet);

        void DeletePet(Pet pet);
    }
}
