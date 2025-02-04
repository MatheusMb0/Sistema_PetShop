namespace IFSPStore.app.Cadastros
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUnidadeVenda = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dateDataCompra = new DateTimePicker();
            materialTextBoxEdit5 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPreco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit7 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit8 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboGrupo = new ComboBox();
            cboFornecedor = new ComboBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(1063, 457);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboFornecedor);
            tabPageCadastro.Controls.Add(cboGrupo);
            tabPageCadastro.Controls.Add(txtPreco);
            tabPageCadastro.Controls.Add(dateDataCompra);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtUnidadeVenda);
            tabPageCadastro.Controls.Add(txtQuantidade);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(materialTextBoxEdit5);
            tabPageCadastro.Controls.Add(materialTextBoxEdit7);
            tabPageCadastro.Controls.Add(materialTextBoxEdit8);
            tabPageCadastro.Size = new Size(1055, 422);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit8, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit7, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit5, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtQuantidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtUnidadeVenda, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(dateDataCompra, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPreco, 0);
            tabPageCadastro.Controls.SetChildIndex(cboGrupo, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFornecedor, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(686, 383);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(813, 383);
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
            txtNome.Hint = "Produto";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 28);
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
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Quantidade do produto";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(6, 108);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(312, 48);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.AnimateReadOnly = false;
            txtUnidadeVenda.AutoCompleteMode = AutoCompleteMode.None;
            txtUnidadeVenda.AutoCompleteSource = AutoCompleteSource.None;
            txtUnidadeVenda.BackgroundImageLayout = ImageLayout.None;
            txtUnidadeVenda.CharacterCasing = CharacterCasing.Normal;
            txtUnidadeVenda.Depth = 0;
            txtUnidadeVenda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnidadeVenda.HideSelection = true;
            txtUnidadeVenda.Hint = "Unidade de Venda do produto";
            txtUnidadeVenda.LeadingIcon = null;
            txtUnidadeVenda.Location = new Point(6, 192);
            txtUnidadeVenda.MaxLength = 32767;
            txtUnidadeVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PasswordChar = '\0';
            txtUnidadeVenda.PrefixSuffixText = null;
            txtUnidadeVenda.ReadOnly = false;
            txtUnidadeVenda.RightToLeft = RightToLeft.No;
            txtUnidadeVenda.SelectedText = "";
            txtUnidadeVenda.SelectionLength = 0;
            txtUnidadeVenda.SelectionStart = 0;
            txtUnidadeVenda.ShortcutsEnabled = true;
            txtUnidadeVenda.Size = new Size(312, 48);
            txtUnidadeVenda.TabIndex = 4;
            txtUnidadeVenda.TabStop = false;
            txtUnidadeVenda.TextAlign = HorizontalAlignment.Left;
            txtUnidadeVenda.TrailingIcon = null;
            txtUnidadeVenda.UseSystemPasswordChar = false;
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
            txtDescricao.Hint = "Descrição do produto";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(6, 280);
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
            txtDescricao.TabIndex = 5;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // dateDataCompra
            // 
            dateDataCompra.Font = new Font("Segoe UI", 11F);
            dateDataCompra.Format = DateTimePickerFormat.Short;
            dateDataCompra.Location = new Point(409, 60);
            dateDataCompra.Name = "dateDataCompra";
            dateDataCompra.Size = new Size(185, 32);
            dateDataCompra.TabIndex = 6;
            // 
            // materialTextBoxEdit5
            // 
            materialTextBoxEdit5.AnimateReadOnly = false;
            materialTextBoxEdit5.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit5.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit5.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit5.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit5.Depth = 0;
            materialTextBoxEdit5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit5.HideSelection = true;
            materialTextBoxEdit5.Hint = "Data do fornecimento";
            materialTextBoxEdit5.LeadingIcon = null;
            materialTextBoxEdit5.Location = new Point(409, 28);
            materialTextBoxEdit5.MaxLength = 32767;
            materialTextBoxEdit5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit5.Name = "materialTextBoxEdit5";
            materialTextBoxEdit5.PasswordChar = '\0';
            materialTextBoxEdit5.PrefixSuffixText = null;
            materialTextBoxEdit5.ReadOnly = false;
            materialTextBoxEdit5.RightToLeft = RightToLeft.No;
            materialTextBoxEdit5.SelectedText = "";
            materialTextBoxEdit5.SelectionLength = 0;
            materialTextBoxEdit5.SelectionStart = 0;
            materialTextBoxEdit5.ShortcutsEnabled = true;
            materialTextBoxEdit5.Size = new Size(185, 48);
            materialTextBoxEdit5.TabIndex = 7;
            materialTextBoxEdit5.TabStop = false;
            materialTextBoxEdit5.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit5.TrailingIcon = null;
            materialTextBoxEdit5.UseSystemPasswordChar = false;
            // 
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.AutoCompleteMode = AutoCompleteMode.None;
            txtPreco.AutoCompleteSource = AutoCompleteSource.None;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.CharacterCasing = CharacterCasing.Normal;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Valor do fornecimento";
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(409, 108);
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.ReadOnly = false;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(262, 48);
            txtPreco.TabIndex = 8;
            txtPreco.TabStop = false;
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit7
            // 
            materialTextBoxEdit7.AnimateReadOnly = false;
            materialTextBoxEdit7.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit7.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit7.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit7.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit7.Depth = 0;
            materialTextBoxEdit7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit7.HideSelection = true;
            materialTextBoxEdit7.Hint = "Grupo";
            materialTextBoxEdit7.LeadingIcon = null;
            materialTextBoxEdit7.Location = new Point(384, 192);
            materialTextBoxEdit7.MaxLength = 32767;
            materialTextBoxEdit7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit7.Name = "materialTextBoxEdit7";
            materialTextBoxEdit7.PasswordChar = '\0';
            materialTextBoxEdit7.PrefixSuffixText = null;
            materialTextBoxEdit7.ReadOnly = false;
            materialTextBoxEdit7.RightToLeft = RightToLeft.No;
            materialTextBoxEdit7.SelectedText = "";
            materialTextBoxEdit7.SelectionLength = 0;
            materialTextBoxEdit7.SelectionStart = 0;
            materialTextBoxEdit7.ShortcutsEnabled = true;
            materialTextBoxEdit7.Size = new Size(151, 48);
            materialTextBoxEdit7.TabIndex = 9;
            materialTextBoxEdit7.TabStop = false;
            materialTextBoxEdit7.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit7.TrailingIcon = null;
            materialTextBoxEdit7.UseSystemPasswordChar = false;
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
            materialTextBoxEdit8.Hint = "Fornecedor";
            materialTextBoxEdit8.LeadingIcon = null;
            materialTextBoxEdit8.Location = new Point(586, 192);
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
            materialTextBoxEdit8.Size = new Size(170, 48);
            materialTextBoxEdit8.TabIndex = 10;
            materialTextBoxEdit8.TabStop = false;
            materialTextBoxEdit8.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit8.TrailingIcon = null;
            materialTextBoxEdit8.UseSystemPasswordChar = false;
            // 
            // cboGrupo
            // 
            cboGrupo.Font = new Font("Segoe UI", 11F);
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Location = new Point(384, 223);
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(151, 33);
            cboGrupo.TabIndex = 11;
            // 
            // cboFornecedor
            // 
            cboFornecedor.Font = new Font("Segoe UI", 11F);
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Location = new Point(586, 228);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(170, 33);
            cboFornecedor.TabIndex = 12;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 545);
            Name = "CadastroProduto";
            Text = "Cadastro de Produtos";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboFornecedor;
        private ComboBox cboGrupo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPreco;
        private DateTimePicker dateDataCompra;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUnidadeVenda;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit5;
    }
}