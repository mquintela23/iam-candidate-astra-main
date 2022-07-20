using System;

namespace IAMCandidateTest.Data
{
    [Serializable]
    public class Animal
    {
        public Guid ID { get; set; }
        public string CommonName { get; set; }

        // Basic attributes
        public int LegCount { get; set; }
        public int WingCount { get; set; }
        public bool CanFly { get; set; }

        // Taxonomy
        // Animals starts at "Life" > Domain "Eukaryota" > Kingdom "Animalia" so those are implied.
        public string TaxPhylum { get; set; }
        public string TaxClass { get; set; }
        public string TaxOrder { get; set; }
        public string TaxFamily { get; set; }
        public string TaxGenus { get; set; }
        public string TaxSpecies { get; set; }
    }
}
