using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DataAccess.Models.Shared;
using Demo.DataAccess.Models.Shared.Enums;

namespace Demo.DataAccess.Models.EmployeeModel
{
    public class Employee:BaseEntity
    {
        public String Name { get; set; } = null;
        public int Age { get; set; }
        public String Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public String? Email {  get; set; }
        public String? PhoneNumber { get; set; }
        public DateTime HiringDate { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
