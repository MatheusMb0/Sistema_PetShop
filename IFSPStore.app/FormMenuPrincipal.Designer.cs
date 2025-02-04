namespace IFSPStore.app
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            toolStripMenuItem2 = new ToolStripSeparator();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            grupoToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            petToolStripMenuItem = new ToolStripMenuItem();
            Pet_ServicoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            funcionarioToolStripMenuItem = new ToolStripMenuItem();
            Funcionario_ServicoToolStripMenuItem = new ToolStripMenuItem();
            veterinarioToolStripMenuItem = new ToolStripMenuItem();
            Veterinario_ServicoToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            servicoToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 85);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(908, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cidadeToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, fornecedorToolStripMenuItem, petToolStripMenuItem, toolStripMenuItem3, clienteToolStripMenuItem, funcionarioToolStripMenuItem, veterinarioToolStripMenuItem, usuarioToolStripMenuItem, servicoToolStripMenuItem, vendaToolStripMenuItem });
            cadastrosToolStripMenuItem.Image = (Image)resources.GetObject("cadastrosToolStripMenuItem.Image");
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(108, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Image = Properties.Resources.cidade;
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(169, 26);
            cidadeToolStripMenuItem.Text = "Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(166, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(166, 6);
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grupoToolStripMenuItem });
            fornecedorToolStripMenuItem.Image = Properties.Resources.Fornecedor;
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(169, 26);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            fornecedorToolStripMenuItem.Click += fornecedorToolStripMenuItem_Click;
            // 
            // grupoToolStripMenuItem
            // 
            grupoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem });
            grupoToolStripMenuItem.Image = Properties.Resources.grupo1;
            grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
            grupoToolStripMenuItem.Size = new Size(133, 26);
            grupoToolStripMenuItem.Text = "Grupo";
            grupoToolStripMenuItem.Click += grupoToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Image = Properties.Resources.produto1;
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(145, 26);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // petToolStripMenuItem
            // 
            petToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Pet_ServicoToolStripMenuItem });
            petToolStripMenuItem.Image = Properties.Resources.Pet;
            petToolStripMenuItem.Name = "petToolStripMenuItem";
            petToolStripMenuItem.Size = new Size(169, 26);
            petToolStripMenuItem.Text = "Pet";
            petToolStripMenuItem.Click += petToolStripMenuItem_Click;
            // 
            // Pet_ServicoToolStripMenuItem
            // 
            Pet_ServicoToolStripMenuItem.Image = Properties.Resources.serviços;
            Pet_ServicoToolStripMenuItem.Name = "Pet_ServicoToolStripMenuItem";
            Pet_ServicoToolStripMenuItem.Size = new Size(204, 26);
            Pet_ServicoToolStripMenuItem.Text = "Serviços para Pet";
            Pet_ServicoToolStripMenuItem.Click += Pet_ServicoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(166, 6);
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Image = Properties.Resources.cliente;
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(169, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Funcionario_ServicoToolStripMenuItem });
            funcionarioToolStripMenuItem.Image = Properties.Resources.funcionario;
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.Size = new Size(169, 26);
            funcionarioToolStripMenuItem.Text = "Funcionário";
            funcionarioToolStripMenuItem.Click += funcionarioToolStripMenuItem_Click;
            // 
            // Funcionario_ServicoToolStripMenuItem
            // 
            Funcionario_ServicoToolStripMenuItem.Image = Properties.Resources.servico_funcionario;
            Funcionario_ServicoToolStripMenuItem.Name = "Funcionario_ServicoToolStripMenuItem";
            Funcionario_ServicoToolStripMenuItem.Size = new Size(252, 26);
            Funcionario_ServicoToolStripMenuItem.Text = "Serviços de funcionários";
            Funcionario_ServicoToolStripMenuItem.Click += Funcionario_ServicoToolStripMenuItem_Click;
            // 
            // veterinarioToolStripMenuItem
            // 
            veterinarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Veterinario_ServicoToolStripMenuItem });
            veterinarioToolStripMenuItem.Image = Properties.Resources.veterinario;
            veterinarioToolStripMenuItem.Name = "veterinarioToolStripMenuItem";
            veterinarioToolStripMenuItem.Size = new Size(169, 26);
            veterinarioToolStripMenuItem.Text = "Veterinário";
            veterinarioToolStripMenuItem.Click += veterinarioToolStripMenuItem_Click;
            // 
            // Veterinario_ServicoToolStripMenuItem
            // 
            Veterinario_ServicoToolStripMenuItem.Image = Properties.Resources.Servico_veterinario;
            Veterinario_ServicoToolStripMenuItem.Name = "Veterinario_ServicoToolStripMenuItem";
            Veterinario_ServicoToolStripMenuItem.Size = new Size(248, 26);
            Veterinario_ServicoToolStripMenuItem.Text = "Serviços de veterinários";
            Veterinario_ServicoToolStripMenuItem.Click += Veterinario_ServicoToolStripMenuItem_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Image = Properties.Resources.usuario;
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(169, 26);
            usuarioToolStripMenuItem.Text = "Usuário";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // servicoToolStripMenuItem
            // 
            servicoToolStripMenuItem.Image = Properties.Resources.Servico;
            servicoToolStripMenuItem.Name = "servicoToolStripMenuItem";
            servicoToolStripMenuItem.Size = new Size(169, 26);
            servicoToolStripMenuItem.Text = "Serviço";
            servicoToolStripMenuItem.Click += servicoToolStripMenuItem_Click;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Image = Properties.Resources.venda;
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(169, 26);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pet_shop;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenuPrincipal";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet Shop";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem petToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem funcionarioToolStripMenuItem;
        private ToolStripMenuItem Pet_ServicoToolStripMenuItem;
        private ToolStripMenuItem veterinarioToolStripMenuItem;
        private ToolStripMenuItem grupoToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem servicoToolStripMenuItem;
        private ToolStripMenuItem Funcionario_ServicoToolStripMenuItem;
        private ToolStripMenuItem Veterinario_ServicoToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
    }
}