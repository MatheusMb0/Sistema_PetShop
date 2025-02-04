using AutoMapper;
using IFSPStore.app.Base;
using IFSPStore.app.Cadastros;
using IFSPStore.app.Models;
using IFSPStore.app.Outros;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using System.Configuration.Internal;

namespace IFSPStore.app.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco_de_dados
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");

            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(100);
                    opt.EnableRetryOnFailure();
                });
            });

            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Pet>, BaseRepository<Pet>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario>>();
            Services.AddScoped<IBaseRepository<Fornecedor>, BaseRepository<Fornecedor>>();
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Grupo>, BaseRepository<Grupo>>();
            Services.AddScoped<IBaseRepository<Venda>, BaseRepository<Venda>>();
            Services.AddScoped<IBaseRepository<VendaItem>, BaseRepository<VendaItem>>();
            Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            Services.AddScoped<IBaseRepository<Servico>, BaseRepository<Servico>>();
            Services.AddScoped<IBaseRepository<Veterinario>, BaseRepository<Veterinario>>();
            Services.AddScoped<IBaseRepository<Veterinario_Servico>, BaseRepository<Veterinario_Servico>>();
            Services.AddScoped<IBaseRepository<Pet_Servico>, BaseRepository<Pet_Servico>>();
            Services.AddScoped<IBaseRepository<Funcionario_Servico>, BaseRepository<Funcionario_Servico>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Pet>, BaseService<Pet>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();
            Services.AddScoped<IBaseService<Fornecedor>, BaseService<Fornecedor>>();
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Grupo>, BaseService<Grupo>>();
            Services.AddScoped<IBaseService<Venda>, BaseService<Venda>>();
            Services.AddScoped<IBaseService<VendaItem>, BaseService<VendaItem>>();
            Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            Services.AddScoped<IBaseService<Servico>, BaseService<Servico>>();
            Services.AddScoped<IBaseService<Veterinario>, BaseService<Veterinario>>();
            Services.AddScoped<IBaseService<Veterinario_Servico>, BaseService<Veterinario_Servico>>();
            Services.AddScoped<IBaseService<Pet_Servico>, BaseService<Pet_Servico>>();
            Services.AddScoped<IBaseService<Funcionario_Servico>, BaseService<Funcionario_Servico>>();
            #endregion

            #region Formulários
            Services.AddTransient<LoginUsuario, LoginUsuario>();
            Services.AddTransient<LoginCliente, LoginCliente>();
            Services.AddTransient<LoginFornecedor, LoginFornecedor>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroPet, CadastroPet>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroFuncionario, CadastroFuncionario>();
            Services.AddTransient<CadastroFornecedor, CadastroFornecedor>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroGrupo, CadastroGrupo>();
            Services.AddTransient<CadastroVenda, CadastroVenda>();
            Services.AddTransient<CadastroProduto, CadastroProduto>();
            Services.AddTransient<CadastroServico, CadastroServico>();
            Services.AddTransient<CadastroVeterinario, CadastroVeterinario>();
            Services.AddTransient<CadastroVeterinario_Servico, CadastroVeterinario_Servico>();
            Services.AddTransient<CadastroPet_Servico, CadastroPet_Servico>();
            Services.AddTransient<CadastroFuncionario_Servico, CadastroFuncionario_Servico>();
            #endregion

            #region Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cidade, CidadeModel>();
                config.CreateMap<Cliente, ClienteModel>()
                .ForMember(c => c.Cidade, c => c.MapFrom(x => x.Cidade!.Id))
                .ForMember(c => c.NomeCidade, c => c.MapFrom(x => $"{x.Cidade.Nome}"));

                config.CreateMap<Cidade, CidadeModel>();
                config.CreateMap<Fornecedor, FornecedorModel>()
                .ForMember(c => c.Cidade, c => c.MapFrom(x => x.Cidade!.Id))
                .ForMember(c => c.NomeCidade, c => c.MapFrom(x => $"{x.Cidade.Nome}"));

                config.CreateMap<Cidade, CidadeModel>();
                config.CreateMap<Funcionario, FuncionarioModel>()
                .ForMember(c => c.Cidade, c => c.MapFrom(x => x.Cidade!.Id))
                .ForMember(c => c.NomeCidade, c => c.MapFrom(x => $"{x.Cidade.Nome}"));

                config.CreateMap<Cidade, CidadeModel>();
                config.CreateMap<Veterinario, VeterinarioModel>()
                .ForMember(c => c.Cidade, c => c.MapFrom(x => x.Cidade!.Id))
                .ForMember(c => c.NomeCidade, c => c.MapFrom(x => $"{x.Cidade.Nome}"));

                config.CreateMap<Cliente, ClienteModel>();
                config.CreateMap<Pet, PetModel>()
                .ForMember(c => c.Cliente, c => c.MapFrom(x => x.Cliente!.Id))
                .ForMember(c => c.NomeCliente, c => c.MapFrom(x => $"{x.Cliente.Nome}"));

                config.CreateMap<Servico, ServicoModel>();
                config.CreateMap<Grupo, GrupoModel>();
                config.CreateMap<Usuario, UsuarioModel>();

                config.CreateMap<Produto, ProdutoModel>()
                .ForMember(c => c.Grupo, c => c.MapFrom(x => x.Grupo!.Id))
                .ForMember(c => c.Fornecedor, c => c.MapFrom(x => x.Fornecedor!.Id))
                .ForMember(c => c.NomeGrupo, c => c.MapFrom(x => $"{x.Grupo.Nome}"))
                .ForMember(c => c.NomeFornecedor, c => c.MapFrom(x => $"{x.Fornecedor.NomeFantasia}"));

                config.CreateMap<Pet_Servico, Pet_ServicoModel>()
                .ForMember(c => c.Servico, c => c.MapFrom(x => x.Servico!.Id))
                .ForMember(c => c.Pet, c => c.MapFrom(x => x.Pet!.Id))
                .ForMember(c => c.NomeServico, c => c.MapFrom(x => $"{x.Servico.Nome}"))
                .ForMember(c => c.NomePet, c => c.MapFrom(x => $"{x.Pet.Nome}"));

                config.CreateMap<Veterinario_Servico, Veterinario_ServicoModel>()
                .ForMember(c => c.Servico, c => c.MapFrom(x => x.Servico!.Id))
                .ForMember(c => c.Veterinario, c => c.MapFrom(x => x.Veterinario!.Id))
                .ForMember(c => c.NomeServico, c => c.MapFrom(x => $"{x.Servico.Nome}"))
                .ForMember(c => c.NomeVeterinario, c => c.MapFrom(x => $"{x.Veterinario.Nome}"));

                config.CreateMap<Funcionario_Servico, Funcionario_ServicoModel>()
                .ForMember(c => c.Servico, c => c.MapFrom(x => x.Servico!.Id))
                .ForMember(c => c.Funcionario, c => c.MapFrom(x => x.Funcionario!.Id))
                .ForMember(c => c.NomeServico, c => c.MapFrom(x => $"{x.Servico.Nome}"))
                .ForMember(c => c.NomeFuncionario, c => c.MapFrom(x => $"{x.Funcionario.Nome}"));

                config.CreateMap<Venda, VendaModel>()
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Id))
                    .ForMember(d => d.NomeCliente, d => d.MapFrom(x => x.Cliente!.Nome));

                config.CreateMap<VendaItem, VendaItemModel>()
                    .ForMember(d => d.Venda, d => d.MapFrom(x => x.Venda!.Id))
                    .ForMember(d => d.Produto, d => d.MapFrom(x => x.Produto!.Id))
                    .ForMember(d => d.NomeProduto, d => d.MapFrom(x => x.Produto!.Nome))
                    .ForMember(d => d.Servico, d => d.MapFrom(x => x.Servico!.Id))
                    .ForMember(d => d.NomeServico, d => d.MapFrom(x => x.Produto!.Nome));

            }).CreateMapper());
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }

    }
}
