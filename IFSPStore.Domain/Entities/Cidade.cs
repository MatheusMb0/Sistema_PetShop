using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public Cidade()
        {
        }

        public Cidade(int id, string nome, string estado)
        {
            Id = id;
            Nome = nome;
            Estado = estado;
        }

        public string? Nome { get; set; }
        public string? Estado { get; set; }
    }
}