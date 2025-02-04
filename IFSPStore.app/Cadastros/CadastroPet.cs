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
    public partial class CadastroPet : CadastroBase
    {
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Pet> _petService;
        private List<PetModel>? pet;


        public CadastroPet(IBaseService<Cliente> clienteService, IBaseService<Pet> petService)
        {
            _clienteService = clienteService;
            _petService = petService;

            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService?.Get<Cliente>().ToList();
        }

        private void PreencheObjeto(Pet pet)
        {
            pet.Nome = txtNome.Text;
            pet.TipoPet = txtTipoPet.Text;
            pet.Raca = txtRaca.Text;
            pet.DataNascimento = DateOnly.FromDateTime(dateDataNascimento.Value);
            pet.Peso = float.Parse(txtPeso.Text);
            pet.Sexo = cboSexo.Text;
            pet.Cor = txtCor.Text;
            pet.Descricao = txtDescricao.Text;

            if (int.TryParse(cboCliente.SelectedValue?.ToString(), out var ClienteId))
            {
                var cliente = _clienteService.GetById<Cliente>(ClienteId);
                pet.Cliente = cliente;
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
                        var pet = _petService.GetById<Pet>(id);
                        PreencheObjeto(pet);
                        pet = _petService.Update<Pet, Pet, PetValidator>(pet);
                    }
                }
                else
                {
                    var pet = new Pet();
                    PreencheObjeto(pet);
                    _petService.Add<Pet, Pet, PetValidator>(pet);
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
                _petService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            pet = _petService.Get<PetModel>().ToList();
            dataGridViewConsulta.DataSource = pet;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Nome"].HeaderText = "Pet";
            dataGridViewConsulta.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            dataGridViewConsulta.Columns["Raca"].HeaderText = "Raça";
            dataGridViewConsulta.Columns["TipoPet"].HeaderText = "Espécie";
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Cliente"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeCliente"].HeaderText = "Cliente";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtTipoPet.Text = linha?.Cells["TipoPet"].Value.ToString();
            txtRaca.Text = linha?.Cells["Raca"].Value.ToString();
            dateDataNascimento.Value = ((DateOnly)linha?.Cells["DataNascimento"].Value).ToDateTime(new TimeOnly(0, 0));
            txtPeso.Text = linha?.Cells["Peso"].Value.ToString();
            cboSexo.Text = linha?.Cells["Sexo"].Value.ToString();
            txtCor.Text = linha?.Cells["Cor"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            cboCliente.SelectedValue = linha?.Cells["Cliente"].Value;
        }
    }
}