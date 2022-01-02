using System;

namespace PetshopChallenge.Shared
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime DateRegistration { get; set; }

        public Entity()
        {
            DateRegistration = DateTime.Now;
        }
    }
}
