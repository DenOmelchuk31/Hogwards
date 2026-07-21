using System;
using System.Collections.Generic;

namespace HogwardsApp.Models
{

    public partial class Wizard
    {
        public int WizardId { get; set; }

        public string Name { get; set; } = null!;

        public string House { get; set; } = null!;

        public string? BloodStatus { get; set; }

        public int Year { get; set; }

        public virtual ICollection<HousePoint> HousePoints { get; set; } = new List<HousePoint>();

        public virtual Wand? Wand { get; set; }
    }
}