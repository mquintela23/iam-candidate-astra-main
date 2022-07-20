using System;

namespace IAMCandidateTest.Data
{
    public class Vegetable
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public string EdiblePart { get; set; }
        public bool IsBotanicalFruit { get; set; }
    }
}
