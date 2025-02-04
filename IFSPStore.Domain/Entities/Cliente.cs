using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente()
        {
        }

        public Cliente(int id, string nome, string cpf, string email, string senha,
            string endereco, string bairro, DateOnly dataNascimento, string telefone, DateOnly dataCadastro, 
            Cidade cidade)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Endereco = endereco;
            Bairro = bairro;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            DataCadastro = dataCadastro;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public string? Telefone { get; set; }
        public DateOnly? DataCadastro { get; set; }
        public Cidade? Cidade { get; set; }
    }

}