using ReaLTaiizor.Forms;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.app.Outros
{
    public partial class LoginFornecedor : MaterialForm
    {
        private readonly IBaseService<Fornecedor> _fornecedorService;
        public LoginFornecedor(IBaseService<Fornecedor> fornecedorService)
        {
            _fornecedorService = fornecedorService;
            InitializeComponent();
        }

        private Fornecedor? ObterFornecedor(string email, string senha)
        {
            ChecaExistenciaDeFornecedorCadastrado();
            var fornecedor = _fornecedorService.Get<Fornecedor>().Where(x => x.Email == email).FirstOrDefault();
            if (fornecedor == null)
                return null;
            return fornecedor.Senha != senha ? null : fornecedor;
        }
        private void ChecaExistenciaDeFornecedorCadastrado()
        {
            var fornecedores = _fornecedorService.Get<Fornecedor>().ToList();
            if (!fornecedores.Any())
            {
                var fornecedor = new Fornecedor
                {
                    Email = "fornecedor@gmail.com",
                    Senha = "fornecedor",
                };
                _fornecedorService.Add<Fornecedor, Fornecedor, FornecedorValidator>(fornecedor);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = ObterFornecedor(txtEmail.Text, txtSenha.Text);

            if (fornecedor == null)
            {
                MessageBox.Show("Email e/ou senha inválida!", "Pet Shop",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fornecedor = _fornecedorService.Update<Fornecedor, Fornecedor, FornecedorValidator>(fornecedor);
                FormMenuPrincipal.Fornecedor = fornecedor;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
