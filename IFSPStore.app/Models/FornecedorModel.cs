
using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class FornecedorModel
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string NomeCidade { get; set; }
        public int Cidade { get; set; }

    }
}
