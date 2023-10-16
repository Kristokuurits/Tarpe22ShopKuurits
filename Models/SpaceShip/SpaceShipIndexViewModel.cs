namespace Tarpe22ShopKuurits.Models.SpaceShip
{
    public class SpaceShipIndexViewModel
    {
        public Guid Id { get; set; } //unique id
        public int Price { get; set; } // price of the spaceship
        public string Type { get; set; } //spaceship type
        public string Name { get; set; } //name of the spaceship
        public string Description { get; set; } //description of the spaceship
        public string FuelType { get; set; } //what type of fuel does he spaceship use
        public int FuelCapacity { get; set; } // how much fuel can it hold
        public int FuelConsumption { get; set; } // how much fuel does it use
        public string PassengerCount { get; set; } // how many passenger fit in the ship
        public int Enginepower { get; set; } // how powerful the engine is
        public bool DoesHaveAutopilot { get; set; } // does the ship have autopilot
        public int CrewCount { get; set; } // how many people does it take to man the ship
        public int CargoWeight { get; set; } // how much cargo can the ship transport
        public bool DoesHaveLifeSupportSystems { get; set; } // does the ship have life support system
        public DateTime BuiltAt { get; set; } // when was the ship built at
        public DateTime LastMaintenance { get; set; } // when was the last ship maintained at
        public int MaintenanceCount { get; set; } // how many maintenance sessions has been performed on the ship
        public int FullTripsCount { get; set; } // how many voyages the ship has gone through
        public DateTime MaidenLaunch { get; set; } //
        public string Manufacturer { get; set; }// who manufactured the spaceship

        //database info, do not display user

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
