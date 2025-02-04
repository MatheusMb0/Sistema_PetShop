using IFSPStore.Domain.Base;
using System.Text.Json.Serialization;

namespace IFSPStore.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda()
        {
            Itens = new List<VendaItem>();
        }

        public Venda(int id, DateTime data, float valorTotalFinal, string enderecoEntrega, string bairroEntrega,
            string cidadeEntrega, List<VendaItem> itens, Cliente cliente)
        {
            Id = id;
            Data = data;
            ValorTotalFinal = valorTotalFinal;
            EnderecoEntrega = enderecoEntrega;
            BairroEntrega = bairroEntrega;
            CidadeEntrega = cidadeEntrega;
            Cliente = cliente;
            Itens = itens;
        }
        public DateTime? Data { get; set; }
        public float? ValorTotalFinal { get; set; }
        public string? EnderecoEntrega { get; set; }
        public string? BairroEntrega { get; set; }
        public string? CidadeEntrega { get; set; }
        public Usuario? Usuario { get; set; }
        public Cliente? Cliente { get; set; }
        public List<VendaItem> Itens { get; set; }


    }

    public class VendaItem : BaseEntity<int>
    {
        public VendaItem()
        {

        }

        public VendaItem(int id, Venda venda, Produto produto, Servico servico, int quantidade, float valorUnitario, float valorTotal)
        {
            Id = id;
            Venda = venda;
            Produto = produto;
            Servico = servico;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
        }
        [JsonIgnore]
        public Venda? Venda { get; set; }
        public Produto? Produto { get; set; }
        public Servico? Servico { get; set; }
        public int? Quantidade { get; set; }
        public float? ValorUnitario { get; set; }
        public float? ValorTotal { get; set; }

    }
}