using System;
using System.Collections.Generic;

namespace Project_DataBaseFirst.Models
{
    public partial class Personal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? BirthPlace { get; set; }
        public int? DepId { get; set; }
    }
}
