using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {
        }

        public Usuario(int id, string email, string senha)
        {
            Id = id;
            Email = email;
            Senha = senha;
        }

        public string? Email { get; set; }
        public string? Senha { get; set; }
    }

}