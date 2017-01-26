using AutoMapper;
using Caelum.Infra.Dados;
using Caelum.Infra.Dados.Repositorio.Interfaces;
using CaelumWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaelumWeb.Areas.Controllers
{
    [Area("Aluno")]
    public class AlunoController : Controller
    {
        // GET: /<controller>/
        //Comentar porque private readonly
        private readonly IMapper mapper;
        private readonly IAlunoRepositorio alunoRepositorio;
        public AlunoController(IMapper _mapper, IAlunoRepositorio _alunoRepositorio)
        {
            mapper = _mapper;
            alunoRepositorio = _alunoRepositorio;
        }
        public IActionResult Listar()
        {
            var alunos = alunoRepositorio.Listar();
            var alunosDTO = mapper.Map<IEnumerable<Aluno>>(alunos);
            return View(alunosDTO);
        }
        [HttpGet]
        //Nova notação
        public IActionResult Inserir() => View();

        [HttpPost]
        public IActionResult Inserir(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                var alunosDTO = mapper.Map<AlunoDTO>(aluno);
                alunoRepositorio.Salvar(alunosDTO);
            }
            return RedirectToAction("Listar");
        }
        [HttpPost]
        public void Deletar(int id)
        {
            var aluno = alunoRepositorio.ListarPorId(id);
            var alunoDTO = Mapper.Map<AlunoDTO>(aluno);
            alunoRepositorio.Deletar(alunoDTO);

        }
    }
}
