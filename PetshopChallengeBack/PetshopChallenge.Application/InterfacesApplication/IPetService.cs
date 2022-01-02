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
        ReturnDefault GetAllPets(int Id);
        ReturnDefault UpdatePets(int Id, Pet UpdatedRegistration);
        ReturnDefault DeletePets(int Id);
    }
}
