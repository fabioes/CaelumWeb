using Caelum.Infra.Dados.Repositorio.Interfaces;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaelumWeb.Areas.Controllers
{
    public class AlunoController : Controller
    {
        // GET: /<controller>/
        //Comentar porque private readonly
        private readonly IAlunoRepositorio alunoRepositorio;
        public AlunoController(IAlunoRepositorio _alunoRepositorio)
        {
            alunoRepositorio = _alunoRepositorio;
        }
        public IActionResult Listar()
        {
            ViewBag.Aluno = alunoRepositorio.Listar();
            return View(ViewBag.Aluno);
        }
    }
}
