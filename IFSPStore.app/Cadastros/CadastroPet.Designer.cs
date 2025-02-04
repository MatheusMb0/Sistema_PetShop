namespace IFSPStore.app.Cadastros
{
    partial class CadastroPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPet));
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTipoPet = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtRaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPeso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit8 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dateDataNascimento = new DateTimePicker();
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCliente = new ComboBox();
            cboSexo = new ComboBox();
            materialTextBoxEdit2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(1267, 449);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboSexo);
            tabPageCadastro.Controls.Add(materialTextBoxEdit2);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(dateDataNascimento);
            tabPageCadastro.Controls.Add(txtPeso);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtCor);
            tabPageCadastro.Controls.Add(txtRaca);
            tabPageCadastro.Controls.Add(txtTipoPet);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(materialTextBoxEdit8);
            tabPageCadastro.Controls.Add(materialTextBoxEdit1);
            tabPageCadastro.Size = new Size(1259, 414);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit1, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit8, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTipoPet, 0);
            tabPageCadastro.Controls.SetChildIndex(txtRaca, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCor, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPeso, 0);
            tabPageCadastro.Controls.SetChildIndex(dateDataNascimento, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit2, 0);
            tabPageCadastro.Controls.SetChildIndex(cboSexo, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(890, 373);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1017, 373);
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
            txtNome.Location = new Point(6, 23);
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
            // txtTipoPet
            // 
            txtTipoPet.AnimateReadOnly = false;
            txtTipoPet.AutoCompleteMode = AutoCompleteMode.None;
            txtTipoPet.AutoCompleteSource = AutoCompleteSource.None;
            txtTipoPet.BackgroundImageLayout = ImageLayout.None;
            txtTipoPet.CharacterCasing = CharacterCasing.Normal;
            txtTipoPet.Depth = 0;
            txtTipoPet.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTipoPet.HideSelection = true;
            txtTipoPet.Hint = "Espécie";
            txtTipoPet.LeadingIcon = null;
            txtTipoPet.Location = new Point(6, 96);
            txtTipoPet.MaxLength = 32767;
            txtTipoPet.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTipoPet.Name = "txtTipoPet";
            txtTipoPet.PasswordChar = '\0';
            txtTipoPet.PrefixSuffixText = null;
            txtTipoPet.ReadOnly = false;
            txtTipoPet.RightToLeft = RightToLeft.No;
            txtTipoPet.SelectedText = "";
            txtTipoPet.SelectionLength = 0;
            txtTipoPet.SelectionStart = 0;
            txtTipoPet.ShortcutsEnabled = true;
            txtTipoPet.Size = new Size(312, 48);
            txtTipoPet.TabIndex = 3;
            txtTipoPet.TabStop = false;
            txtTipoPet.TextAlign = HorizontalAlignment.Left;
            txtTipoPet.TrailingIcon = null;
            txtTipoPet.UseSystemPasswordChar = false;
            // 
            // txtRaca
            // 
            txtRaca.AnimateReadOnly = false;
            txtRaca.AutoCompleteMode = AutoCompleteMode.None;
            txtRaca.AutoCompleteSource = AutoCompleteSource.None;
            txtRaca.BackgroundImageLayout = ImageLayout.None;
            txtRaca.CharacterCasing = CharacterCasing.Normal;
            txtRaca.Depth = 0;
            txtRaca.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRaca.HideSelection = true;
            txtRaca.Hint = "Raça";
            txtRaca.LeadingIcon = null;
            txtRaca.Location = new Point(6, 182);
            txtRaca.MaxLength = 32767;
            txtRaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtRaca.Name = "txtRaca";
            txtRaca.PasswordChar = '\0';
            txtRaca.PrefixSuffixText = null;
            txtRaca.ReadOnly = false;
            txtRaca.RightToLeft = RightToLeft.No;
            txtRaca.SelectedText = "";
            txtRaca.SelectionLength = 0;
            txtRaca.SelectionStart = 0;
            txtRaca.ShortcutsEnabled = true;
            txtRaca.Size = new Size(312, 48);
            txtRaca.TabIndex = 4;
            txtRaca.TabStop = false;
            txtRaca.TextAlign = HorizontalAlignment.Left;
            txtRaca.TrailingIcon = null;
            txtRaca.UseSystemPasswordChar = false;
            // 
            // txtCor
            // 
            txtCor.AnimateReadOnly = false;
            txtCor.AutoCompleteMode = AutoCompleteMode.None;
            txtCor.AutoCompleteSource = AutoCompleteSource.None;
            txtCor.BackgroundImageLayout = ImageLayout.None;
            txtCor.CharacterCasing = CharacterCasing.Normal;
            txtCor.Depth = 0;
            txtCor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCor.HideSelection = true;
            txtCor.Hint = "Cor";
            txtCor.LeadingIcon = null;
            txtCor.Location = new Point(6, 264);
            txtCor.MaxLength = 32767;
            txtCor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCor.Name = "txtCor";
            txtCor.PasswordChar = '\0';
            txtCor.PrefixSuffixText = null;
            txtCor.ReadOnly = false;
            txtCor.RightToLeft = RightToLeft.No;
            txtCor.SelectedText = "";
            txtCor.SelectionLength = 0;
            txtCor.SelectionStart = 0;
            txtCor.ShortcutsEnabled = true;
            txtCor.Size = new Size(312, 48);
            txtCor.TabIndex = 6;
            txtCor.TabStop = false;
            txtCor.TextAlign = HorizontalAlignment.Left;
            txtCor.TrailingIcon = null;
            txtCor.UseSystemPasswordChar = false;
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
            txtDescricao.Location = new Point(398, 23);
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
            txtDescricao.TabIndex = 7;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtPeso
            // 
            txtPeso.AnimateReadOnly = false;
            txtPeso.AutoCompleteMode = AutoCompleteMode.None;
            txtPeso.AutoCompleteSource = AutoCompleteSource.None;
            txtPeso.BackgroundImageLayout = ImageLayout.None;
            txtPeso.CharacterCasing = CharacterCasing.Normal;
            txtPeso.Depth = 0;
            txtPeso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPeso.HideSelection = true;
            txtPeso.Hint = "Peso (Kg)";
            txtPeso.LeadingIcon = null;
            txtPeso.Location = new Point(398, 96);
            txtPeso.MaxLength = 32767;
            txtPeso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeso.Name = "txtPeso";
            txtPeso.PasswordChar = '\0';
            txtPeso.PrefixSuffixText = null;
            txtPeso.ReadOnly = false;
            txtPeso.RightToLeft = RightToLeft.No;
            txtPeso.SelectedText = "";
            txtPeso.SelectionLength = 0;
            txtPeso.SelectionStart = 0;
            txtPeso.ShortcutsEnabled = true;
            txtPeso.Size = new Size(312, 48);
            txtPeso.TabIndex = 8;
            txtPeso.TabStop = false;
            txtPeso.TextAlign = HorizontalAlignment.Left;
            txtPeso.TrailingIcon = null;
            txtPeso.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit8
            // 
            materialTextBoxEdit8.AnimateReadOnly = false;
            materialTextBoxEdit8.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit8.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit8.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit8.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit8.Depth = 0;
            materialTextBoxEdit8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit8.HideSelection = true;
            materialTextBoxEdit8.Hint = "Data de Nascimento";
            materialTextBoxEdit8.LeadingIcon = null;
            materialTextBoxEdit8.Location = new Point(398, 273);
            materialTextBoxEdit8.MaxLength = 32767;
            materialTextBoxEdit8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit8.Name = "materialTextBoxEdit8";
            materialTextBoxEdit8.PasswordChar = '\0';
            materialTextBoxEdit8.PrefixSuffixText = null;
            materialTextBoxEdit8.ReadOnly = false;
            materialTextBoxEdit8.RightToLeft = RightToLeft.No;
            materialTextBoxEdit8.SelectedText = "";
            materialTextBoxEdit8.SelectionLength = 0;
            materialTextBoxEdit8.SelectionStart = 0;
            materialTextBoxEdit8.ShortcutsEnabled = true;
            materialTextBoxEdit8.Size = new Size(172, 48);
            materialTextBoxEdit8.TabIndex = 9;
            materialTextBoxEdit8.TabStop = false;
            materialTextBoxEdit8.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit8.TrailingIcon = null;
            materialTextBoxEdit8.UseSystemPasswordChar = false;
            // 
            // dateDataNascimento
            // 
            dateDataNascimento.Font = new Font("Segoe UI", 11F);
            dateDataNascimento.Format = DateTimePickerFormat.Short;
            dateDataNascimento.Location = new Point(398, 315);
            dateDataNascimento.Name = "dateDataNascimento";
            dateDataNascimento.Size = new Size(172, 32);
            dateDataNascimento.TabIndex = 10;
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
            materialTextBoxEdit1.Hint = "Dono";
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(608, 273);
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
            materialTextBoxEdit1.Size = new Size(185, 48);
            materialTextBoxEdit1.TabIndex = 11;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // cboCliente
            // 
            cboCliente.Font = new Font("Segoe UI", 11F);
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(608, 314);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(185, 33);
            cboCliente.TabIndex = 12;
            // 
            // cboSexo
            // 
            cboSexo.Font = new Font("Segoe UI", 11F);
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Macho", "Fêmea" });
            cboSexo.Location = new Point(398, 213);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(151, 33);
            cboSexo.TabIndex = 14;
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
            materialTextBoxEdit2.Hint = "Sexo";
            materialTextBoxEdit2.LeadingIcon = null;
            materialTextBoxEdit2.Location = new Point(398, 172);
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
            materialTextBoxEdit2.TabIndex = 13;
            materialTextBoxEdit2.TabStop = false;
            materialTextBoxEdit2.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit2.TrailingIcon = null;
            materialTextBoxEdit2.UseSystemPasswordChar = false;
            // 
            // CadastroPet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 537);
            Name = "CadastroPet";
            Text = "Cadastro de Pets";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private DateTimePicker dateDataNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtRaca;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTipoPet;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit8;
        private ComboBox cboCliente;
        private ComboBox cboSexo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
    }
}