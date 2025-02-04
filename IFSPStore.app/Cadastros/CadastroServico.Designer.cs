namespace IFSPStore.app.Cadastros
{
    partial class CadastroServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroServico));
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDuracaoEstimada = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTipoServico = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDisponibilidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtRequisitos = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMateriais = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPreco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(1208, 465);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtPreco);
            tabPageCadastro.Controls.Add(txtMateriais);
            tabPageCadastro.Controls.Add(txtRequisitos);
            tabPageCadastro.Controls.Add(txtDisponibilidade);
            tabPageCadastro.Controls.Add(txtTipoServico);
            tabPageCadastro.Controls.Add(txtDuracaoEstimada);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new Size(1200, 430);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDuracaoEstimada, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTipoServico, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDisponibilidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtRequisitos, 0);
            tabPageCadastro.Controls.SetChildIndex(txtMateriais, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPreco, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(830, 390);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(957, 390);
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
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 24);
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
            txtDescricao.Hint = "Descrição do Serviço";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(6, 107);
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
            txtDescricao.TabIndex = 3;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtDuracaoEstimada
            // 
            txtDuracaoEstimada.AnimateReadOnly = false;
            txtDuracaoEstimada.AutoCompleteMode = AutoCompleteMode.None;
            txtDuracaoEstimada.AutoCompleteSource = AutoCompleteSource.None;
            txtDuracaoEstimada.BackgroundImageLayout = ImageLayout.None;
            txtDuracaoEstimada.CharacterCasing = CharacterCasing.Normal;
            txtDuracaoEstimada.Depth = 0;
            txtDuracaoEstimada.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDuracaoEstimada.HideSelection = true;
            txtDuracaoEstimada.Hint = "Duração estimada do serviço";
            txtDuracaoEstimada.LeadingIcon = null;
            txtDuracaoEstimada.Location = new Point(6, 194);
            txtDuracaoEstimada.MaxLength = 32767;
            txtDuracaoEstimada.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracaoEstimada.Name = "txtDuracaoEstimada";
            txtDuracaoEstimada.PasswordChar = '\0';
            txtDuracaoEstimada.PrefixSuffixText = null;
            txtDuracaoEstimada.ReadOnly = false;
            txtDuracaoEstimada.RightToLeft = RightToLeft.No;
            txtDuracaoEstimada.SelectedText = "";
            txtDuracaoEstimada.SelectionLength = 0;
            txtDuracaoEstimada.SelectionStart = 0;
            txtDuracaoEstimada.ShortcutsEnabled = true;
            txtDuracaoEstimada.Size = new Size(312, 48);
            txtDuracaoEstimada.TabIndex = 4;
            txtDuracaoEstimada.TabStop = false;
            txtDuracaoEstimada.TextAlign = HorizontalAlignment.Left;
            txtDuracaoEstimada.TrailingIcon = null;
            txtDuracaoEstimada.UseSystemPasswordChar = false;
            // 
            // txtTipoServico
            // 
            txtTipoServico.AnimateReadOnly = false;
            txtTipoServico.AutoCompleteMode = AutoCompleteMode.None;
            txtTipoServico.AutoCompleteSource = AutoCompleteSource.None;
            txtTipoServico.BackgroundImageLayout = ImageLayout.None;
            txtTipoServico.CharacterCasing = CharacterCasing.Normal;
            txtTipoServico.Depth = 0;
            txtTipoServico.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTipoServico.HideSelection = true;
            txtTipoServico.Hint = "Tipo do Serviço";
            txtTipoServico.LeadingIcon = null;
            txtTipoServico.Location = new Point(6, 286);
            txtTipoServico.MaxLength = 32767;
            txtTipoServico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTipoServico.Name = "txtTipoServico";
            txtTipoServico.PasswordChar = '\0';
            txtTipoServico.PrefixSuffixText = null;
            txtTipoServico.ReadOnly = false;
            txtTipoServico.RightToLeft = RightToLeft.No;
            txtTipoServico.SelectedText = "";
            txtTipoServico.SelectionLength = 0;
            txtTipoServico.SelectionStart = 0;
            txtTipoServico.ShortcutsEnabled = true;
            txtTipoServico.Size = new Size(312, 48);
            txtTipoServico.TabIndex = 5;
            txtTipoServico.TabStop = false;
            txtTipoServico.TextAlign = HorizontalAlignment.Left;
            txtTipoServico.TrailingIcon = null;
            txtTipoServico.UseSystemPasswordChar = false;
            // 
            // txtDisponibilidade
            // 
            txtDisponibilidade.AnimateReadOnly = false;
            txtDisponibilidade.AutoCompleteMode = AutoCompleteMode.None;
            txtDisponibilidade.AutoCompleteSource = AutoCompleteSource.None;
            txtDisponibilidade.BackgroundImageLayout = ImageLayout.None;
            txtDisponibilidade.CharacterCasing = CharacterCasing.Normal;
            txtDisponibilidade.Depth = 0;
            txtDisponibilidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDisponibilidade.HideSelection = true;
            txtDisponibilidade.Hint = "Disponibilidade de realização";
            txtDisponibilidade.LeadingIcon = null;
            txtDisponibilidade.Location = new Point(402, 24);
            txtDisponibilidade.MaxLength = 32767;
            txtDisponibilidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDisponibilidade.Name = "txtDisponibilidade";
            txtDisponibilidade.PasswordChar = '\0';
            txtDisponibilidade.PrefixSuffixText = null;
            txtDisponibilidade.ReadOnly = false;
            txtDisponibilidade.RightToLeft = RightToLeft.No;
            txtDisponibilidade.SelectedText = "";
            txtDisponibilidade.SelectionLength = 0;
            txtDisponibilidade.SelectionStart = 0;
            txtDisponibilidade.ShortcutsEnabled = true;
            txtDisponibilidade.Size = new Size(312, 48);
            txtDisponibilidade.TabIndex = 6;
            txtDisponibilidade.TabStop = false;
            txtDisponibilidade.TextAlign = HorizontalAlignment.Left;
            txtDisponibilidade.TrailingIcon = null;
            txtDisponibilidade.UseSystemPasswordChar = false;
            // 
            // txtRequisitos
            // 
            txtRequisitos.AnimateReadOnly = false;
            txtRequisitos.AutoCompleteMode = AutoCompleteMode.None;
            txtRequisitos.AutoCompleteSource = AutoCompleteSource.None;
            txtRequisitos.BackgroundImageLayout = ImageLayout.None;
            txtRequisitos.CharacterCasing = CharacterCasing.Normal;
            txtRequisitos.Depth = 0;
            txtRequisitos.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRequisitos.HideSelection = true;
            txtRequisitos.Hint = "Requisitos";
            txtRequisitos.LeadingIcon = null;
            txtRequisitos.Location = new Point(402, 107);
            txtRequisitos.MaxLength = 32767;
            txtRequisitos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtRequisitos.Name = "txtRequisitos";
            txtRequisitos.PasswordChar = '\0';
            txtRequisitos.PrefixSuffixText = null;
            txtRequisitos.ReadOnly = false;
            txtRequisitos.RightToLeft = RightToLeft.No;
            txtRequisitos.SelectedText = "";
            txtRequisitos.SelectionLength = 0;
            txtRequisitos.SelectionStart = 0;
            txtRequisitos.ShortcutsEnabled = true;
            txtRequisitos.Size = new Size(312, 48);
            txtRequisitos.TabIndex = 7;
            txtRequisitos.TabStop = false;
            txtRequisitos.TextAlign = HorizontalAlignment.Left;
            txtRequisitos.TrailingIcon = null;
            txtRequisitos.UseSystemPasswordChar = false;
            // 
            // txtMateriais
            // 
            txtMateriais.AnimateReadOnly = false;
            txtMateriais.AutoCompleteMode = AutoCompleteMode.None;
            txtMateriais.AutoCompleteSource = AutoCompleteSource.None;
            txtMateriais.BackgroundImageLayout = ImageLayout.None;
            txtMateriais.CharacterCasing = CharacterCasing.Normal;
            txtMateriais.Depth = 0;
            txtMateriais.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMateriais.HideSelection = true;
            txtMateriais.Hint = "Materiais Utilizados";
            txtMateriais.LeadingIcon = null;
            txtMateriais.Location = new Point(402, 194);
            txtMateriais.MaxLength = 32767;
            txtMateriais.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMateriais.Name = "txtMateriais";
            txtMateriais.PasswordChar = '\0';
            txtMateriais.PrefixSuffixText = null;
            txtMateriais.ReadOnly = false;
            txtMateriais.RightToLeft = RightToLeft.No;
            txtMateriais.SelectedText = "";
            txtMateriais.SelectionLength = 0;
            txtMateriais.SelectionStart = 0;
            txtMateriais.ShortcutsEnabled = true;
            txtMateriais.Size = new Size(312, 48);
            txtMateriais.TabIndex = 8;
            txtMateriais.TabStop = false;
            txtMateriais.TextAlign = HorizontalAlignment.Left;
            txtMateriais.TrailingIcon = null;
            txtMateriais.UseSystemPasswordChar = false;
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
            txtPreco.Hint = "Preço a pagar pelo serviço";
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(402, 286);
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
            txtPreco.Size = new Size(312, 48);
            txtPreco.TabIndex = 9;
            txtPreco.TabStop = false;
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            // 
            // CadastroServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 553);
            Name = "CadastroServico";
            Text = "CadastroServico";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPreco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMateriais;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtRequisitos;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDisponibilidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTipoServico;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDuracaoEstimada;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}