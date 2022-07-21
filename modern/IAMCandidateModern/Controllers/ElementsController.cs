using Business.Data.Repository.Models;
using Business.Interfaces.Repository;
using IAMCandidateModern.Infrastructure.Extensions;
using IAMCandidateModern.Models;
using Microsoft.AspNetCore.Mvc;

namespace IAMCandidateModern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementsController : ControllerBase
    {

        private readonly ILogger<ElementsController> _logger;
        private readonly IGenericRepository<Mineral> _mineralRepository;
        private readonly IGenericRepository<Animal> _animalRepository;
        private readonly IGenericRepository<Vegetable> _vegetableRepository;

        public ElementsController(IGenericRepository<Mineral> mineralRepository, IGenericRepository<Animal> animalRepository, IGenericRepository<Vegetable> vegetableRepository, ILogger<ElementsController> logger)
        {
            _mineralRepository = mineralRepository;
            _animalRepository = animalRepository;
            _vegetableRepository = vegetableRepository;
            _logger = logger;
        }

        [HttpGet()]
        [Route("{value}")]
        public OkObjectResult OnSelectedCategory(string value)
        {
            IEnumerable<DropDownListItem> model = new List<DropDownListItem>();
            switch (value)
            {
                case "":
                    model = new List<DropDownListItem>();
                    break;

                case "A":
                    model = _animalRepository.GetAll().AsDropDownListItems();
                    break;

                case "M":
                    model = _mineralRepository.GetAll().AsDropDownListItems();
                    break;

                case "V":
                    model = _vegetableRepository.GetAll().AsDropDownListItems();
                    break;
            }

            return Ok(model);
        }

        [HttpGet()]
        [Route("category/{category}/categoryType/{id}")]
        public OkObjectResult OnSelectedCategoryType(string category, string id)
        {
            IEnumerable<Item> model = new List<Item>();
            switch (category)
            {
                case "":
                    model = new List<Item>();
                    break;

                case "A":
                    model = _animalRepository.GetById(Guid.Parse(id)).AsItemLIst();
                    break;

                case "M":
                    model = _mineralRepository.GetById(Guid.Parse(id)).AsItemLIst();
                    break;

                case "V":
                    model = _vegetableRepository.GetById(Guid.Parse(id)).AsItemLIst();
                    break;
            }

            return Ok(model);
        }

    }
}
