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
    public partial class CadastroVeterinario : CadastroBase
    {
        private readonly IBaseService<Cidade> _cidadeService;
        private readonly IBaseService<Veterinario> _veterinarioService;
        private List<VeterinarioModel>? veterinario;


        public CadastroVeterinario(IBaseService<Cidade> cidadeService, IBaseService<Veterinario> veterinarioService)
        {
            _cidadeService = cidadeService;
            _veterinarioService = veterinarioService;

            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "Nome";
            cboCidade.DataSource = _cidadeService?.Get<Cidade>().ToList();
        }

        private void PreencheObjeto(Veterinario veterinario)
        {
            veterinario.Nome = txtNome.Text;
            veterinario.CPF = txtCPF.Text;
            veterinario.CRMV = txtCRMV.Text;
            veterinario.Especializacao = txtEspecializacao.Text;
            veterinario.Email = txtEmail.Text;
            veterinario.Telefone = txtTelefone.Text;
            veterinario.Endereco = txtEndereco.Text;
            veterinario.Bairro = txtBairro.Text;
            veterinario.HorarioTrabalho = txtHorarioTrabalho.Text;
            veterinario.Salario = float.Parse(txtSalario.Text);
            veterinario.DataContratacao = DateOnly.FromDateTime(dateDataContratacao.Value);
            veterinario.Descricao = txtEndereco.Text;

            if (int.TryParse(cboCidade.SelectedValue?.ToString(), out var CidadeId))
            {
                var cidade = _cidadeService.GetById<Cidade>(CidadeId);
                veterinario.Cidade = cidade;
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
                        var veterinario = _veterinarioService.GetById<Veterinario>(id);
                        PreencheObjeto(veterinario);
                        veterinario = _veterinarioService.Update<Veterinario, Veterinario, VeterinarioValidator>(veterinario);
                    }
                }
                else
                {
                    var veterinario = new Veterinario();
                    PreencheObjeto(veterinario);
                    _veterinarioService.Add<Veterinario, Veterinario, VeterinarioValidator>(veterinario);
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
                _veterinarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            veterinario = _veterinarioService.Get<VeterinarioModel>().ToList();
            dataGridViewConsulta.DataSource = veterinario;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Nome"].HeaderText = "Veterinário";
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
            txtCRMV.Text = linha?.Cells["CRMV"].Value.ToString();
            txtEspecializacao.Text = linha?.Cells["Especializacao"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            txtHorarioTrabalho.Text = linha?.Cells["HorarioTrabalho"].Value.ToString();
            txtSalario.Text = linha?.Cells["Salario"].Value.ToString();
            dateDataContratacao.Value = ((DateOnly)linha?.Cells["DataContratacao"].Value).ToDateTime(new TimeOnly(0, 0));
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            cboCidade.SelectedValue = linha?.Cells["Cidade"].Value;
        }
    }
}