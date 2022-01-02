using PetshopChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetshopChallenge.Infra.InterfacesInfra
{
    public interface IPetAccommodationRepository
    {
        IEnumerable<PetAccommodation> GetAllAccommodations();

        PetAccommodation GetAccommodationById(int Id);

        void AddAccommodation(PetAccommodation petAccommodation);
        void UpdateAccommodation(PetAccommodation petAccommodation);
        void DeleteAccommodation(PetAccommodation petAccommodation);

    }
}
