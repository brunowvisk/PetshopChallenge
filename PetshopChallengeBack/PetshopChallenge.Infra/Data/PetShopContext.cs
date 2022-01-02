using Microsoft.EntityFrameworkCore;
using PetshopChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetshopChallenge.Infra.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext(DbContextOptions<PetShopContext> opt) : base(opt)
        {

        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetAccommodation> Accommodations { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
