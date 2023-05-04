using System;
using System.Collections.Generic;

namespace Project_DataBaseFirst.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; } = null!;
        public string EmployeeLastName { get; set; } = null!;
        public decimal Salary { get; set; }
        public string Designation { get; set; } = null!;
    }
}
