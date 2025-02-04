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
    public partial class CadastroVeterinario_Servico : CadastroBase
    {
        private readonly IBaseService<Servico> _servicoService;
        private readonly IBaseService<Veterinario> _veterinarioService;
        private readonly IBaseService<Veterinario_Servico> _veterinario_ServicoService;
        private List<Veterinario_ServicoModel>? veterinario_Servico;


        public CadastroVeterinario_Servico(IBaseService<Servico> servicoService, IBaseService<Veterinario> veterinarioService, IBaseService<Veterinario_Servico> veterinario_ServicoService)
        {
            _servicoService = servicoService;
            _veterinarioService = veterinarioService;
            _veterinario_ServicoService = veterinario_ServicoService;

            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboServico.ValueMember = "Id";
            cboServico.DisplayMember = "Nome";
            cboServico.DataSource = _servicoService?.Get<Servico>().ToList();

            cboVeterinario.ValueMember = "Id";
            cboVeterinario.DisplayMember = "Nome";
            cboVeterinario.DataSource = _veterinarioService?.Get<Veterinario>().ToList();
        }

        private void PreencheObjeto(Veterinario_Servico veterinario_Servico)
        {

            if (int.TryParse(cboServico.SelectedValue?.ToString(), out var ServicoId))
            {
                var servico = _servicoService.GetById<Servico>(ServicoId);
                veterinario_Servico.Servico = servico;
            }

            if (int.TryParse(cboVeterinario.SelectedValue?.ToString(), out var VeterinarioId))
            {
                var veterinario = _veterinarioService.GetById<Veterinario>(VeterinarioId);
                veterinario_Servico.Veterinario = veterinario;
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
                        var veterinario_Servico = _veterinario_ServicoService.GetById<Veterinario_Servico>(id);
                        PreencheObjeto(veterinario_Servico);
                        veterinario_Servico = _veterinario_ServicoService.Update<Veterinario_Servico, Veterinario_Servico, Veterinario_ServicoValidator>(veterinario_Servico);
                    }
                }
                else
                {
                    var veterinario_Servico = new Veterinario_Servico();
                    PreencheObjeto(veterinario_Servico);
                    _veterinario_ServicoService.Add<Veterinario_Servico, Veterinario_Servico, Veterinario_ServicoValidator>(veterinario_Servico);
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
                _veterinario_ServicoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            veterinario_Servico = _veterinario_ServicoService.Get<Veterinario_ServicoModel>().ToList();
            dataGridViewConsulta.DataSource = veterinario_Servico;
            dataGridViewConsulta.Columns["Id"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Servico"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeServico"].HeaderText = "Servico";
            dataGridViewConsulta.Columns["Veterinario"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeVeterinario"].HeaderText = "Pet";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            cboServico.SelectedValue = linha?.Cells["Servico"].Value;
            cboVeterinario.SelectedValue = linha?.Cells["Veterinario"].Value;
        }
    }
}