using Business.Data.Repository;
using Business.Data.Repository.Models;

namespace Business.Core.Repository
{
    public class VegetableRepository : GenericRepository<Vegetable>
    {
        public VegetableRepository(MoDbContext context) : base(context)
        {
        }

        public Vegetable GetById(Guid id)
        {
            return Context.Vegetables.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Vegetable> GetAll()
        {
            return Context.Vegetables.Select(p => p);
        }
    }
}
