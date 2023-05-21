using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CoreDepartman.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-0G4HB6H\\SQLEXPRESS; database=corepersonel; integrated security=true;TrustServerCertificate=true;");
            }
        }
        public DbSet<Departmanlar>departmanlars{ get; set; }
        public DbSet<personel> Personels { get; set; }
        
    }
}

