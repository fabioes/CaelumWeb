﻿
using System.ComponentModel.DataAnnotations;

namespace Caelum.Infra.Dados
{
    public class CursoDTO
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}