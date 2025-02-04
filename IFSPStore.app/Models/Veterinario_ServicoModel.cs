
using IFSPStore.Domain.Entities;

namespace IFSPStore.app.Models
{
    public class Veterinario_ServicoModel
    {
        public int Id { get; set; }
        public int Veterinario { get; set; }
        public string NomeVeterinario { get; set; }
        public string NomeServico { get; set; }
        public int Servico { get; set; }

    }
}
