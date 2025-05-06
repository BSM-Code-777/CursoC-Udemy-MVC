using Microsoft.AspNetCore.Mvc;
using Teste01.Models;

namespace Teste01.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> list = new List<Departamento>();  // fazendo uma lista e uma instancia de deparatamento
            list.Add(new Departamento { id = 1, nome = "eletronico" }); // adicionanando na lista
            list.Add(new Departamento { id = 2, nome = "fashion" }); // adicionanando na lista

            return View(list); // retornando lista na view
        }
    }
}
