using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Telefone { get; set; }
        public DateOnly DataCadastro { get; set; }
        public string NomeCidade { get; set; }
        public int Cidade { get; set; }

    }
}
