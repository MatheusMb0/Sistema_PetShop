using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Veterinario : BaseEntity<int>
    {
        public Veterinario()
        {
        }

        public Veterinario(int id, string nome, string cpf, string crmv, string especializacao, string email,
            string telefone, string endereco, string bairro, string horarioTrabalho, float salario,
            DateOnly dataContratacao, string descricao, Cidade cidade)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            CRMV = crmv;
            Especializacao = especializacao;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
            HorarioTrabalho = horarioTrabalho;
            Salario = salario;
            DataContratacao = dataContratacao;
            Descricao = descricao;
            Cidade = cidade; 
        }

        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? CRMV { get; set; }
        public string? Especializacao { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? HorarioTrabalho { get; set; }
        public float? Salario { get; set; }
        public DateOnly? DataContratacao { get; set; }
        public string? Descricao { get; set; }
        public Cidade? Cidade { get; set; }
    }

}