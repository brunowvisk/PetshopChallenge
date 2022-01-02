using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetshopChallenge.Application.InterfacesApplication;
using PetshopChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petShopChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetAccommodationController : ControllerBase
    {
        private readonly IPetAccommodationService _petAccommodationServices;
        public PetAccommodationController(IPetAccommodationService petAccommodationService)
        {
            _petAccommodationServices = petAccommodationService;
        }

        [HttpPost]
        public IActionResult AddAccommodation([FromBody] PetAccommodation petAccommodation)
        {
            var petAccommodationPost = _petAccommodationServices.AddAccommodation(petAccommodation);
            return Ok(petAccommodationPost);
        }

        [HttpGet]
        public IActionResult GetAllAccommodation()
        {

            return Ok(_petAccommodationServices.GetAllAccommodation());
        }

        [HttpGet("{id}")]
        public IActionResult GetAccommodationById(int Id)
        {

            return Ok(_petAccommodationServices.GetAllAccommodation(Id));
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveAccommodation(int Id)
        {

            var accommodation = _petAccommodationServices.DeleteAccommodation(Id);
            if (accommodation.Success)
            {
                return Ok(accommodation);
            }
            return NoContent();
        }


    }
}
