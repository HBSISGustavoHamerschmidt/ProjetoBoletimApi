using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ProjetoBoletimApi.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Materias> Materias { get; set; }
        public bool Ativo { get; set; }
    }
}