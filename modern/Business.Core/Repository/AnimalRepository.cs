using Business.Data.Repository;
using Business.Data.Repository.Models;

namespace Business.Core.Repository
{
    public class AnimalRepository : GenericRepository<Animal>
    {
        public AnimalRepository(MoDbContext context) : base(context)
        {
        }

        public Animal GetById(Guid id)
        {
            return Context.Animals.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Animal> GetAll()
        {
            return Context.Animals.Select(p => p);
        }
 
    }
}
