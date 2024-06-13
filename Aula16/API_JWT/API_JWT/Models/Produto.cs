using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_JWT.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public int ProdutoId { get; set; }
        [Required]
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemUrl { get; set; }
        public int Estoque { get; set; }

    }
}
