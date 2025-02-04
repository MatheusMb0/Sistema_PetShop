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
    public partial class CadastroFuncionario_Servico : CadastroBase
    {
        private readonly IBaseService<Servico> _servicoService;
        private readonly IBaseService<Funcionario> _funcionarioService;
        private readonly IBaseService<Funcionario_Servico> _funcionario_ServicoService;
        private List<Funcionario_ServicoModel>? funcionario_Servico;


        public CadastroFuncionario_Servico(IBaseService<Servico> servicoService, IBaseService<Funcionario> funcionarioService, IBaseService<Funcionario_Servico> funcionario_ServicoService)
        {
            _servicoService = servicoService;
            _funcionarioService = funcionarioService;
            _funcionario_ServicoService = funcionario_ServicoService;

            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboServico.ValueMember = "Id";
            cboServico.DisplayMember = "Nome";
            cboServico.DataSource = _servicoService?.Get<Servico>().ToList();

            cboFuncionario.ValueMember = "Id";
            cboFuncionario.DisplayMember = "Nome";
            cboFuncionario.DataSource = _funcionarioService?.Get<Funcionario>().ToList();
        }

        private void PreencheObjeto(Funcionario_Servico funcionario_Servico)
        {

            if (int.TryParse(cboServico.SelectedValue?.ToString(), out var ServicoId))
            {
                var servico = _servicoService.GetById<Servico>(ServicoId);
                funcionario_Servico.Servico = servico;
            }

            if (int.TryParse(cboFuncionario.SelectedValue?.ToString(), out var FuncionarioId))
            {
                var funcionario = _funcionarioService.GetById<Funcionario>(FuncionarioId);
                funcionario_Servico.Funcionario = funcionario;
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
                        var funcionario_Servico = _funcionario_ServicoService.GetById<Funcionario_Servico>(id);
                        PreencheObjeto(funcionario_Servico);
                        funcionario_Servico = _funcionario_ServicoService.Update<Funcionario_Servico, Funcionario_Servico, Funcionario_ServicoValidator>(funcionario_Servico);
                    }
                }
                else
                {
                    var funcionario_Servico = new Funcionario_Servico();
                    PreencheObjeto(funcionario_Servico);
                    _funcionario_ServicoService.Add<Funcionario_Servico, Funcionario_Servico, Funcionario_ServicoValidator>(funcionario_Servico);
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
                _funcionario_ServicoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            funcionario_Servico = _funcionario_ServicoService.Get<Funcionario_ServicoModel>().ToList();
            dataGridViewConsulta.DataSource = funcionario_Servico;
            dataGridViewConsulta.Columns["Id"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Servico"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeServico"].HeaderText = "Servico";
            dataGridViewConsulta.Columns["Funcionario"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeFuncionario"].HeaderText = "Funcionario";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            cboServico.SelectedValue = linha?.Cells["Servico"].Value;
            cboFuncionario.SelectedValue = linha?.Cells["Funcionario"].Value;
        }
    }
}