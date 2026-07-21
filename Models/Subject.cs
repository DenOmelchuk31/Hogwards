using System;
using System.Collections.Generic;

namespace HogwardsApp.Models
{

    public partial class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Teacher { get; set; } = null!;

        public string? Description { get; set; }

        public virtual ICollection<HousePoint> HousePoints { get; set; } = new List<HousePoint>();
    }
}
