using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Pet_Servico : BaseEntity<int>
    {
        public Pet_Servico()
        {
        }

        public Pet_Servico(int id, Pet pet, Servico servico)
        {
            Id = id;
            Pet = pet;
            Servico = servico;
        }

        public Pet? Pet { get; set; }
        public Servico? Servico { get; set; }
    }
}