using System;
using Microsoft.EntityFrameworkCore;
using SystemClothes.Models;

namespace SystemClothes.Data
{
    public class SystemClothesContext : DbContext
    {
        public SystemClothesContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Clothes> Clothes { get; set; }

        public DbSet<SystemClothes.Models.Buy> Buy { get; set; }
    }
}
