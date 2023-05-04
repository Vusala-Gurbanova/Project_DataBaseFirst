using System;
using System.Collections.Generic;

namespace Project_DataBaseFirst.Models
{
    public partial class CarsForSale
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? CarType { get; set; }
        public string? Color { get; set; }
        public int? Mileage { get; set; }
        public int? ProductionYear { get; set; }
        public int? EngineSize { get; set; }
    }
}
