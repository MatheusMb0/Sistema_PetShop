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
    public partial class CadastroServico : CadastroBase
    {
        private readonly IBaseService<Servico> _servicoService;
        private List<Servico>? servico;


        public CadastroServico(IBaseService<Servico> servicoService)
        {
            _servicoService = servicoService;

            InitializeComponent();
        }

        private void PreencheObjeto(Servico servico)
        {
            servico.Nome = txtNome.Text;
            servico.Descricao = txtDescricao.Text;
            servico.Preco = float.Parse(txtPreco.Text);
            servico.DuracaoEstimada = txtDuracaoEstimada.Text;
            servico.TipoServico = txtTipoServico.Text;
            servico.Disponibilidade = txtDisponibilidade.Text;
            servico.Requisitos = txtRequisitos.Text;
            servico.Materiais = txtMateriais.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId, out var id))
                    {
                        var servico = _servicoService.GetById<Servico>(id);
                        PreencheObjeto(servico);
                        servico = _servicoService.Update<Servico, Servico, ServicoValidator>(servico);
                    }
                }
                else
                {
                    var servico = new Servico();
                    PreencheObjeto(servico);
                    _servicoService.Add<Servico, Servico, ServicoValidator>(servico);
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
                _servicoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            servico = _servicoService.Get<Servico>().ToList();
            dataGridViewConsulta.DataSource = servico;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Nome"].HeaderText = "Serviço";
            dataGridViewConsulta.Columns["Preco"].HeaderText = "Valor à pagar";
            dataGridViewConsulta.Columns["DuracaoEstimada"].HeaderText = "Duração estimada do serviço";
            dataGridViewConsulta.Columns["TipoServico"].HeaderText = "Tipo do serviço";
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            txtPreco.Text = linha?.Cells["Preco"].Value.ToString();
            txtDuracaoEstimada.Text = linha?.Cells["DuracaoEstimada"].Value.ToString();
            txtTipoServico.Text = linha?.Cells["TipoServico"].Value.ToString();
            txtDisponibilidade.Text = linha?.Cells["Disponibilidade"].Value.ToString();
            txtRequisitos.Text = linha?.Cells["Requisitos"].Value.ToString();
            txtMateriais.Text = linha?.Cells["Materiais"].Value.ToString();
        }
    }
}