using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Veterinario_Servico : BaseEntity<int>
    {
        public Veterinario_Servico()
        {
        }

        public Veterinario_Servico(int id, Veterinario veterionario, Servico servico)
        {
            Id = id;
            Veterinario = veterionario;
            Servico = servico;
        }

        public Veterinario? Veterinario { get; set; }
        public Servico? Servico { get; set; }
    }
}