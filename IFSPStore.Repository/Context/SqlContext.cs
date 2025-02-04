using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;


namespace IFSPStore.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated(); 
        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaItem> VendaItens { get; set; }
        public DbSet<Pet_Servico> Pet_Servicos { get; set; }
        public DbSet<Funcionario_Servico> Funcionario_Servicos { get; set; }
        public DbSet<Veterinario_Servico> Veterinario_Servicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Pet>(new PetMap().Configure);
            modelBuilder.Entity<Fornecedor>(new FornecedorMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Grupo>(new GrupoMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<Veterinario>(new VeterinarioMap().Configure);
            modelBuilder.Entity<Servico>(new ServicoMap().Configure);
            modelBuilder.Entity<Venda>(new VendaMap().Configure);
            modelBuilder.Entity<VendaItem>(new VendaItemMap().Configure);
            modelBuilder.Entity<Pet_Servico>(new Pet_ServicoMap().Configure);
            modelBuilder.Entity<Funcionario_Servico>(new Funcionario_ServicoMap().Configure);
            modelBuilder.Entity<Veterinario_Servico>(new Veterinario_ServicoMap().Configure);
        }
    }
}