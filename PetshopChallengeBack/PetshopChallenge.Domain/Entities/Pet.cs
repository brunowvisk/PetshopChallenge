using System.ComponentModel.DataAnnotations;

namespace PetshopChallenge.Domain.Entities
{
    public class Pet
    {
        public Pet()
        {
        }

        public Pet(int petId, string petName, string petAdmissionInfo, 
            int petHealthStatus, string ownerName, string ownerPhone, 
            string ownerCEP, string ownerAddress, string ownerComplement, 
            string ownerDistrict, string ownerState, string ownerCity)
        {
            PetId = petId;
            PetName = petName;
            PetAdmissionInfo = petAdmissionInfo;
            PetHealthStatus = petHealthStatus;
            OwnerName = ownerName;
            OwnerPhone = ownerPhone;
            OwnerCEP = ownerCEP;
            OwnerAddress = ownerAddress;
            OwnerComplement = ownerComplement;
            OwnerDistrict = ownerDistrict;
            OwnerState = ownerState;
            OwnerCity = ownerCity;
        }

        [Key]
        [Required]
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string PetAdmissionInfo { get; set; }
        public int PetHealthStatus { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerCEP { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerComplement { get; set; }
        public string OwnerDistrict { get; set; }
        public string OwnerState { get; set; }
        public string OwnerCity { get; set; }

        //[ForeignKey("Address")]
        //public int AddressId { get; set; }
        //public virtual Address Address { get; set; }


    }
}
