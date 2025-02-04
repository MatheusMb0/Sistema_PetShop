using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto()
        {
        }

        public Produto(int id, string nome, float preco, int quantidade, DateOnly dataCompra, string unidadeVenda,
            string descricao, Grupo grupo, Fornecedor fornecedor)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            DataCompra = dataCompra;
            UnidadeVenda = unidadeVenda;
            Descricao = descricao;
            Grupo = grupo;
            Fornecedor = fornecedor;
        }

        public string? Nome { get; set; }
        public float? Preco { get; set; }
        public int? Quantidade { get; set; }
        public DateOnly? DataCompra { get; set; }
        public string? UnidadeVenda { get; set; }
        public string? Descricao { get; set; }
        public Grupo? Grupo { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}