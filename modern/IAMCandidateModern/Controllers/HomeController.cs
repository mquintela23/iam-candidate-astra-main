using System.Diagnostics;
using IAMCandidateModern.Models;
using Microsoft.AspNetCore.Mvc;
using IAMCandidateModern.Interfaces.FactoryClass;

namespace IAMCandidateModern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUiModelFactory _uiFactory;

        public HomeController(ILogger<HomeController> logger, IUiModelFactory uiFactory)
        {
            _logger = logger;
            _uiFactory = uiFactory;
        }

        public IActionResult Index()
        {
            ViewBag.CategoryList = _uiFactory.MakeDropDownList().ToList();
            return View();
        }

        public IActionResult ReleaseNotes()
        {
            ViewBag.CategoryList = _uiFactory.MakeDropDownList().ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}