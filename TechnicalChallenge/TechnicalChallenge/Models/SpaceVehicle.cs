using System;
using System.Collections.Generic;

namespace TechnicalChallenge.Models
{
    public partial class SpaceVehicle : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public double Speed { get; set; }
        public double Weight { get; set; }
        public double Push { get; set; }
        public string Fuel { get; set; } = null!;
        public int IdType { get; set; }

        public virtual SpaceVehicleType IdTypeNavigation { get; set; } = null!;

        public override string SelfDescription()
        {
            return $"I'm {Name}. I am a space vehicle, the combination of a spacecraft and its launch vehicle which carries it into space.";
        }

        public override string ShiftLength()
        {
            return $"I never stop! I work 24/7 all year long.";
        }
    }
}
