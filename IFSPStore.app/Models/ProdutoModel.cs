
using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public DateOnly DataCompra { get; set; }
        public string UnidadeVenda { get; set; }
        public string Descricao { get; set; }
        public string NomeGrupo { get; set; }
        public string NomeFornecedor { get; set; }
        public int Grupo { get; set; }
        public int Fornecedor { get; set; }

    }
}
