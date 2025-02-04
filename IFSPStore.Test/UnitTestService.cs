using AutoMapper;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Services;
using IFSPStore.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace IFSPStore.Test
{
    [TestClass]
    public class TestService
    {

        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "Sistema_Escolar";
                var username = "root";
                var password = "1234567a";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Curso>, BaseRepository<Curso>>();
            services.AddScoped<IBaseService<Curso>, BaseService<Curso>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Curso, Curso>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Professor>, BaseRepository<Professor>>();
            services.AddScoped<IBaseService<Professor>, BaseService<Professor>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Professor, Professor>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Disciplina>, BaseRepository<Disciplina>>();
            services.AddScoped<IBaseService<Disciplina>, BaseService<Disciplina>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Disciplina, Disciplina>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Turma>, BaseRepository<Turma>>();
            services.AddScoped<IBaseService<Turma>, BaseService<Turma>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Turma, Turma>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Aluno>, BaseRepository<Aluno>>();
            services.AddScoped<IBaseService<Aluno>, BaseService<Aluno>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Aluno, Aluno>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Prof_Turma_Disc>, BaseRepository<Prof_Turma_Disc>>();
            services.AddScoped<IBaseService<Prof_Turma_Disc>, BaseService<Prof_Turma_Disc>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Prof_Turma_Disc, Prof_Turma_Disc>();
            }).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestCurso()
        {
            var sp = ConfigureServices();

            var CursoService = sp.GetService<IBaseService<Curso>>();
            var curso = new Curso
            {
                Nome = "Engenharia de Computação",
                Nivel = "Superior",
                Area = "Técnologia",
                Descricao = "Sem descrição",
                Qntd_Periodo = 10
            };

            var result = CursoService?.Add<Curso, Curso, CursoValidator>(curso);

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectCurso()
        {
            var sp = ConfigureServices();
            var cursoService = sp.GetService<IBaseService<Curso>>();

            var result = cursoService?.Get<Curso>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestProfessor()
        {
            var sp = ConfigureServices();

            var ProfessorService = sp.GetService<IBaseService<Professor>>();
            var professor = new Professor
            {
                Nome = "Murilo",
                Titulacao = "Doutor",
                CPF = "444444444-44",
                RG = "999999-99",
                Genero = "Masculino",
                Contato = "(18)99999-9999",
                Email = "Murilo@ifsp",
                Descricao = "Sem descrição",
                Carga_Horaria = 180.5f
            };

            var result = ProfessorService?.Add<Professor, Professor, ProfessorValidator>(professor);

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectProfessor()
        {
            var sp = ConfigureServices();

            var ProfessorService = sp.GetService<IBaseService<Professor>>();

            var result = ProfessorService?.Get<Professor>();

            Console.Write(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestDisciplina()
        {
            var sp = ConfigureServices();

            var DisciplinaService = sp.GetService<IBaseService<Disciplina>>();
            var CursoService = sp.GetService<IBaseService<Curso>>();
            var curso = CursoService.Get<Curso>().FirstOrDefault(c => c.Id >= 1);

            var disciplina = new Disciplina
            {
                Nome = "Cálculo II",
                Descricao = "Sem descrição",
                Carga_Horaria = 36.5f,
                Dependencia = "Cálculo I",
                Local_Da_Disc = "Bloco D",
                Dia_Da_Disc = "Seg/Qua",
                Curso = curso
            };

            var resultDisciplina = DisciplinaService?.Add<Disciplina, Disciplina, DisciplinaValidator>(disciplina);

            Console.Write(JsonSerializer.Serialize(resultDisciplina));

        }

        [TestMethod]
        public void TestSelectDisciplina()
        {
            var sp = ConfigureServices();

            var disciplinaService = sp.GetService<IBaseService<Disciplina>>();

            var result = disciplinaService?.Get<Disciplina>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestTurma()
        {
            var sp = ConfigureServices();

            var TurmaService = sp.GetService<IBaseService<Turma>>();
            var CursoService = sp.GetService<IBaseService<Curso>>();
            var curso = CursoService.Get<Curso>().FirstOrDefault(c => c.Id >= 1);

            var turma = new Turma
            {
                Nome = "221",
                Data_Inicio = DateTime.Parse("2025-01-12"),
                Data_Fim = DateTime.Parse("2030-01-12"),
                Quantidade_Max = 40,
                Curso = curso
            };

            var resultTurma = TurmaService?.Add<Turma, Turma, TurmaValidator>(turma);

            Console.Write(JsonSerializer.Serialize(resultTurma));

        }

        [TestMethod]
        public void TestSelectTurma()
        {
            var sp = ConfigureServices();
            var turmaService = sp.GetService<IBaseService<Turma>>();

            var result = turmaService?.Get<Turma>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestAluno()
        {
            var sp = ConfigureServices();

            var CursoService = sp.GetService<IBaseService<Curso>>();
            var TurmaService = sp.GetService<IBaseService<Turma>>();
            var turma = TurmaService.Get<Turma>().FirstOrDefault(c => c.Id >= 1);

            var AlunoService = sp.GetService<IBaseService<Aluno>>();

            var aluno = new Aluno()
            {
                RG = "11111111-11",
                CPF = "888888888-88",
                Nome = "Gustavo",
                Endereco = "Rua A",
                Contato = "(18) 99186-3585",
                Email = "gustavo@ifsp",
                Genero = "Masculino",
                Data_Nasc = DateOnly.Parse("2025-01-12"),
                Turma = turma
            };

            var result = AlunoService?.Add<Aluno, Aluno, AlunoValidator>(aluno);

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectAluno()
        {
            var sp = ConfigureServices();

            var alunoService = sp.GetService<IBaseService<Aluno>>();

            var result = alunoService?.Get<Aluno>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestProf_Turma_Disc()
        {
            var sp = ConfigureServices();

            var CursoService = sp.GetService<IBaseService<Curso>>();
            var TurmaService = sp.GetService<IBaseService<Turma>>();
            var DisciplinaService = sp.GetService<IBaseService<Disciplina>>();
            var ProfessorService = sp.GetService<IBaseService<Professor>>();

            var turma = TurmaService.Get<Turma>().FirstOrDefault(c => c.Id >= 1);
            var disciplina = DisciplinaService.Get<Disciplina>().FirstOrDefault(c => c.Id >= 1);
            var professor = ProfessorService.Get<Professor>().FirstOrDefault(c => c.Id >= 1);

            var Prof_Turma_DiscService = sp.GetService<IBaseService<Prof_Turma_Disc>>();

            var prof_Turma_Disc = new Prof_Turma_Disc
            {
                Professor = professor,
                Turma = turma,
                Disciplina = disciplina
            };

            var resultprof_Turma_Disc = Prof_Turma_DiscService?.Add<Prof_Turma_Disc, Prof_Turma_Disc, Prof_Turma_DiscValidator>(prof_Turma_Disc);

            Console.Write(JsonSerializer.Serialize(prof_Turma_Disc));

        }

        [TestMethod]
        public void TestSelectProf_Turma_Disc()
        {
            var sp = ConfigureServices();
            var prof_Turma_DiscService = sp.GetService<IBaseService<Prof_Turma_Disc>>();

            var result = prof_Turma_DiscService?.Get<Prof_Turma_Disc>();

            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}