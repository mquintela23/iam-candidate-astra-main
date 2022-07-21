using Business.Data.Repository.Models;
using IAMCandidateModern.Models;

namespace IAMCandidateModern.Infrastructure.Extensions
{
    public static class EntityExtension
    {
        public static IEnumerable<DropDownListItem> AsDropDownListItems(this IEnumerable<Mineral> inputList)
        {
            List<DropDownListItem> outList = new List<DropDownListItem> { new() { Text = "-- Select Mineral -", Value = "-" } };
            foreach (var item in inputList)
            {
                outList.Add(new DropDownListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            return outList;
        }

        public static IEnumerable<Item> AsItemLIst(this Mineral input)
        {
            List<Item> outList = new List<Item>
            {
                new() { Header = "Hardness", Description = input.Hardness.ToString() },
                new() { Header = "Luster", Description = input.Luster },
                new() { Header = "Color", Description = input.Color},
                new() { Header = "Streak", Description = input.Color },
                new() { Header = "Specific Gravity",Description = input.SpecificGravity.ToString() },
                new() { Header = "Diaphaneity", Description =input.Diaphaneity }
            };
            return outList;
        }

        public static IEnumerable<DropDownListItem> AsDropDownListItems(this IEnumerable<Animal> inputList)
        {
            List<DropDownListItem> outList = new List<DropDownListItem> {new() {Text = "-- Select Animal --", Value = ""}};
            foreach (var item in inputList)
            {
                outList.Add(new DropDownListItem
                {
                    Text = item.CommonName,
                    Value = item.Id.ToString()
                });
            }
            return outList;
        }

        public static IEnumerable<Item> AsItemLIst(this Animal input)
        {
            List<Item> outList = new List<Item>
            {
                new() { Header = "Legs", Description = input.LegCount.ToString() },
                new() { Header = "Wings", Description = input.WingCount.ToString() },
                new() { Header = "Flight capable?", Description = input.CanFly ? "Yes" : "No" },
                new() { Header = "Taxonomy", Description = $"{input.TaxPhylum} {input.TaxClass} <br/> {input.TaxOrder} <br/> {input.TaxFamily} <br/> {input.TaxGenus} <br/>{input.TaxSpecies}"  }
            };
            return outList;
        }

        public static IEnumerable<DropDownListItem> AsDropDownListItems(this IEnumerable<Vegetable> inputList)
        {
            List<DropDownListItem> outList = new List<DropDownListItem> { new() { Text = "-- Select Vegetable --", Value = "" } };
            foreach (var item in inputList)
            {
                outList.Add(new DropDownListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            return outList;
        }

        public static IEnumerable<Item> AsItemLIst(this Vegetable input)
        {
            List<Item> outList = new List<Item>
            {
                new() { Header = "Edible Part:", Description = input.EdiblePart },
                new() { Header = "Vegetable is botanically classified as a fruit?", Description = input.IsBotanicalFruit ? "Yes" : "No"  }
            };
            return outList;
        }

    }
}
