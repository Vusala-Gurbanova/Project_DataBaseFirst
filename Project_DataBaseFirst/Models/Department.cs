using System;
using System.Collections.Generic;

namespace Project_DataBaseFirst.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentManager { get; set; }
    }
}
