using Business.Data.Repository.Models;
using IAMCandidateModern.Models;

namespace IAMCandidateModern.Infrastructure.Extensions
{
    public static class EntityExtension
    {
        public static IEnumerable<DropDownListItem> AsDropDownListItems(this IEnumerable<Mineral> inputList)
        {
            List<DropDownListItem> outList = new List<DropDownListItem>();
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


        public static IEnumerable<DropDownListItem> AsDropDownListItems(this IEnumerable<Animal> inputList)
        {
            List<DropDownListItem> outList = new List<DropDownListItem>();
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

        public static IEnumerable<DropDownListItem> AsDropDownListItems(this IEnumerable<Vegetable> inputList)
        {
            List<DropDownListItem> outList = new List<DropDownListItem>();
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

    }
}
