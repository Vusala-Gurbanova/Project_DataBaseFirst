using System;
using System.Collections.Generic;

namespace Project_DataBaseFirst.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Birthplace { get; set; }
        public string? Gender { get; set; }
        public string? Identitynu { get; set; }
        public int? Identitypincode { get; set; }
        public DateTime? Bithdate { get; set; }
    }
}
