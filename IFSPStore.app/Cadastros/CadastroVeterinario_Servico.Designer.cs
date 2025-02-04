namespace IFSPStore.app.Cadastros
{
    partial class CadastroVeterinario_Servico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVeterinario_Servico));
            txtVeterinario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboVeterinario = new ComboBox();
            cboServico = new ComboBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(813, 329);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboServico);
            tabPageCadastro.Controls.Add(cboVeterinario);
            tabPageCadastro.Controls.Add(materialTextBoxEdit2);
            tabPageCadastro.Controls.Add(txtVeterinario);
            tabPageCadastro.Size = new Size(805, 294);
            tabPageCadastro.Controls.SetChildIndex(txtVeterinario, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit2, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(cboVeterinario, 0);
            tabPageCadastro.Controls.SetChildIndex(cboServico, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(453, 254);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(580, 254);
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            imageList1.Images.SetKeyName(2, "Seat - Icon.png");
            imageList1.Images.SetKeyName(3, "Rota - Icon.png");
            // 
            // txtVeterinario
            // 
            txtVeterinario.AnimateReadOnly = false;
            txtVeterinario.AutoCompleteMode = AutoCompleteMode.None;
            txtVeterinario.AutoCompleteSource = AutoCompleteSource.None;
            txtVeterinario.BackgroundImageLayout = ImageLayout.None;
            txtVeterinario.CharacterCasing = CharacterCasing.Normal;
            txtVeterinario.Depth = 0;
            txtVeterinario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVeterinario.HideSelection = true;
            txtVeterinario.Hint = "Veterinário";
            txtVeterinario.LeadingIcon = null;
            txtVeterinario.Location = new Point(30, 41);
            txtVeterinario.MaxLength = 32767;
            txtVeterinario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtVeterinario.Name = "txtVeterinario";
            txtVeterinario.PasswordChar = '\0';
            txtVeterinario.PrefixSuffixText = null;
            txtVeterinario.ReadOnly = false;
            txtVeterinario.RightToLeft = RightToLeft.No;
            txtVeterinario.SelectedText = "";
            txtVeterinario.SelectionLength = 0;
            txtVeterinario.SelectionStart = 0;
            txtVeterinario.ShortcutsEnabled = true;
            txtVeterinario.Size = new Size(195, 48);
            txtVeterinario.TabIndex = 2;
            txtVeterinario.TabStop = false;
            txtVeterinario.TextAlign = HorizontalAlignment.Left;
            txtVeterinario.TrailingIcon = null;
            txtVeterinario.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit2
            // 
            materialTextBoxEdit2.AnimateReadOnly = false;
            materialTextBoxEdit2.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit2.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit2.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit2.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit2.Depth = 0;
            materialTextBoxEdit2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit2.HideSelection = true;
            materialTextBoxEdit2.Hint = "Serviço desejado";
            materialTextBoxEdit2.LeadingIcon = null;
            materialTextBoxEdit2.Location = new Point(318, 41);
            materialTextBoxEdit2.MaxLength = 32767;
            materialTextBoxEdit2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit2.Name = "materialTextBoxEdit2";
            materialTextBoxEdit2.PasswordChar = '\0';
            materialTextBoxEdit2.PrefixSuffixText = null;
            materialTextBoxEdit2.ReadOnly = false;
            materialTextBoxEdit2.RightToLeft = RightToLeft.No;
            materialTextBoxEdit2.SelectedText = "";
            materialTextBoxEdit2.SelectionLength = 0;
            materialTextBoxEdit2.SelectionStart = 0;
            materialTextBoxEdit2.ShortcutsEnabled = true;
            materialTextBoxEdit2.Size = new Size(151, 48);
            materialTextBoxEdit2.TabIndex = 3;
            materialTextBoxEdit2.TabStop = false;
            materialTextBoxEdit2.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit2.TrailingIcon = null;
            materialTextBoxEdit2.UseSystemPasswordChar = false;
            // 
            // cboVeterinario
            // 
            cboVeterinario.Font = new Font("Segoe UI", 11F);
            cboVeterinario.FormattingEnabled = true;
            cboVeterinario.Location = new Point(30, 78);
            cboVeterinario.Name = "cboVeterinario";
            cboVeterinario.Size = new Size(195, 33);
            cboVeterinario.TabIndex = 4;
            // 
            // cboServico
            // 
            cboServico.Font = new Font("Segoe UI", 11F);
            cboServico.FormattingEnabled = true;
            cboServico.Location = new Point(318, 78);
            cboServico.Name = "cboServico";
            cboServico.Size = new Size(151, 33);
            cboServico.TabIndex = 5;
            // 
            // CadastroVeterinario_Servico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 417);
            Name = "CadastroVeterinario_Servico";
            Text = "Cadastro de serviços com veterinários";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboServico;
        private ComboBox cboVeterinario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtVeterinario;
    }
}