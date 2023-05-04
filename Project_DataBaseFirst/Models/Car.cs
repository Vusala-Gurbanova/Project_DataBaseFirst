using System;
using System.Collections.Generic;

namespace Project_DataBaseFirst.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? TypeOfBan { get; set; }
        public string? Color { get; set; }
        public int? Mileage { get; set; }
        public DateTime? Year { get; set; }
        public int? EngineSize { get; set; }
    }
}
