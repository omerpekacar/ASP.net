using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CoreDepartman.Models
{
    public class Departmanlar
    {
        [Key]
        public int id { get; set; }
        public string departmanad { get; set; }
        
    }
}
