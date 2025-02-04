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
    public partial class CadastroProduto : CadastroBase
    {
        private readonly IBaseService<Grupo> _grupoService;
        private readonly IBaseService<Fornecedor> _fornecedorService;
        private readonly IBaseService<Produto> _produtoService;
        private List<ProdutoModel>? produto;


        public CadastroProduto(IBaseService<Grupo> grupoService, IBaseService<Fornecedor> fornecedorService, IBaseService<Produto> produtoService)
        {
            _grupoService = grupoService;
            _fornecedorService = fornecedorService;
            _produtoService = produtoService;

            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboGrupo.ValueMember = "Id";
            cboGrupo.DisplayMember = "Nome";
            cboGrupo.DataSource = _grupoService?.Get<Grupo>().ToList();

            cboFornecedor.ValueMember = "Id";
            cboFornecedor.DisplayMember = "NomeFantasia";
            cboFornecedor.DataSource = _fornecedorService?.Get<Fornecedor>().ToList();
        }

        private void PreencheObjeto(Produto produto)
        {
            produto.Nome = txtNome.Text;
            produto.Preco = float.Parse(txtPreco.Text);
            produto.Quantidade = int.Parse(txtQuantidade.Text);
            produto.DataCompra = DateOnly.FromDateTime(dateDataCompra.Value);
            produto.UnidadeVenda = txtUnidadeVenda.Text;
            produto.Descricao = txtDescricao.Text;

            if (int.TryParse(cboGrupo.SelectedValue?.ToString(), out var GrupoId))
            {
                var grupo = _grupoService.GetById<Grupo>(GrupoId);
                produto.Grupo = grupo;
            }

            if (int.TryParse(cboFornecedor.SelectedValue?.ToString(), out var FornecedorId))
            {
                var fornecedor = _fornecedorService.GetById<Fornecedor>(FornecedorId);
                produto.Fornecedor = fornecedor;
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
                        var produto = _produtoService.GetById<Produto>(id);
                        PreencheObjeto(produto);
                        produto = _produtoService.Update<Produto, Produto, ProdutoValidator>(produto);
                    }
                }
                else
                {
                    var produto = new Produto();
                    PreencheObjeto(produto);
                    _produtoService.Add<Produto, Produto, ProdutoValidator>(produto);
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
                _produtoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            produto = _produtoService.Get<ProdutoModel>().ToList();
            dataGridViewConsulta.DataSource = produto;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Nome"].HeaderText = "Produto";
            dataGridViewConsulta.Columns["DataCompra"].HeaderText = "Data do fornecimento";
            dataGridViewConsulta.Columns["UnidadeVenda"].HeaderText = "Unidade de Venda do Produto";
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Grupo"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeGrupo"].HeaderText = "Grupo";
            dataGridViewConsulta.Columns["Fornecedor"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeFornecedor"].HeaderText = "Fornecedor";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtPreco.Text = linha?.Cells["Preco"].Value.ToString();
            txtQuantidade.Text = linha?.Cells["Quantidade"].Value.ToString();
            dateDataCompra.Value = ((DateOnly)linha?.Cells["DataCompra"].Value).ToDateTime(new TimeOnly(0, 0));
            txtUnidadeVenda.Text = linha?.Cells["UnidadeVenda"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            cboGrupo.SelectedValue = linha?.Cells["Grupo"].Value;
            cboFornecedor.SelectedValue = linha?.Cells["Fornecedor"].Value;
        }
    }
}