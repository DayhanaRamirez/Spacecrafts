using System;
using System.Collections.Generic;

namespace TechnicalChallenge.Models
{
    public partial class Cargo : BaseEntity
    {
        public Cargo()
        {
            SpaceVehicleTypes = new HashSet<SpaceVehicleType>();
        }

        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;

        public virtual ICollection<SpaceVehicleType> SpaceVehicleTypes { get; set; }

        public override string SelfDescription()
        {
            return $"I'm {Name}. I am a cargo, the goods carried by a ship, aircraft, or other large vehicle.";
        }

        public override string ShiftLength()
        {
            return $"I don't work. My space vehicles does.";
        }
    }
}
