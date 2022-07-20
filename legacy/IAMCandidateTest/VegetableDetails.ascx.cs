using System.Web.UI;
using IAMCandidateTest.Data;

namespace IAMCandidateTest
{
    public partial class VegetableDetails : UserControl
    {
        public Vegetable SelectedVegetable
        {
            get => (Vegetable)ViewState[nameof(SelectedVegetable)];
            set
            {
                if (value != null)
                    ViewState[nameof(SelectedVegetable)] = value;
                else
                    ViewState.Remove(nameof(SelectedVegetable));
            }
        }
    }
}
