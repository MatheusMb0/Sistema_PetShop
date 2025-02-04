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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IFSPStore.app.Cadastros
{
    public partial class CadastroVenda : CadastroBase
    {
        private List<VendaItemModel> _vendaItems;
        private readonly IBaseService<Venda> _vendaService;
        private readonly IBaseService<Servico> _servicoService;
        private readonly IBaseService<Produto> _produtoService;
        private readonly IBaseService<Cliente> _clienteService;

        private List<VendaModel>? vendas;

        public CadastroVenda(IBaseService<Venda> vendaService,
                             IBaseService<Servico> servicoService,
                             IBaseService<Produto> produtoService,
                              IBaseService<Cliente> clienteService)

        {
            _vendaService = vendaService;
            _servicoService = servicoService;
            _produtoService = produtoService;
            _clienteService = clienteService;
            _vendaItems = new List<VendaItemModel>();

            InitializeComponent();
            CarregarCombo();
            CarregaGridItensVenda();//
            Novo();
        }

        private void CarregarCombo()
        {
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            cboProduto.ValueMember = "Id";
            cboProduto.DisplayMember = "Nome";
            cboProduto.DataSource = _produtoService.Get<Produto>().ToList();

            cboServico.ValueMember = "Id";
            cboServico.DisplayMember = "Nome";
            cboServico.DataSource = _servicoService.Get<Servico>().ToList();
        }
        //
        private void PreencheObjeto(Venda venda)
        {
            venda.Data = dateData.Value;
            venda.EnderecoEntrega = txtEnderecoEntrega.Text;
            venda.BairroEntrega = txtBairroEntrega.Text;
            venda.CidadeEntrega = txtCidadeEntrega.Text;

            if (int.TryParse(cboCliente.SelectedValue?.ToString(), out var ClienteId))
            {
                var cliente = _clienteService.GetById<Cliente>(ClienteId);
                venda.Cliente = cliente;
            }

            venda.ValorTotalFinal = _vendaItems.Sum(x => x.ValorTotal);

            foreach (var item in _vendaItems)
            {
                var itemVenda = new VendaItem
                {
                    Venda = venda,
                    Produto = _produtoService.GetById<Produto>(item.IdProduto),
                    Servico = _servicoService.GetById<Servico>(item.Servico),
                    ValorUnitario = item.ValorUnitario,
                    Quantidade = item.Quantidade,
                    ValorTotal = item.ValorTotal
                };

                venda.Itens.Add(itemVenda);
            }
        }

        protected override void Novo()
        {
            base.Novo();
            _vendaItems.Clear();
            CarregaGridItensVenda();
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId, out var id))
                    {
                        var venda = _vendaService.GetById<Venda>(id);
                        PreencheObjeto(venda);
                        _vendaService.Update<Venda, Venda, VendaValidator>(venda);
                    }
                }
                else
                {
                    var venda = new Venda();
                    PreencheObjeto(venda);
                    _vendaService.Add<Venda, Venda, VendaValidator>(venda);
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
                _vendaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Cliente" };
            vendas = _vendaService.Get<VendaModel>(includes).ToList();
            dataGridViewConsulta.DataSource = vendas;
            dataGridViewConsulta.Columns["Cliente"]!.Visible = false;
            dataGridViewConsulta.Columns["ValorTotalFinal"].DefaultCellStyle.Format = "C2";
            dataGridViewConsulta.Columns["Data"].HeaderText = "Data da Venda";
            dataGridViewConsulta.Columns["EnderecoEntrega"].HeaderText = "Endereço para Entrega";
            dataGridViewConsulta.Columns["BairroEntrega"].HeaderText = "Bairro para Entrega";
            dataGridViewConsulta.Columns["CidadeEntrega"].HeaderText = "Cidade para Entrega";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            cboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
            dateData.Value = DateTime.Parse(linha?.Cells["Data"].Value.ToString());
            txtEnderecoEntrega.Text = linha?.Cells["EnderecoEntrega"].Value.ToString();
            txtBairroEntrega.Text = linha?.Cells["BairroEntrega"].Value.ToString();
            txtCidadeEntrega.Text = linha?.Cells["CidadeEntrega"].Value.ToString();

            var includes = new List<string>() { "Cliente", "Items", "Items.Produto" };
            var venda = _vendaService.GetById<Venda>(id, includes);
            _vendaItems = new List<VendaItemModel>();
            foreach (var item in venda.Itens)
            {
                var vendaItem = new VendaItemModel
                {
                    Id = item.Id,
                    IdProduto = item.Produto!.Id,
                    NomeProduto = item.Produto!.Nome,
                    ValorTotal = (float)item.ValorTotal,
                    Quantidade = (int)item.Quantidade,
                    ValorUnitario = (float)item.ValorUnitario
                };
                _vendaItems.Add(vendaItem);
            }
            CarregaGridItensVenda();

        }

        private void CarregaGridItensVenda()
        {
            var source = new BindingSource();
            source.DataSource = _vendaItems.ToArray();
            dataGridViewConsulta.DataSource = source;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Produto"]!.HeaderText = @"Id.Produto";
            dataGridViewConsulta.Columns["ValorUnitario"]!.DefaultCellStyle.Format = "C2";
            dataGridViewConsulta.Columns["ValorTotal"]!.DefaultCellStyle.Format = "C2";
        }//
    }
}

        /*private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var vendaItem = new VendaItemModel();
            if (int.TryParse(cboProduto.SelectedValue.ToString(), out var idProduto))
            {
                var produto = _produtoService.GetById<Produto>(idProduto);
                vendaItem.IdProduto = produto.Id;
                vendaItem.NomeProduto = produto.Nome;
            }

            if (int.TryParse(cboServico.SelectedValue.ToString(), out var idServico))
            {
                var servico = _servicoService.GetById<Servico>(idServico);
                vendaItem.Servico = servico.Id;
                vendaItem.NomeServico = servico.Nome;
            }

            if (float.TryParse(txtVlUnitario.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var vlUnitario))
            {
                vendaItem.ValorUnitario = vlUnitario;
            }
            if (int.TryParse(txtQuantidade.Text, out var qtd))
            {
                vendaItem.Quantidade = qtd;
            }

            vendaItem.ValorTotal = vendaItem.Quantidade * vendaItem.ValorUnitario;

            _vendaItems.Add(vendaItem);
            CarregaGridItensVenda();
        }*/

        /*private void txtVlUnitario_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtVlUnitario.Text, out double value))
                txtVlUnitario.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
            else
                txtVlUnitario.Text = string.Empty;

            CalculaTotalItem();
        }*/

        /*private void CalculaTotalItem()
        {
            var convVlr = float.TryParse(txtVlUnitario.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float vlUnitario);
            var convQtd = int.TryParse(txtQuantidade.Text, out int quantidade);
            if (convVlr && convQtd)
            {
                var valorTotal = quantidade * vlUnitario;
                txtVlTotal.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }

        private void CalculaTotalVenda()
        {
            lblValor.Text = $@"Valor Total: {string.Format(CultureInfo.CurrentCulture, "{0:C2}", _vendaItems.Sum(x => x.ValorTotal))}";
            lblQtdItens.Text = $@"Qtd. Produtos: {_vendaItems.Sum(x => x.Quantidade)}";
        }*/

       /*private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
        }*/