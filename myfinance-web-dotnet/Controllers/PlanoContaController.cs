using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet.Infrastructure;
using myfinance_web_dotnet.Models;
using System.Diagnostics;
using myfinance_web_dotnet.Services;
using myfinance_web_dotnet.Domain;

namespace myfinance_web_dotnet.Controllers
{
    [Route("[controller]")]
    public class PlanoContaController : Controller
    {
        private readonly IPlanoContaService _planoContaService;

        public PlanoContaController(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }
        [Route("Index")]

        public IActionResult Index()
        {
            ViewBag.Lista = _planoContaService.ListarRegistros();
            return View();
        }

        [HttpPost]
        [HttpGet]
        [Route("Cadastro")]
        [Route("Cadastro/{id}")]
        public IActionResult Cadastro(PlanoContaModel? model, int? id)
        {

            if(id != null && !ModelState.IsValid) //Carregar o registro em tela
            {
                var registro = _planoContaService.RetornarRegistro((int)id);

                var planoContaModel = new PlanoContaModel(){
                
                    Id = registro.Id,
                    Descricao = registro.Descricao,
                    Tipo = registro.Tipo
                };

                return View(planoContaModel);
            }
            else if (model != null && ModelState.IsValid)
                {
                    var planoConta = new PlanoContas
                    {
                        Id = model.Id,
                        Descricao = model.Descricao,
                        Tipo = model.Tipo
                    };
                    _planoContaService.Salvar(planoConta);

                    return RedirectToAction("Index");

                }
            else {
                return View();
                
            }
        }
        [HttpGet]
        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _planoContaService.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
