using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Fornecedor : BaseEntity<int>
    {
        public Fornecedor()
        {
        }

        public Fornecedor(int id, string nomeFantasia, string razaoSocial, string cnpj, string email, string senha,
            string telefone, string endereco, string bairro, DateTime dataCadastro, Cidade cidade)
        {
            Id = id;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
            DataCadastro = dataCadastro;
            Cidade = cidade;
        }

        public string? NomeFantasia { get; set; }
        public string? RazaoSocial { get; set; }
        public string? CNPJ { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public DateTime? DataCadastro { get; set; }
        public Cidade? Cidade { get; set; }
    }

}