using IFSPStore.app.Cadastros;
using IFSPStore.app.Infra;
using IFSPStore.app.Outros;
using IFSPStore.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using MySqlConnector.Logging;
using ReaLTaiizor.Forms;

namespace IFSPStore.app
{
    public partial class FormMenuPrincipal : MaterialForm
    {
        public bool logadoCliente = false;
        public static Usuario Usuario { get; set; }
        public static Cliente Cliente { get; set; }
        public static Fornecedor Fornecedor { get; set; }
        public FormMenuPrincipal()
        {
            InitializeComponent();
            
            DialogResult result = MessageBox.Show(
            "Escolha o tipo de login:\n\nSim = Usuário\nNão = Fornecedor\nCancelar = Cliente",
            "Login",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
        );

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Você escolheu entrar como Usuário.");
                    CarregaLoginUsuario();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Você escolheu entrar como Fornecedor.");
                    CarregaLoginFornecedor();
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Você escolheu entrar como Cliente.");
                    CarregaLoginCliente();
                    break;
                default:
                    MessageBox.Show("Nenhuma opção foi selecionada.");
                    break;
            }
        }

        private void CarregaLoginUsuario()
        {
            var loginUsuario = ConfigureDI.ServicesProvider!.GetService<LoginUsuario>();
            if (loginUsuario != null && !loginUsuario.IsDisposed)
            {
                if (loginUsuario.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                /*else
                {
                    lblUsuario.Text = $"Email: {Usuario.Email}";
                }*/
            }
        }

        private void CarregaLoginCliente()
        {
            var loginCliente = ConfigureDI.ServicesProvider!.GetService<LoginCliente>();
            if (loginCliente != null && !loginCliente.IsDisposed)
            {
                if (loginCliente.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                /*else
                {
                    lblUsuario.Text = $"Email: {Usuario.Email}";
                }*/
            }
        }

        private void CarregaLoginFornecedor()
        {
            var loginFornecedor = ConfigureDI.ServicesProvider!.GetService<LoginFornecedor>();
            if (loginFornecedor != null && !loginFornecedor.IsDisposed)
            {
                if (loginFornecedor.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                /*else
                {
                    lblUsuario.Text = $"Email: {Usuario.Email}";
                }*/
            }
        }
        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCidade>();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFornecedor>();
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroGrupo>();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroProduto>();
        }

        private void petToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroPet>();
        }

        private void Pet_ServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroPet_Servico>();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCliente>();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFuncionario>();
        }

        private void Funcionario_ServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFuncionario_Servico>();
        }

        private void veterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroVeterinario>();
        }

        private void Veterinario_ServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroVeterinario_Servico>();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroUsuario>();
        }

        private void servicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroServico>();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroVenda>();
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            foreach (Form openForm in MdiChildren)
            {
                openForm.Close();
            }

            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
