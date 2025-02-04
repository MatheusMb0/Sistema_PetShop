
using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class ServicoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string DuracaoEstimada { get; set; }
        public string TipoServico { get; set; }
        public string Disponibilidade { get; set; }
        public string Requisitos { get; set; }
        public string Materiais { get; set; }

    }
}
