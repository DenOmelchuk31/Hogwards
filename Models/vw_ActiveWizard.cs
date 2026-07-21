using System;
using System.Collections.Generic;
using System.Text;

namespace HogwardsApp.Models
{
    public class vw_ActiveWizard
    {
        public int WizardId { get; set; }

        public string Name { get; set; } = null!;
        public string House { get; set; } = null!;
        public string? BloodStatus { get; set; } = null!;

    }
}