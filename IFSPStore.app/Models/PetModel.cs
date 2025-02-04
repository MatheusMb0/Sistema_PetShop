
namespace IFSPStore.app.Models
{
    public class PetModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoPet { get; set; }
        public string Raca { get; set; }
        public DateOnly DataNascimento { get; set; }
        public float Peso { get; set; }
        public string Sexo { get; set; }
        public string Cor { get; set; }
        public string Descricao { get; set; }
        public string NomeCliente { get; set; }
        public int Cliente { get; set; }

    }
}
