using System.Web.UI;
using IAMCandidateTest.Data;

namespace IAMCandidateTest
{
    public partial class MineralDetails : UserControl
    {
        public Mineral SelectedMineral
        {
            get => (Mineral)ViewState[nameof(SelectedMineral)];
            set
            {
                if (value != null)
                    ViewState[nameof(SelectedMineral)] = value;
                else
                    ViewState.Remove(nameof(SelectedMineral));
            }
        }
    }
}
