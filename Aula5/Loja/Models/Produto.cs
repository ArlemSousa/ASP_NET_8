namespace Loja.Models
{
    public class Produto
    {

        public int Id { get; set; }
        public string NomeProduto { get; set; } = string.Empty;

        public string Descricao { get; set;} = string.Empty;

        public int? Quantidade { get; set; }

        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(int id, string nomeProduto, string descricao, int? quantidade, double preco)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }
    }
}
