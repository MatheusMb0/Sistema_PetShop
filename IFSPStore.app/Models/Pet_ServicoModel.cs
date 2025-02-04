
using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class Pet_ServicoModel
    {
        public int Id { get; set; }
        public int Pet { get; set; }
        public string NomePet { get; set; }
        public string NomeServico { get; set; }
        public int Servico { get; set; }

    }
}
