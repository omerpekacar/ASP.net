using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;

namespace MVCDemo.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int ID {get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}