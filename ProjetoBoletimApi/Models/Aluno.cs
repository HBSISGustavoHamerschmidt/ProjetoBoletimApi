using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace ProjetoBoletimApi.Models
{
    public class Aluno 
    {
        public int Id { get; set; }
        
        public DateTime DataNascimento { get; set; }

        public Curso Curso { get; set; }
    }
}