using PetshopChallenge.Application.InterfacesApplication;
using PetshopChallenge.Domain.Entities;
using PetshopChallenge.Infra.InterfacesInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetshopChallenge.Application.Services
{
    public class PetServices : IPetService
    {
        private readonly IPetRepository _petRepository;
        public PetServices(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public ReturnDefault AddPet(Pet pet)
        {
            try
            {
                _petRepository.AddPet(pet);

                return new ReturnDefault()
                {
                    Success = true, 
                    Msg = "Pet added with success!", 
                    Data = pet
                };
            }
            catch(Exception e)
            {
                return new ReturnDefault() 
                {
                    Success= false, 
                    Msg = $"Error: {e}", 
                    Data = null
                };
            }

        }
        public ReturnDefault DeletePets(int Id)
        {
            Pet pet = (Pet)_petRepository.GetAllPets();

            _petRepository.DeletePet(pet);

            return new ReturnDefault()
            {
                Success = true,
                Msg = "Pet removed with success!",
                Data = pet
            };
        }

        public ReturnDefault GetAllPets()
        {
            var pets = _petRepository.GetAllPets();
            return GetReturnDefault(true, "All Pets", pets);
        }
        public ReturnDefault GetAllPets(int Id)
        {
            var pet = _petRepository.GetAllPets().Where(x => x.PetId == Id);
            return GetReturnDefault(true, "Pet found!", pet);
        }
        public ReturnDefault UpdatePets(int Id, Pet UpdatedRegistration)
        {
            try
            {
                Pet pet = (Pet)_petRepository.GetAllPets().Where(x => x.PetId == Id);

                pet.PetName = UpdatedRegistration.PetName;
                pet.OwnerName = UpdatedRegistration.OwnerName;
                pet.OwnerPhone = UpdatedRegistration.OwnerPhone;
                pet.OwnerCEP = UpdatedRegistration.OwnerCEP;
                pet.OwnerAddress = UpdatedRegistration.OwnerAddress;
                pet.OwnerComplement = UpdatedRegistration.OwnerComplement;
                pet.OwnerDistrict = UpdatedRegistration.OwnerDistrict;
                pet.OwnerCity = UpdatedRegistration.OwnerCity;
                pet.OwnerState = UpdatedRegistration.OwnerState;
                pet.PetAdmissionInfo = UpdatedRegistration.PetAdmissionInfo;
                pet.PetHealthStatus = UpdatedRegistration.PetHealthStatus;

                _petRepository.UpdatePet(pet);

                return new ReturnDefault()
                {
                    Success = true,
                    Msg = "Pet registration updated!",
                    Data = pet
                };

            }
            catch (Exception e)
            {
                return GetReturnDefault(false, $"Error {e}", null);
            }
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