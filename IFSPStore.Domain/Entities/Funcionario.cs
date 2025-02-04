using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Funcionario : BaseEntity<int>
    {
        public Funcionario()
        {
        }

        public Funcionario(int id, string nome, string cpf, string rg, DateOnly dataNascimento,
            string endereco, string bairro, string telefone, string email, string cargo, float salario,
            DateOnly dataContratacao, string horarioTrabalho, string descricao, Cidade cidade)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            RG = rg;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Bairro = bairro;
            Telefone = telefone;
            Email = email;
            Cargo = cargo;
            Salario = salario;
            DataContratacao = dataContratacao;
            HorarioTrabalho = horarioTrabalho;
            Descricao = descricao;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Cargo { get; set; }
        public float? Salario { get; set; }
        public DateOnly? DataContratacao { get; set; }
        public string? HorarioTrabalho { get; set; }
        public string? Descricao { get; set; }
        public Cidade? Cidade { get; set; }
    }

}