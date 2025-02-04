using IFSPStore.app.Base;
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IFSPStore.app.Cadastros
{
    public partial class CadastroFuncionario : CadastroBase
    {
        private readonly IBaseService<Cidade> _cidadeService;
        private readonly IBaseService<Funcionario> _funcionarioService;
        private List<FuncionarioModel>? funcionario;


        public CadastroFuncionario(IBaseService<Cidade> cidadeService, IBaseService<Funcionario> funcionarioService)
        {
            _cidadeService = cidadeService;
            _funcionarioService = funcionarioService;

            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "Nome";
            cboCidade.DataSource = _cidadeService?.Get<Cidade>().ToList();
        }

        private void PreencheObjeto(Funcionario funcionario)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.CPF = txtCPF.Text;
            funcionario.RG = txtRG.Text;
            funcionario.DataNascimento = DateOnly.FromDateTime(dateDataNascimento.Value);
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Cargo = txtCargo.Text;
            funcionario.Salario = float.Parse(txtSalario.Text);
            funcionario.DataContratacao = DateOnly.FromDateTime(dateDataContratacao.Value);
            funcionario.HorarioTrabalho = txtHorarioTrabalho.Text;
            funcionario.Descricao = txtDescricao.Text;

            if (int.TryParse(cboCidade.SelectedValue?.ToString(), out var CidadeId))
            {
                var cidade = _cidadeService.GetById<Cidade>(CidadeId);
                funcionario.Cidade = cidade;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId, out var id))
                    {
                        var funcionario = _funcionarioService.GetById<Funcionario>(id);
                        PreencheObjeto(funcionario);
                        funcionario = _funcionarioService.Update<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
                    }
                }
                else
                {
                    var funcionario = new Funcionario();
                    PreencheObjeto(funcionario);
                    _funcionarioService.Add<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
                }
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _funcionarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            funcionario = _funcionarioService.Get<FuncionarioModel>().ToList();
            dataGridViewConsulta.DataSource = funcionario;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Nome"].HeaderText = "Funcionário";
            dataGridViewConsulta.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            dataGridViewConsulta.Columns["DataContratacao"].HeaderText = "Data de Contratação";
            dataGridViewConsulta.Columns["HorarioTrabalho"].HeaderText = "Horário de Trabalho";
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Cidade"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeCidade"].HeaderText = "Cidade";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtCPF.Text = linha?.Cells["CPF"].Value.ToString();
            txtRG.Text = linha?.Cells["RG"].Value.ToString();
            dateDataNascimento.Value = ((DateOnly)linha?.Cells["DataNascimento"].Value).ToDateTime(new TimeOnly(0, 0));
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtCargo.Text = linha?.Cells["Cargo"].Value.ToString();
            txtSalario.Text = linha?.Cells["Salario"].Value.ToString();
            dateDataContratacao.Value = ((DateOnly)linha?.Cells["DataContratacao"].Value).ToDateTime(new TimeOnly(0, 0));
            txtHorarioTrabalho.Text = linha?.Cells["HorarioTrabalho"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            cboCidade.SelectedValue = linha?.Cells["Cidade"].Value;
        }
    }
}