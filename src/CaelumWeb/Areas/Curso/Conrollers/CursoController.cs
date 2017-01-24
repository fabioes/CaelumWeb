using AutoMapper;
using Caelum.Infra.Dados;
using Caelum.Infra.Dados.Repositorio.Interfaces;
using CaelumWeb.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaelumWeb.Areas.Conrollers
{
    public class CursoController : Controller
    {
        private readonly IMapper mapper;
        private readonly ICursoRepositorio cursoRepositorio;
        public CursoController(IMapper _mapper, ICursoRepositorio _cursoRepositorio)
        {
            mapper = _mapper;
            cursoRepositorio = _cursoRepositorio;
        }

        // GET: /<controller>/
        public IActionResult Listar()
        {
            return View();
        }
        public IActionResult Inserir() => View();

        [HttpPost]
        public void Inserir(Curso curso)
        {
            if (ModelState.IsValid)
            {
                var cursosDTO = Mapper.Map<CursoDTO>(curso);
                cursoRepositorio.Salvar(cursosDTO);
                RedirectToAction("Listar");
            }
        }
    }
}
