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
    public partial class CadastroCliente : CadastroBase
    {
        private readonly IBaseService<Cidade> _cidadeService;
        private readonly IBaseService<Cliente> _clienteService;
        private List<Cliente>? cliente;


        public CadastroCliente(IBaseService<Cidade> cidadeService, IBaseService<Cliente> clienteService)
        {
            _cidadeService = cidadeService;
            _clienteService = clienteService;
          
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "Nome";
            cboCidade.DataSource = _cidadeService?.Get<Cidade>().ToList();
        }

        private void PreencheObjeto(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCPF.Text;
            cliente.Email = txtEmail.Text;
            cliente.Senha = txtSenha.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.DataNascimento = DateOnly.FromDateTime(dateDataNascimento.Value);
            cliente.Telefone = txtTelefone.Text;
            cliente.DataCadastro = DateOnly.FromDateTime(dateDataCadastro.Value);

            if (int.TryParse(cboCidade.SelectedValue?.ToString(), out var CidadeId))
            {
                var cidade = _cidadeService.GetById<Cidade>(CidadeId);
                cliente.Cidade = cidade;
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
                        var cliente = _clienteService.GetById<Cliente>(id);
                        PreencheObjeto(cliente);
                        cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }
                }
                else
                {
                    var cliente = new Cliente();
                    PreencheObjeto(cliente);
                    _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
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
                _clienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            cliente = _clienteService.Get<Cliente>().ToList();
            dataGridViewConsulta.DataSource = cliente;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Nome"].HeaderText = "Cliente";
            dataGridViewConsulta.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            dataGridViewConsulta.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Senha"]!.Visible = false;
            dataGridViewConsulta.Columns["Cidade"].Visible = false;
            /*
            dataGridViewConsulta.Columns["Cidade"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeCidade"].HeaderText = "Cidade";*/
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtCPF.Text = linha?.Cells["CPF"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            dateDataNascimento.Value = ((DateOnly)linha?.Cells["DataNascimento"].Value).ToDateTime(new TimeOnly(0, 0));
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            dateDataCadastro.Value = ((DateOnly)linha?.Cells["DataCadastro"].Value).ToDateTime(new TimeOnly(0, 0));
            cboCidade.SelectedValue = linha?.Cells["Cidade"].Value;
        }
    }
}