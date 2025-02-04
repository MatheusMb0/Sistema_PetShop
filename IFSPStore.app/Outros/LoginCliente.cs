using ReaLTaiizor.Forms;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.app.Outros
{
    public partial class LoginCliente : MaterialForm
    {
        private readonly IBaseService<Cliente> _clienteService;
        public LoginCliente(IBaseService<Cliente> clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }

        private Cliente? ObterCliente(string email, string senha)
        {
            ChecaExistenciaDeClienteCadastrado();
            var cliente = _clienteService.Get<Cliente>().Where(x => x.Email == email).FirstOrDefault();
            if (cliente == null)
                return null;
            return cliente.Senha != senha ? null : cliente;
        }
        private void ChecaExistenciaDeClienteCadastrado()
        {
            var clientes = _clienteService.Get<Cliente>().ToList();
            if (!clientes.Any())
            {
                var cliente = new Cliente
                {
                    Email = "cliente@gmail.com",
                    Senha = "cliente",
                };
                _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = ObterCliente(txtEmail.Text, txtSenha.Text);

            if (cliente == null)
            {
                MessageBox.Show("Email e/ou senha inválida!", "Pet Shop",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                FormMenuPrincipal.Cliente = cliente;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
