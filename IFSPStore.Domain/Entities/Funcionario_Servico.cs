using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Funcionario_Servico : BaseEntity<int>
    {
        public Funcionario_Servico()
        {
        }

        public Funcionario_Servico(int id, Funcionario funcionario, Servico servico)
        {
            Id = id;
            Funcionario = funcionario;
            Servico = servico;
        }

        public Funcionario? Funcionario { get; set; }
        public Servico? Servico { get; set; }
    }
}