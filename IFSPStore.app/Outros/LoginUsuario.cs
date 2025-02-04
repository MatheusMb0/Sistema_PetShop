using ReaLTaiizor.Forms;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.app.Outros
{
    public partial class LoginUsuario : MaterialForm
    {
        private readonly IBaseService<Usuario> _usuarioService;
        public LoginUsuario(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObterUsuario(txtEmail.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Email e/ou senha inválida!", "Pet Shop",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                FormMenuPrincipal.Usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private Usuario? ObterUsuario(string email, string senha)
        {
            ChecaExistenciaDeUsuarioCadastrado();
            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Email == email).FirstOrDefault();
            if (usuario == null)
                return null;
            return usuario.Senha != senha ? null : usuario;
        }
        private void ChecaExistenciaDeUsuarioCadastrado()
        {
            var usuarios = _usuarioService.Get<Usuario>().ToList();
            if (!usuarios.Any())
            {
                var usuario = new Usuario
                {
                    Email = "admin@gmail.com",
                    Senha = "admin",
                };
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
