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
    public partial class CadastroFornecedor : CadastroBase
    {
        private readonly IBaseService<Cidade> _cidadeService;
        private readonly IBaseService<Fornecedor> _fornecedorService;
        private List<FornecedorModel>? fornecedor;


        public CadastroFornecedor(IBaseService<Cidade> cidadeService, IBaseService<Fornecedor> fornecedorService)
        {
            _cidadeService = cidadeService;
            _fornecedorService = fornecedorService;

            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "Nome";
            cboCidade.DataSource = _cidadeService?.Get<Cidade>().ToList();
        }

        private void PreencheObjeto(Fornecedor fornecedor)
        {
            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.Senha = txtSenha.Text;
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Bairro = txtBairro.Text;
            fornecedor.DataCadastro = dateDataCadastro.Value;

            if (int.TryParse(cboCidade.SelectedValue?.ToString(), out var CidadeId))
            {
                var cidade = _cidadeService.GetById<Cidade>(CidadeId);
                fornecedor.Cidade = cidade;
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
                        var fornecedor = _fornecedorService.GetById<Fornecedor>(id);
                        PreencheObjeto(fornecedor);
                        fornecedor = _fornecedorService.Update<Fornecedor, Fornecedor, FornecedorValidator>(fornecedor);
                    }
                }
                else
                {
                    var fornecedor = new Fornecedor();
                    PreencheObjeto(fornecedor);
                    _fornecedorService.Add<Fornecedor, Fornecedor, FornecedorValidator>(fornecedor);
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
                _fornecedorService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            fornecedor = _fornecedorService.Get<FornecedorModel>().ToList();
            dataGridViewConsulta.DataSource = fornecedor;
            dataGridViewConsulta.Columns["NomeFantasia"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["NomeFantasia"].HeaderText = "Empresa";
            dataGridViewConsulta.Columns["RazaoSocial"].HeaderText = "Razão Social";
            dataGridViewConsulta.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Senha"]!.Visible = false;
            dataGridViewConsulta.Columns["Cidade"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeCidade"].HeaderText = "Cidade";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtNomeFantasia.Text = linha?.Cells["NomeFantasia"].Value.ToString();
            txtRazaoSocial.Text = linha?.Cells["RazaoSocial"].Value.ToString();
            txtCNPJ.Text = linha?.Cells["CNPJ"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            dateDataCadastro.Value = DateTime.Parse(linha?.Cells["DataCadastro"].Value.ToString());
            cboCidade.SelectedValue = linha?.Cells["Cidade"].Value;
        }
    }
}