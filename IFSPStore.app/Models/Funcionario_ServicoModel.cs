
using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class Funcionario_ServicoModel
    {
        public int Id { get; set; }
        public int Funcionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string NomeServico { get; set; }
        public int Servico { get; set; }
    }
}
