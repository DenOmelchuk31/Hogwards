using System;
using System.Collections.Generic;

namespace HogwardsApp.Models
{

    public partial class VGryffindorSquad
    {
        public int Id { get; set; }

        public string GryffindorStudent { get; set; } = null!;

        public string? BloodStatus { get; set; }

        public string CoreMaterial { get; set; } = null!;

        public decimal WandLength { get; set; }
    }
}
