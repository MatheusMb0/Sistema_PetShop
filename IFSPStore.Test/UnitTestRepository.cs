using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IFSPStore.Test
{
    [TestClass]
    public class TestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Aluno> Alunos { get; set; }
            public DbSet<Professor> Professores { get; set; }
            public DbSet<Curso> Cursos { get; set; }
            public DbSet<Disciplina> Disciplinas { get; set; }
            public DbSet<Turma> Turmas { get; set; }
            public DbSet<Prof_Turma_Disc> Prof_Turma_Discs { get; set; }
            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "Sistema_Escolar";
                var username = "root";
                var password = "1234567a";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertCursos()
        {

            using (var context = new MyDbContext())
            {


                var curso = new Curso
                {
                    Nome = "Engenharia de Computação",
                    Nivel = "Superior",
                    Area = "Técnologia",
                    Descricao = "Sem descrição",
                    Qntd_Periodo = 10
                };

                context.Cursos.Add(curso);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListCursos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var curso in context.Cursos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(curso));
                }
            }
        }

        [TestMethod]
        public void TestInsertProfessores()
        {
            using (var context = new MyDbContext())
            {

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

                context.Professores.Add(professor);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListProfessores()
        {
            using (var context = new MyDbContext())
            {
                foreach (var professor in context.Professores)
                {
                    Console.WriteLine(JsonSerializer.Serialize(professor));
                }
            }
        }


        [TestMethod]
        public void TestInsertTurmas()
        {

            using (var context = new MyDbContext())
            {
                var curso = context.Cursos.FirstOrDefault(c => c.Id == 1);
                var turma = new Turma
                {
                    Nome = "221",
                    Data_Inicio = DateTime.Parse("2025-01-12"),
                    Data_Fim = DateTime.Parse("2030-01-12"),
                    Quantidade_Max = 40,
                    Curso = curso
                };

                context.Turmas.Add(turma);

                context.SaveChanges();
            }

        }

        [TestMethod]
        public void TestListTurmas()
        {
            using (var context = new MyDbContext())
            {
                foreach (var turma in context.Turmas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(turma));
                }
            }
        }

        [TestMethod]
        public void TestInsertAlunos()
        {
            using (var context = new MyDbContext())
            {

                var turma = context.Turmas.FirstOrDefault(c => c.Id == 1);

                var aluno = new Aluno
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

                context.Alunos.Add(aluno);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListAlunos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var aluno in context.Alunos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(aluno));
                }
            }
        }

        [TestMethod]
        public void TestInsertDisciplinas()
        {

            using (var context = new MyDbContext())
            {
                var curso = context.Cursos.FirstOrDefault(c => c.Id == 1);

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

                context.Disciplinas.Add(disciplina);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListDisciplinas()
        {
            using (var context = new MyDbContext())
            {
                foreach (var disciplina in context.Disciplinas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(disciplina));
                }
            }
        }

        [TestMethod]
        public void TestInsertProf_Turma_Discs()
        {

            using (var context = new MyDbContext())
            {
                var professor = context.Professores.FirstOrDefault(c => c.Id == 1);
                var disciplina = context.Disciplinas.FirstOrDefault(c => c.Id == 1);
                var turma = context.Turmas.FirstOrDefault(c => c.Id == 1);

                var prof_Turma_Disc = new Prof_Turma_Disc
                {
                    Professor = professor,
                    Turma = turma,
                    Disciplina = disciplina
            };

                context.Prof_Turma_Discs.Add(prof_Turma_Disc);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListProf_Turma_Discs()
        {
            using (var context = new MyDbContext())
            {
                foreach (var prof_Turma_Disc in context.Prof_Turma_Discs)
                {
                    Console.WriteLine(JsonSerializer.Serialize(prof_Turma_Disc));
                }
            }
        }
    }
}