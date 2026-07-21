using System;
using System.Collections.Generic;

namespace HogwardsApp.Models
{

    public partial class HousePoint
    {
        public int Id { get; set; }

        public int WizardId { get; set; }

        public int SubjectId { get; set; }

        public int Points { get; set; }

        public DateTime? DateRecorded { get; set; }

        public virtual Subject Subject { get; set; } = null!;

        public virtual Wizard Wizard { get; set; } = null!;
    }
}