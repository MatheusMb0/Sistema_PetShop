namespace IFSPStore.app.Cadastros
{
    partial class CadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCPF = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtRG = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCargo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtHorarioTrabalho = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dateDataNascimento = new DateTimePicker();
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dateDataContratacao = new DateTimePicker();
            materialTextBoxEdit2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSalario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCidade = new ComboBox();
            materialTextBoxEdit3 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(1608, 525);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboCidade);
            tabPageCadastro.Controls.Add(txtSalario);
            tabPageCadastro.Controls.Add(dateDataContratacao);
            tabPageCadastro.Controls.Add(materialTextBoxEdit2);
            tabPageCadastro.Controls.Add(dateDataNascimento);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtHorarioTrabalho);
            tabPageCadastro.Controls.Add(txtCargo);
            tabPageCadastro.Controls.Add(txtEmail);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtRG);
            tabPageCadastro.Controls.Add(txtCPF);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(materialTextBoxEdit1);
            tabPageCadastro.Controls.Add(materialTextBoxEdit3);
            tabPageCadastro.Size = new Size(1600, 490);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit3, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit1, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCPF, 0);
            tabPageCadastro.Controls.SetChildIndex(txtRG, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEndereco, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBairro, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCargo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtHorarioTrabalho, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(dateDataNascimento, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit2, 0);
            tabPageCadastro.Controls.SetChildIndex(dateDataContratacao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtSalario, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCidade, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1184, 446);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1311, 446);
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            imageList1.Images.SetKeyName(2, "Seat - Icon.png");
            imageList1.Images.SetKeyName(3, "Rota - Icon.png");
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 21);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(312, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtCPF
            // 
            txtCPF.AnimateReadOnly = false;
            txtCPF.AutoCompleteMode = AutoCompleteMode.None;
            txtCPF.AutoCompleteSource = AutoCompleteSource.None;
            txtCPF.BackgroundImageLayout = ImageLayout.None;
            txtCPF.CharacterCasing = CharacterCasing.Normal;
            txtCPF.Depth = 0;
            txtCPF.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCPF.HideSelection = true;
            txtCPF.Hint = "CPF";
            txtCPF.LeadingIcon = null;
            txtCPF.Location = new Point(6, 96);
            txtCPF.MaxLength = 32767;
            txtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCPF.Name = "txtCPF";
            txtCPF.PasswordChar = '\0';
            txtCPF.PrefixSuffixText = null;
            txtCPF.ReadOnly = false;
            txtCPF.RightToLeft = RightToLeft.No;
            txtCPF.SelectedText = "";
            txtCPF.SelectionLength = 0;
            txtCPF.SelectionStart = 0;
            txtCPF.ShortcutsEnabled = true;
            txtCPF.Size = new Size(312, 48);
            txtCPF.TabIndex = 3;
            txtCPF.TabStop = false;
            txtCPF.TextAlign = HorizontalAlignment.Left;
            txtCPF.TrailingIcon = null;
            txtCPF.UseSystemPasswordChar = false;
            // 
            // txtRG
            // 
            txtRG.AnimateReadOnly = false;
            txtRG.AutoCompleteMode = AutoCompleteMode.None;
            txtRG.AutoCompleteSource = AutoCompleteSource.None;
            txtRG.BackgroundImageLayout = ImageLayout.None;
            txtRG.CharacterCasing = CharacterCasing.Normal;
            txtRG.Depth = 0;
            txtRG.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRG.HideSelection = true;
            txtRG.Hint = "RG";
            txtRG.LeadingIcon = null;
            txtRG.Location = new Point(6, 180);
            txtRG.MaxLength = 32767;
            txtRG.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtRG.Name = "txtRG";
            txtRG.PasswordChar = '\0';
            txtRG.PrefixSuffixText = null;
            txtRG.ReadOnly = false;
            txtRG.RightToLeft = RightToLeft.No;
            txtRG.SelectedText = "";
            txtRG.SelectionLength = 0;
            txtRG.SelectionStart = 0;
            txtRG.ShortcutsEnabled = true;
            txtRG.Size = new Size(312, 48);
            txtRG.TabIndex = 4;
            txtRG.TabStop = false;
            txtRG.TextAlign = HorizontalAlignment.Left;
            txtRG.TrailingIcon = null;
            txtRG.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(6, 278);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(312, 48);
            txtEndereco.TabIndex = 5;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(6, 373);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(312, 48);
            txtBairro.TabIndex = 6;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AutoCompleteMode = AutoCompleteMode.None;
            txtTelefone.AutoCompleteSource = AutoCompleteSource.None;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.CharacterCasing = CharacterCasing.Normal;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(400, 21);
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.ReadOnly = false;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(312, 48);
            txtTelefone.TabIndex = 7;
            txtTelefone.TabStop = false;
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(400, 96);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(312, 48);
            txtEmail.TabIndex = 8;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtCargo
            // 
            txtCargo.AnimateReadOnly = false;
            txtCargo.AutoCompleteMode = AutoCompleteMode.None;
            txtCargo.AutoCompleteSource = AutoCompleteSource.None;
            txtCargo.BackgroundImageLayout = ImageLayout.None;
            txtCargo.CharacterCasing = CharacterCasing.Normal;
            txtCargo.Depth = 0;
            txtCargo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCargo.HideSelection = true;
            txtCargo.Hint = "Cargo";
            txtCargo.LeadingIcon = null;
            txtCargo.Location = new Point(400, 180);
            txtCargo.MaxLength = 32767;
            txtCargo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCargo.Name = "txtCargo";
            txtCargo.PasswordChar = '\0';
            txtCargo.PrefixSuffixText = null;
            txtCargo.ReadOnly = false;
            txtCargo.RightToLeft = RightToLeft.No;
            txtCargo.SelectedText = "";
            txtCargo.SelectionLength = 0;
            txtCargo.SelectionStart = 0;
            txtCargo.ShortcutsEnabled = true;
            txtCargo.Size = new Size(312, 48);
            txtCargo.TabIndex = 9;
            txtCargo.TabStop = false;
            txtCargo.TextAlign = HorizontalAlignment.Left;
            txtCargo.TrailingIcon = null;
            txtCargo.UseSystemPasswordChar = false;
            // 
            // txtHorarioTrabalho
            // 
            txtHorarioTrabalho.AnimateReadOnly = false;
            txtHorarioTrabalho.AutoCompleteMode = AutoCompleteMode.None;
            txtHorarioTrabalho.AutoCompleteSource = AutoCompleteSource.None;
            txtHorarioTrabalho.BackgroundImageLayout = ImageLayout.None;
            txtHorarioTrabalho.CharacterCasing = CharacterCasing.Normal;
            txtHorarioTrabalho.Depth = 0;
            txtHorarioTrabalho.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHorarioTrabalho.HideSelection = true;
            txtHorarioTrabalho.Hint = "Horário de Trabalho";
            txtHorarioTrabalho.LeadingIcon = null;
            txtHorarioTrabalho.Location = new Point(400, 278);
            txtHorarioTrabalho.MaxLength = 32767;
            txtHorarioTrabalho.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHorarioTrabalho.Name = "txtHorarioTrabalho";
            txtHorarioTrabalho.PasswordChar = '\0';
            txtHorarioTrabalho.PrefixSuffixText = null;
            txtHorarioTrabalho.ReadOnly = false;
            txtHorarioTrabalho.RightToLeft = RightToLeft.No;
            txtHorarioTrabalho.SelectedText = "";
            txtHorarioTrabalho.SelectionLength = 0;
            txtHorarioTrabalho.SelectionStart = 0;
            txtHorarioTrabalho.ShortcutsEnabled = true;
            txtHorarioTrabalho.Size = new Size(312, 48);
            txtHorarioTrabalho.TabIndex = 10;
            txtHorarioTrabalho.TabStop = false;
            txtHorarioTrabalho.TextAlign = HorizontalAlignment.Left;
            txtHorarioTrabalho.TrailingIcon = null;
            txtHorarioTrabalho.UseSystemPasswordChar = false;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(400, 373);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(312, 48);
            txtDescricao.TabIndex = 11;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // dateDataNascimento
            // 
            dateDataNascimento.Font = new Font("Segoe UI", 11F);
            dateDataNascimento.Format = DateTimePickerFormat.Short;
            dateDataNascimento.Location = new Point(792, 62);
            dateDataNascimento.Name = "dateDataNascimento";
            dateDataNascimento.Size = new Size(188, 32);
            dateDataNascimento.TabIndex = 12;
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.Hint = "Data de Nascimento";
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(792, 21);
            materialTextBoxEdit1.MaxLength = 32767;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(188, 48);
            materialTextBoxEdit1.TabIndex = 13;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // dateDataContratacao
            // 
            dateDataContratacao.Font = new Font("Segoe UI", 11F);
            dateDataContratacao.Format = DateTimePickerFormat.Short;
            dateDataContratacao.Location = new Point(792, 172);
            dateDataContratacao.Name = "dateDataContratacao";
            dateDataContratacao.Size = new Size(188, 32);
            dateDataContratacao.TabIndex = 14;
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
            materialTextBoxEdit2.Hint = "Data de Contratação";
            materialTextBoxEdit2.LeadingIcon = null;
            materialTextBoxEdit2.Location = new Point(792, 131);
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
            materialTextBoxEdit2.Size = new Size(188, 48);
            materialTextBoxEdit2.TabIndex = 15;
            materialTextBoxEdit2.TabStop = false;
            materialTextBoxEdit2.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit2.TrailingIcon = null;
            materialTextBoxEdit2.UseSystemPasswordChar = false;
            // 
            // txtSalario
            // 
            txtSalario.AnimateReadOnly = false;
            txtSalario.AutoCompleteMode = AutoCompleteMode.None;
            txtSalario.AutoCompleteSource = AutoCompleteSource.None;
            txtSalario.BackgroundImageLayout = ImageLayout.None;
            txtSalario.CharacterCasing = CharacterCasing.Normal;
            txtSalario.Depth = 0;
            txtSalario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalario.HideSelection = true;
            txtSalario.Hint = "Salário";
            txtSalario.LeadingIcon = null;
            txtSalario.Location = new Point(792, 261);
            txtSalario.MaxLength = 32767;
            txtSalario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSalario.Name = "txtSalario";
            txtSalario.PasswordChar = '\0';
            txtSalario.PrefixSuffixText = null;
            txtSalario.ReadOnly = false;
            txtSalario.RightToLeft = RightToLeft.No;
            txtSalario.SelectedText = "";
            txtSalario.SelectionLength = 0;
            txtSalario.SelectionStart = 0;
            txtSalario.ShortcutsEnabled = true;
            txtSalario.Size = new Size(188, 48);
            txtSalario.TabIndex = 16;
            txtSalario.TabStop = false;
            txtSalario.TextAlign = HorizontalAlignment.Left;
            txtSalario.TrailingIcon = null;
            txtSalario.UseSystemPasswordChar = false;
            // 
            // cboCidade
            // 
            cboCidade.Font = new Font("Segoe UI", 11F);
            cboCidade.FormattingEnabled = true;
            cboCidade.Location = new Point(1048, 62);
            cboCidade.Name = "cboCidade";
            cboCidade.Size = new Size(151, 33);
            cboCidade.TabIndex = 17;
            // 
            // materialTextBoxEdit3
            // 
            materialTextBoxEdit3.AnimateReadOnly = false;
            materialTextBoxEdit3.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit3.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit3.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit3.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit3.Depth = 0;
            materialTextBoxEdit3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit3.HideSelection = true;
            materialTextBoxEdit3.Hint = "Cidade";
            materialTextBoxEdit3.LeadingIcon = null;
            materialTextBoxEdit3.Location = new Point(1048, 21);
            materialTextBoxEdit3.MaxLength = 32767;
            materialTextBoxEdit3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit3.Name = "materialTextBoxEdit3";
            materialTextBoxEdit3.PasswordChar = '\0';
            materialTextBoxEdit3.PrefixSuffixText = null;
            materialTextBoxEdit3.ReadOnly = false;
            materialTextBoxEdit3.RightToLeft = RightToLeft.No;
            materialTextBoxEdit3.SelectedText = "";
            materialTextBoxEdit3.SelectionLength = 0;
            materialTextBoxEdit3.SelectionStart = 0;
            materialTextBoxEdit3.ShortcutsEnabled = true;
            materialTextBoxEdit3.Size = new Size(151, 48);
            materialTextBoxEdit3.TabIndex = 18;
            materialTextBoxEdit3.TabStop = false;
            materialTextBoxEdit3.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit3.TrailingIcon = null;
            materialTextBoxEdit3.UseSystemPasswordChar = false;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1611, 613);
            Name = "CadastroFuncionario";
            Text = "Cadastro de Funcionarios";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateDataNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtHorarioTrabalho;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCargo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtRG;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCPF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private DateTimePicker dateDataContratacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ComboBox cboCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSalario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit3;
    }
}