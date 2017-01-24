﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Caelum.Infra.Dados
{
    public class AlunoDTO
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public List<CursoDTO> Cursos { get; set; }
    }
}