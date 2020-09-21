using System;

namespace ProjetoBoletimApi.Models
{
    public class Materias
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Situacao { get; set; }
    }
}