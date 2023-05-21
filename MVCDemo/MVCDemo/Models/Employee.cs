using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using MVCDemo.Models;

namespace MVCDemo.Models
{
    [Table("tblEMployee")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public String City { get; set; }
        public int DepartmentID { get; set; }

    }
}












