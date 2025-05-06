using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Teste01.Models;

namespace Teste01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy() // esse metodo "IActionResult" e o responsavel por todas as ações, e um super tipo, um tipo generico. esse tipo generico se desdobra em varios tipos especificos.
        {

            ViewData["email"] = "sou um comedia"; // estou substituindo o valor da chave "email" na pagina privacy
            ViewData["professor"] = "Nelio Alves";// estou substituindo o valor da chave "professor" na pagina privacy

            return View(); // retorna para a pagina privacy
            // se eu apagar o "view" e apertar o "ctrl + espaço" vai abrir uma janela, entao e so buscar a opção " mostrar metodos " e poderei visualizar todos os metodos que posso usar
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
