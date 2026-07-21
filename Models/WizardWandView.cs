using Microsoft.EntityFrameworkCore;

namespace HogwardsApp.Models
{
    [Keyless]
    public class WizardWandView
    {
        public string WizardName { get; set; } = null!;
        public string House { get; set; } = null!;
        public string WandMaterial { get; set; } = null!;
    }
}