using PetshopChallenge.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetshopChallenge.Domain.Entities
{
    public class PetAccommodation
    {
        public PetAccommodation()
        {
        }

        public PetAccommodation(int id, EAccommodationNumber accommodationNumber, 
            EAccommodationStatus accommodationStatus, int petId, Pet pet)
        {
            Id = id;
            AccommodationNumber = accommodationNumber;
            AccommodationStatus = accommodationStatus;
            PetId = petId;
            Pet = pet;
        }

        [Key]
        [Required]
        public int Id { get; set; }
        public EAccommodationNumber AccommodationNumber { get; set; }
        public EAccommodationStatus AccommodationStatus { get; set; }
        [ForeignKey ("Pet")]
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }

    }
}
