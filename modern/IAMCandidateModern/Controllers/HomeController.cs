using System.Diagnostics;
using Business.Data.Repository.Models;
using Business.Interfaces.Repository;
using IAMCandidateModern.Infrastructure.Extensions;
using IAMCandidateModern.Models;
using Microsoft.AspNetCore.Mvc;
using IAMCandidateModern.Interfaces.FactoryClass;

namespace IAMCandidateModern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUiModelFactory _uiFactory;
        private readonly IGenericRepository<Mineral> _mineralRepository;
        private readonly IGenericRepository<Animal> _animalRepository;
        private readonly IGenericRepository<Vegetable> _vegetableRepository;

        public HomeController(ILogger<HomeController> logger, IUiModelFactory uiFactory, IGenericRepository<Mineral> mineralRepository, IGenericRepository<Vegetable> vegetableRepository, IGenericRepository<Animal> animalRepository)
        {
            _logger = logger;
            _uiFactory = uiFactory;
            _mineralRepository = mineralRepository;
            _vegetableRepository = vegetableRepository;
            _animalRepository = animalRepository;
        }

        public IActionResult Index()
        {
            ViewBag.CategoryList = _uiFactory.MakeDropDownList().ToList();
            return View();
        }

        [HttpGet()]
        [Route("OnSelectedDropDown/{value}")]
        public JsonResult OnSelectedDropDown(string value)
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

            return Json(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}