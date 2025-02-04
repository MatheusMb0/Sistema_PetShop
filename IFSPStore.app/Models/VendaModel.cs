
using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public float ValorTotalFinal { get; set; }
        public string EnderecoEntrega { get; set; }
        public string BairroEntrega { get; set; }
        public string CidadeEntrega { get; set; }
        public string NomeCliente { get; set; }
        public int Cliente { get; set; }

    }

    public class VendaItemModel
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal { get; set; }
        public int Venda { get; set; }
        public int Produto { get; set; }
        public string NomeProduto { get; set; }
        public string NomeServico { get; set; }
        public int Servico { get; set; }

    }
}
