using System;
using System.Collections.Generic;

namespace HogwardsApp.Models
{

    public partial class Wand
    {
        public int WandId { get; set; }

        public string CoreMaterial { get; set; } = null!;

        public decimal Length { get; set; }

        public int WizardId { get; set; }

        public virtual Wizard Wizard { get; set; } = null!;
    }
}