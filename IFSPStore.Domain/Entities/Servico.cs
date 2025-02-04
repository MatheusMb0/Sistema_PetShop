using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Servico : BaseEntity<int>
    {
        public Servico()
        {
        }

        public Servico(int id, string nome, string descricao, float preco, string duracaoEstimada,
            string tipoServico, string disponibilidade, string requisitos, string materiais)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            DuracaoEstimada = duracaoEstimada;
            TipoServico = tipoServico;
            Disponibilidade = disponibilidade;
            Requisitos = requisitos;
            Materiais = materiais;
        }

        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public float? Preco { get; set; }
        public string? DuracaoEstimada { get; set; }
        public string? TipoServico { get; set; }
        public string? Disponibilidade { get; set; }
        public string? Requisitos { get; set; }
        public string? Materiais { get; set; }
    }

}