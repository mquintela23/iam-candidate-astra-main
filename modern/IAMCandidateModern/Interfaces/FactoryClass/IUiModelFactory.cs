using IAMCandidateModern.Models;

namespace IAMCandidateModern.Interfaces.FactoryClass;

public interface IUiModelFactory
{
    IEnumerable<DropDownListItem> MakeDropDownList();
}