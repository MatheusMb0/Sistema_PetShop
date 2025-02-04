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
    public partial class CadastroGrupo : CadastroBase
    {
        private readonly IBaseService<Grupo> _grupoService;
        private List<Grupo>? grupo;


        public CadastroGrupo(IBaseService<Grupo> grupoService)
        {
            _grupoService = grupoService;

            InitializeComponent();
        }

        private void PreencheObjeto(Grupo grupo)
        {
            grupo.Nome = txtNome.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId, out var id))
                    {
                        var grupo = _grupoService.GetById<Grupo>(id);
                        PreencheObjeto(grupo);
                        grupo = _grupoService.Update<Grupo, Grupo, GrupoValidator>(grupo);
                    }
                }
                else
                {
                    var grupo = new Grupo();
                    PreencheObjeto(grupo);
                    _grupoService.Add<Grupo, Grupo, GrupoValidator>(grupo);
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
                _grupoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Pet Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            grupo = _grupoService.Get<Grupo>().ToList();
            dataGridViewConsulta.DataSource = grupo;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Nome"].HeaderText = "Grupo";
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }
    }
}