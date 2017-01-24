using AutoMapper;
using Caelum.Infra.Dados;
using Caelum.Infra.Dados.Repositorio.Interfaces;
using CaelumWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaelumWeb.Areas.Conrollers
{
    [Area("Curso")]
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
            var cursosDTO = cursoRepositorio.Listar();
            var cursos = Mapper.Map<IEnumerable<Curso>>(cursosDTO);
            return View(cursos);
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
        [HttpPost]
        public void AtivarDesativarCurso(int id, bool ativo)
        {
            cursoRepositorio.AtivarDesativarCurso(id, ativo);
        }
    }
}
