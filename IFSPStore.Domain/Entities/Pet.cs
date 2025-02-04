using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Pet : BaseEntity<int>
    {
        public Pet()
        {
        }

        public Pet(int id, string nome, string tipoPet, string raca, DateOnly dataNascimento,
            float peso, string sexo, string cor, string descricao, Cliente cliente)
        {
            Id = id;
            Nome = nome;
            TipoPet = tipoPet;
            Raca = raca;
            DataNascimento = dataNascimento;
            Peso = peso;
            Sexo = sexo;
            Cor = cor;
            Descricao = descricao;
            Cliente = cliente;
        }

        public string? Nome { get; set; }
        public string? TipoPet { get; set; }
        public string? Raca { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public float? Peso { get; set; }
        public string? Sexo { get; set; }
        public string? Telefone { get; set; }
        public string? Cor { get; set; }
        public string? Descricao { get; set; }
        public Cliente? Cliente { get; set; }
    }
}