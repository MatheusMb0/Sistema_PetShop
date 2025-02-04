using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public float Salario { get; set; }
        public DateOnly DataContratacao { get; set; }
        public string HorarioTrabalho { get; set; }
        public string Descricao { get; set; }
        public string NomeCidade { get; set; }
        public int Cidade { get; set; }

    }
}
