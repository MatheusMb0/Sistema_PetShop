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
    public partial class CadastroPet_Servico : CadastroBase
    {
        private readonly IBaseService<Servico> _servicoService;
        private readonly IBaseService<Pet> _petService;
        private readonly IBaseService<Pet_Servico> _pet_ServicoService;
        private List<Pet_ServicoModel>? pet_Servico;


        public CadastroPet_Servico(IBaseService<Servico> servicoService, IBaseService<Pet> petService, IBaseService<Pet_Servico> pet_ServicoService)
        {
            _servicoService = servicoService;
            _petService = petService;
            _pet_ServicoService = pet_ServicoService;

            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboServico.ValueMember = "Id";
            cboServico.DisplayMember = "Nome";
            cboServico.DataSource = _servicoService?.Get<Servico>().ToList();

            cboPet.ValueMember = "Id";
            cboPet.DisplayMember = "Nome";
            cboPet.DataSource = _petService?.Get<Pet>().ToList();
        }

        private void PreencheObjeto(Pet_Servico pet_Servico)
        {

            if (int.TryParse(cboServico.SelectedValue?.ToString(), out var ServicoId))
            {
                var servico = _servicoService.GetById<Servico>(ServicoId);
                pet_Servico.Servico = servico;
            }

            if (int.TryParse(cboPet.SelectedValue?.ToString(), out var PetId))
            {
                var pet = _petService.GetById<Pet>(PetId);
                pet_Servico.Pet = pet;
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
                        var pet_Servico = _pet_ServicoService.GetById<Pet_Servico>(id);
                        PreencheObjeto(pet_Servico);
                        pet_Servico = _pet_ServicoService.Update<Pet_Servico, Pet_Servico, Pet_ServicoValidator>(pet_Servico);
                    }
                }
                else
                {
                    var pet_Servico = new Pet_Servico();
                    PreencheObjeto(pet_Servico);
                    _pet_ServicoService.Add<Pet_Servico, Pet_Servico, Pet_ServicoValidator>(pet_Servico);
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
                _pet_ServicoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            pet_Servico = _pet_ServicoService.Get<Pet_ServicoModel>().ToList();
            dataGridViewConsulta.DataSource = pet_Servico;
            dataGridViewConsulta.Columns["Id"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Servico"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeServico"].HeaderText = "Servico";
            dataGridViewConsulta.Columns["Pet"]!.Visible = false;
            dataGridViewConsulta.Columns["NomePet"].HeaderText = "Pet";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            cboServico.SelectedValue = linha?.Cells["Servico"].Value;
            cboPet.SelectedValue = linha?.Cells["Pet"].Value;
        }
    }
}