using PetshopChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetshopChallenge.Application.InterfacesApplication
{
    public interface IPetService
    {
        ReturnDefault AddPet(Pet pet);
        ReturnDefault GetAllPets();
        ReturnDefault GetAllPets(int petId);
        ReturnDefault UpdatePets(int petId, Pet UpdatedRegistration);
        ReturnDefault DeletePets(int petId);
    }
}
