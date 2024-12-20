using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet.Infrastructure;
using myfinance_web_dotnet.Models;
using System.Diagnostics;

namespace myfinance_web_dotnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private MyFinanceDBContext _myFinanceDBContext;

        public HomeController(ILogger<HomeController> logger,
            MyFinanceDBContext myFinanceDBContext)
        {
            _logger = logger;
            _myFinanceDBContext = myFinanceDBContext;
        }

        public IActionResult Index()
        {
            var teste = _myFinanceDBContext.PlanoContas.FirstOrDefault();
            ViewBag.TESTE = teste.Descricao;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
