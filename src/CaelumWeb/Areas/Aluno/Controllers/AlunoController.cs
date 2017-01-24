using AutoMapper;
using Caelum.Infra.Dados;
using Caelum.Infra.Dados.Repositorio.Interfaces;
using CaelumWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaelumWeb.Areas.Controllers
{C:\Users\fabio\Source\Repos\CaelumWeb\src\CaelumWeb\Areas\Aluno\Controllers\AlunoController.cs
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
            var _model = mapper.Map<IEnumerable<Aluno>>(alunos);
            return View(_model);
        }
        [HttpGet]
        //Nova notação
        public IActionResult Inserir() => View();

        [HttpPost]
        public void Inserir(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                var alunoDTO = mapper.Map<AlunoDTO>(aluno);
                alunoRepositorio.Salvar(alunoDTO);
            }
            RedirectToAction("Listar");
        }
    }
}
