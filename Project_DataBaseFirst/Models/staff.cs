using System;
using System.Collections.Generic;

namespace Project_DataBaseFirst.Models
{
    public partial class staff
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal Salary { get; set; }
    }
}
