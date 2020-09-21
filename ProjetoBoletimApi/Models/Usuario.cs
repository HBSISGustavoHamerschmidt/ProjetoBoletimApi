namespace ProjetoBoletimApi.Models
{
    public class Usuario : Pessoa
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
    }
}