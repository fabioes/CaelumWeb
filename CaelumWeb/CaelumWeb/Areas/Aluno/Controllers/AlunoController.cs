using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaelumWeb.Areas.Controllers
{
    [Area("Aluno")]
    public class AlunoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Listar()
        {
            var alunos = new List<dynamic>
            {

                new { Nome = "João da Silva", Cpf = "333.222.111-10", Endereco = "Rua Cataventos, 80" },
                new { Nome = "José Ferreira", Cpf = "444.333.222-20", Endereco = "Rua Paraíso, 80" }
            };

            ViewBag.Alunos = alunos;
            return View();
        }
    }
}
