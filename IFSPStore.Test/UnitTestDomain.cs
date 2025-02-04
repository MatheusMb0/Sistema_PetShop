using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Text.Json;
using System.Text.RegularExpressions;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnitTestDomain
    {

        [TestMethod]
        public void TestCurso()
        {
            Curso curso = new Curso(1, "Engenharia", "Superior", "Técnologia", "Sem descrição", 10);

            Debug.WriteLine(JsonSerializer.Serialize(curso));

            Assert.AreEqual(curso.Nome, "Engenharia");
            Assert.AreEqual(curso.Nivel, "Superior");
            Assert.AreEqual(curso.Area, "Técnologia");
            Assert.AreEqual(curso.Descricao, "Sem descrição");
            Assert.AreEqual(curso.Qntd_Periodo, 10);
        }

        [TestMethod]
        public void TestTurma()
        {
            Curso curso = new Curso(1, "Engenharia", "Superior", "Técnologia", "Sem descrição", 10);
            Turma turma = new Turma(1, "221", DateTime.Parse("2025-10-01 00:00:00"), 
                DateTime.Parse("2025-10-01 00:00:00"), 40, curso);

            Debug.WriteLine(JsonSerializer.Serialize(turma));

            Assert.AreEqual(turma.Nome, "221");
            Assert.AreEqual(turma.Data_Inicio, DateTime.Parse("2025-10-01 00:00:00"));
            Assert.AreEqual(turma.Data_Fim, DateTime.Parse("2025-10-01 00:00:00"));
            Assert.AreEqual(turma.Quantidade_Max, 40);
            Assert.AreEqual(turma.Curso, curso);
        }

        [TestMethod]
        public void TestAluno()
        {
            Curso curso = new Curso(1, "Engenharia", "Superior", "Técnologia", "Sem descrição", 10);

            Turma turma = new Turma(1, "221", DateTime.Parse("2025-10-01 00:00:00"),
                DateTime.Parse("2025-10-01 00:00:00"), 40, curso);

            Aluno aluno = new Aluno(1, "1111111-11", "222222222-22", "Gustavo", "Rua A", "(18)99999-9999",
            "gustavo@ifsp", "Masculino", DateOnly.Parse("2003-05-06"), turma);

            Debug.WriteLine(JsonSerializer.Serialize(aluno));

            Assert.AreEqual(aluno.RG, "1111111-11");
            Assert.AreEqual(aluno.CPF, "222222222-22");
            Assert.AreEqual(aluno.Nome, "Gustavo");
            Assert.AreEqual(aluno.Endereco, "Rua A");
            Assert.AreEqual(aluno.Contato, "(18)99999-9999");
            Assert.AreEqual(aluno.Email, "gustavo@ifsp");
            Assert.AreEqual(aluno.Genero, "Masculino");
            Assert.AreEqual(aluno.Data_Nasc, DateOnly.Parse("2003-05-06"));
            Assert.AreEqual(aluno.Turma, turma);
        }

        [TestMethod]
        public void TestProfessor()
        {

            Professor professor = new Professor(1, "Douglas", "Doutor" , "999999999-99", 
                "55555555-55", "Masculino", "(18)88888-8888", "Douglas@ifsp", "Sem descricao",
                180.5f);

            Debug.WriteLine(JsonSerializer.Serialize(professor));

            Assert.AreEqual(professor.Nome, "Douglas");
            Assert.AreEqual(professor.Titulacao, "Doutor");
            Assert.AreEqual(professor.CPF, "999999999-99");
            Assert.AreEqual(professor.RG, "55555555-55");
            Assert.AreEqual(professor.Genero, "Masculino");
            Assert.AreEqual(professor.Contato, "(18)88888-8888");
            Assert.AreEqual(professor.Email, "Douglas@ifsp");
            Assert.AreEqual(professor.Descricao, "Sem descricao");
            Assert.AreEqual(professor.Carga_Horaria, 180.5f);
        }

        [TestMethod]
        public void TestDisciplina()
        {
            Curso curso = new Curso(1, "Engenharia", "Superior", "Técnologia", "Sem descrição", 10);

            Disciplina disciplina = new Disciplina(1, "Cálculo II", "Sem descrição", 30.5f,
                "Cálculo I", "Bloco D", "Seg/Qua", curso);

            Debug.WriteLine(JsonSerializer.Serialize(disciplina));

            Assert.AreEqual(disciplina.Nome, "Cálculo II");
            Assert.AreEqual(disciplina.Descricao, "Sem descrição");
            Assert.AreEqual(disciplina.Carga_Horaria, 30.5f);
            Assert.AreEqual(disciplina.Dependencia, "Cálculo I");
            Assert.AreEqual(disciplina.Local_Da_Disc, "Bloco D");
            Assert.AreEqual(disciplina.Dia_Da_Disc, "Seg/Qua");
            Assert.AreEqual(disciplina.Curso, curso);
        }

        [TestMethod]

        public void TestProf_Turma_Disc()
        {
            Professor professor = new Professor(1, "Douglas", "Doutor", "999999999-99",
               "55555555-55", "Masculino", "(18)88888-8888", "Douglas@ifsp", "Sem descricao",
               180.5f);

            Curso curso = new Curso(1, "Engenharia", "Superior", "Técnologia", "Sem descrição", 10);

            Turma turma = new Turma(1, "221", DateTime.Parse("2025-10-01 00:00:00"),
                DateTime.Parse("2025-10-01 00:00:00"), 40, curso);

            Disciplina disciplina = new Disciplina(1, "Cálculo II", "Sem descrição", 30.5f,
                "Cálculo I", "Bloco D", "Seg/Qua", curso);

            Prof_Turma_Disc prof_Turma_Disc = new Prof_Turma_Disc(1, professor, turma, disciplina);

            Console.WriteLine(JsonSerializer.Serialize(prof_Turma_Disc));
            Assert.AreEqual(prof_Turma_Disc.Professor, professor);
            Assert.AreEqual(prof_Turma_Disc.Turma, turma);
            Assert.AreEqual(prof_Turma_Disc.Disciplina, disciplina);

        }
    }
}
