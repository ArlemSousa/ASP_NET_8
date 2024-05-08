using System.Security.Principal;

namespace Loja.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Email { get; set; }

        public Cliente(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public Cliente()
        {
        }
    }
}
