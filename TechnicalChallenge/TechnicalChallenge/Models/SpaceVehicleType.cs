using System;
using System.Collections.Generic;

namespace TechnicalChallenge.Models
{
    public partial class SpaceVehicleType : BaseEntity
    {
        public SpaceVehicleType()
        {
            SpaceVehicles = new HashSet<SpaceVehicle>();
        }

        public int? IdAstronomicalObject { get; set; }
        public int? IdCrew { get; set; }
        public int? IdCargo { get; set; }
        public string Name { get; set; } = null!;

        public virtual AstronomicalObject? IdAstronomicalObjectNavigation { get; set; }
        public virtual Cargo? IdCargoNavigation { get; set; }
        public virtual Crew? IdCrewNavigation { get; set; }
        public virtual ICollection<SpaceVehicle> SpaceVehicles { get; set; }

        public override string SelfDescription()
        {
            return $"I'm {Name}. I am the kind of the space vehicle with its special quality.";
        }

        public override string ShiftLength()
        {
            return $"I don't work.";
        }
    }
}
