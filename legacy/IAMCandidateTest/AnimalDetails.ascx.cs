using System.Web.UI;
using IAMCandidateTest.Data;

namespace IAMCandidateTest
{
    public partial class AnimalDetails : UserControl
    {
        public Animal SelectedAnimal
        {
            get => (Animal)ViewState[nameof(SelectedAnimal)];
            set
            {
                if (value != null)
                    ViewState[nameof(SelectedAnimal)] = value;
                else
                    ViewState.Remove(nameof(SelectedAnimal));
            }
        }
    }
}
