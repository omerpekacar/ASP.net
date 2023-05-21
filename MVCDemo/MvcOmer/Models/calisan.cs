using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOmer.Models
{
    [Table("tblCalisan")]
    public class Calisan
    {
        public int CalisanID { get; set; }
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String Cihaz  { get; set; }
    }
}