using System;
using System.Collections.Generic;

namespace TechnicalChallenge.Models
{
    public partial class AstronomicalObject : BaseEntity
    {
        public AstronomicalObject()
        {
            SpaceVehicleTypes = new HashSet<SpaceVehicleType>();
        }

        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;

        public virtual ICollection<SpaceVehicleType> SpaceVehicleTypes { get; set; }

        public override string SelfDescription()
        {
            return $"I'm {Name}. I am an astronomical object, a naturally occurring physical entity, association, or structure that exists in the observable universe.";
        }

        public override string ShiftLength()
        {
            return $"I work the same hours as my space vehicle.";
        }
    }
}
