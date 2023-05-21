using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Management.Instrumentation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOmer.Models
{
    public class CalisanContext : DbContext
    {
        public DbSet <Calisan> calisans { get; set; }

    }
}