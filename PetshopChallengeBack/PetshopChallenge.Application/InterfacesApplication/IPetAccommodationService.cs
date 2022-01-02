using PetshopChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetshopChallenge.Application.InterfacesApplication
{
    public interface IPetAccommodationService
    {
        ReturnDefault AddAccommodation(PetAccommodation petAccommodation);
        ReturnDefault GetAllAccommodation(int Id);
        ReturnDefault GetAllAccommodation();
        ReturnDefault DeleteAccommodation(int Id);


    }
}
