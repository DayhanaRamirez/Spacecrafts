using System;
using System.Collections.Generic;

namespace TechnicalChallenge.Models
{
    public partial class Crew : BaseEntity
    {
        public Crew()
        {
            Astronauts = new HashSet<Astronaut>();
            SpaceVehicleTypes = new HashSet<SpaceVehicleType>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Astronaut> Astronauts { get; set; }
        public virtual ICollection<SpaceVehicleType> SpaceVehicleTypes { get; set; }

        public override string SelfDescription()
        {
            return $"I'm {Name}. I am a crew, a group of people who work together, especially all those who work on and operate a ship, aircraft.";
        }

        public override string ShiftLength()
        {
            return $"My total work hours are the sum of all my astronauts work hours.";
        }
    }
}
