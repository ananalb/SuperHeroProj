using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHero.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Superhero> Superheroes { get; set; }
    }
}
