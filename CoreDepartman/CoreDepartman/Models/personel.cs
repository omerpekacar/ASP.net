using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class personel
    {
        [Key]
        public int perid { get; set; }
        public int ad { get; set; }
        public string soyad { get; set; }
        public string sehir { get; set; }
        }
    }

