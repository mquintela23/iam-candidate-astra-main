using IAMCandidateModern.Interfaces.FactoryClass;
using IAMCandidateModern.Models;

namespace IAMCandidateModern.Infrastructure.FactoryClass
{
    public class UiModelFactory : IUiModelFactory
    {
        public IEnumerable<DropDownListItem> MakeDropDownList()
        {
            return new List<DropDownListItem>
            {
                new() { Text = "Animal", Value = "A"}, 
                new() { Text = "Vegetable", Value = "V" },
                new() { Text = "Mineral", Value = "M" }
            };
        }
    }

 
}
