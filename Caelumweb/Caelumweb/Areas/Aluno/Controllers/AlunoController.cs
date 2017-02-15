using AutoMapper;
using Caelum.Infra.Dados.Repositorio.Interfaces;
using Caelumweb.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Caelumweb.Areas.Aluno.Controllers
{
    [Area("Aluno")]    
    [Authorize]
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio alunoRepositorio;
        private readonly IMapper mapper;

        public AlunoController(IAlunoRepositorio _alunoRepositorio, IMapper _mapper)
        {
            alunoRepositorio = _alunoRepositorio;
            mapper = _mapper;
        }
        // GET: /<controller>/
        public IActionResult Listar()
        {
            var lista_alunos = alunoRepositorio.Listar();
            var lista_alunos_view_model = mapper.Map<IEnumerable<AlunoViewModel>>(lista_alunos);
            return View(lista_alunos_view_model);
        }

        public IActionResult Inserir() => View();

        [HttpPost]
        public IActionResult Inserir(AlunoViewModel alunoViewModel)
        {
            if (ModelState.IsValid)
            {
                var aluno = mapper.Map<Caelum.Infra.Dados.Aluno>(alunoViewModel);
                alunoRepositorio.Salvar(aluno);
            }
            return RedirectToAction("Listar");
        }
        [HttpPost]
        public IActionResult Deletar(int id)
        {
            var aluno = alunoRepositorio.ListarPorId(id);
            alunoRepositorio.Deletar(aluno);
            return RedirectToAction("Listar");
        }
    }
}
