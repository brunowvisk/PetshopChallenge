using PetshopChallenge.Application.InterfacesApplication;
using PetshopChallenge.Domain.Entities;
using PetshopChallenge.Infra.InterfacesInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetshopChallenge.Application.Services
{
    public class PetAccommodationServices : IPetAccommodationService
    {
        private readonly IPetAccommodationRepository _petAccommodationRepository;
        private readonly IPetRepository _petRepository;

        public PetAccommodationServices(IPetAccommodationRepository petAccommodationRepository, 
                                        IPetRepository petRepository)
        {
            _petAccommodationRepository = petAccommodationRepository;
            _petRepository = petRepository;
        }

        public ReturnDefault GetAllAccommodation()
        {
            var accommodation = _petAccommodationRepository.GetAllAccommodations();
            return GetReturnDefault(true, "All accommodations:", accommodation);
        }

        public ReturnDefault GetAllAccommodation(int Id)
        {
            var accommodation = _petAccommodationRepository.GetAllAccommodations().Where(x => x.PetId == Id);
            return GetReturnDefault(true, "Accommodation found!", accommodation);
        }

        public ReturnDefault AddAccommodation(PetAccommodation petAccommodation)
        {
            try
            {
                var pet = _petRepository.GetPetById(petAccommodation.PetId);

                if (pet == null)
                {
                    return new ReturnDefault()
                    {
                        Success = false,
                        Msg = "Veículo não encontrado!",
                        Data = pet
                    };
                }

                _petAccommodationRepository.AddAccommodation(petAccommodation);


                return new ReturnDefault() { Success = true, Msg = "Accommodation registered!", Data = petAccommodation };
            }
            catch (Exception e)
            {

                return new ReturnDefault() { Success = false, Msg = $"Error!{e}", Data = null };
            }
        }
        public ReturnDefault DeleteAccommodation(int Id)
        {
            PetAccommodation petAccommodation = (PetAccommodation)_petAccommodationRepository.GetAllAccommodations();

            _petAccommodationRepository.DeleteAccommodation(petAccommodation);

            return new ReturnDefault()
            {
                Success = true,
                Msg = "Accommodation removed with success!",
                Data = petAccommodation
            };
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