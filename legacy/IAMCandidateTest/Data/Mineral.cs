using System;

namespace IAMCandidateTest.Data
{
    public class Mineral
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public decimal Hardness { get; set; }
        public string Luster { get; set; }
        public string Color { get; set; }
        public string Streak { get; set; }
        public decimal SpecificGravity { get; set; }
        public string Diaphaneity { get; set; }
    }
}
