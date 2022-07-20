using Business.Data.Repository;
using Business.Data.Repository.Models;

namespace Business.Core.Repository
{
    public class MineralRepository : GenericRepository<Mineral>
    {
        public MineralRepository(MoDbContext context) : base(context)
        {
        }

        public Mineral GetById(Guid id)
        {
            return Context.Minerals.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Mineral> GetAll()
        {
            return Context.Minerals.Select(p => p);
        }
    }
}
