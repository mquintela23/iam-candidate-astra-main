using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using IAMCandidateTest.Data;

namespace IAMCandidateTest
{
    public partial class _Default : Page
    {
        private ObjectType SelectedObjectType
        {
            get => (ObjectType)ViewState[nameof(SelectedObjectType)];
            set
            {
                if (value != null)
                {
                    ViewState[nameof(SelectedObjectType)] = value;
                }
                else
                {
                    ViewState.Remove(nameof(SelectedObjectType));
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ObjectTypeList.DataValueField = "Value";
                ObjectTypeList.DataTextField = "Text";
                ObjectTypeList.DataSource = GetPromptItem("-- Select Object Type --")
                    .Concat(ObjectType.All.Select(ot => new DropDownListItem() { Value = ot.ID.ToString(), Text = ot.Name }));
                ObjectTypeList.DataBind();
            }
        }

        protected void ObjectTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Level2.Visible = ObjectTypeList.SelectedIndex > 0;
            switch (ObjectTypeList.SelectedValue)
            {
                case "":
                    ObjectList.DataSource = Array.Empty<object>();
                    break;

                case "A":
                    var animals = Database.GetAnimals();
                    ObjectList.DataSource = GetPromptItem("-- Select Animal --")
                        .Concat(animals.Select(a => new DropDownListItem() { Value = a.ID.ToString(), Text = a.CommonName }));
                    break;

                case "M":
                    var minerals = Database.GetMinerals();
                    ObjectList.DataSource = GetPromptItem("-- Select Mineral --")
                        .Concat(minerals.Select(m => new DropDownListItem() { Value = m.ID.ToString(), Text = m.Name }));
                    break;

                case "V":
                    var vegetables = Database.GetVegetables();
                    ObjectList.DataSource = GetPromptItem("-- Select Vegetable --")
                        .Concat(vegetables.Select(v => new DropDownListItem() { Value = v.ID.ToString(), Text = v.Name }));
                    break;
            }
            ObjectList.DataBind();
        }

        protected void ObjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Level3.Visible = ObjectList.SelectedIndex > 0;

            Guid id = ObjectList.SelectedIndex > 0 ? Guid.Parse(ObjectList.SelectedValue) : default;

            switch (ObjectTypeList.SelectedValue)
            {
                case "A":
                    Animal animal = Database.GetAnimal(id);
                    AnimalDetails animalDetails = (AnimalDetails)LoadControl("~/AnimalDetails.ascx");
                    animalDetails.SelectedAnimal = animal;
                    DetailContainer.Controls.Add(animalDetails);
                    break;

                case "M":
                    Mineral mineral = Database.GetMineral(id);
                    MineralDetails mineralDetails = (MineralDetails)LoadControl("~/MineralDetails.ascx");
                    mineralDetails.SelectedMineral = mineral;
                    DetailContainer.Controls.Add(mineralDetails);
                    break;

                case "V":
                    Vegetable vegetable = Database.GetVegetable(id);
                    VegetableDetails vegetableDetails = (VegetableDetails)LoadControl("~/VegetableDetails.ascx");
                    vegetableDetails.SelectedVegetable = vegetable;
                    DetailContainer.Controls.Add(vegetableDetails);
                    break;
            }
        }

        private static IEnumerable<DropDownListItem> GetPromptItem(string prompt = null)
        {
            return Enumerable.Repeat(new DropDownListItem() { Value = "", Text = prompt ?? "--" }, 1).ToArray();
        }
    }
}
