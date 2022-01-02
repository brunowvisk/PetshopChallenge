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
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;
        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpPost]
        public IActionResult AddPet([FromBody] Pet pet)
        {
            var petPost = _petService.AddPet(pet);
            return Ok(petPost);
        }


        [HttpGet]
        public IActionResult GetAllPets()
        {
            
            return Ok(_petService.GetAllPets());
        }

        [HttpGet("{id}")]
        public IActionResult GetPetById(int petId)
        {

            return Ok(_petService.GetAllPets(petId));
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePet(int id, Pet UpdatedPet)
        {
            var pet = _petService.UpdatePets(id, UpdatedPet);
            if (pet.Success)
            {
                return Ok(pet);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult RemovePet(int petId)
        {

            var pet = _petService.DeletePets(petId);
            if (pet.Success)
            {
                return Ok(pet);
            }
            return NoContent();
        }


    }
}
