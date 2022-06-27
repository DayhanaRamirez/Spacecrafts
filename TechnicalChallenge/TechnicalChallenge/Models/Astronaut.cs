using System;
using System.Collections.Generic;

namespace TechnicalChallenge.Models
{
    public partial class Astronaut : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int Age { get; set; }
        public string Sex { get; set; } = null!;
        public double Weight { get; set; }
        public int IdCrew { get; set; }

        public virtual Crew IdCrewNavigation { get; set; } = null!;

        public override string SelfDescription()
        {
            return $"I'm {Name}. I am an astronaut, a person trained, equipped, and deployed by a human spaceflight program to serve as a commander or crew member aboard a spacecraft.";
        }

        public override string ShiftLength()
        {
            return $"I work 10 hours per day.";
        }
    }
}
