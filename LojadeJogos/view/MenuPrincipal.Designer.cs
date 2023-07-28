namespace LojadeJogos.view
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciamentoDeJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeJogosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciamentoDeJogosToolStripMenuItem
            // 
            this.gerenciamentoDeJogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarJogosToolStripMenuItem,
            this.buscarJogosToolStripMenuItem,
            this.alterarJogosToolStripMenuItem,
            this.deletarJogosToolStripMenuItem});
            this.gerenciamentoDeJogosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gerenciamentoDeJogosToolStripMenuItem.Name = "gerenciamentoDeJogosToolStripMenuItem";
            this.gerenciamentoDeJogosToolStripMenuItem.Size = new System.Drawing.Size(241, 29);
            this.gerenciamentoDeJogosToolStripMenuItem.Text = "Gerenciamento de jogos";
            this.gerenciamentoDeJogosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gerenciamentoDeJogosToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoDeJogosToolStripMenuItem_Click);
            // 
            // cadastrarJogosToolStripMenuItem
            // 
            this.cadastrarJogosToolStripMenuItem.Name = "cadastrarJogosToolStripMenuItem";
            this.cadastrarJogosToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.cadastrarJogosToolStripMenuItem.Text = "Cadastrar Jogos";
            this.cadastrarJogosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarJogosToolStripMenuItem_Click);
            // 
            // buscarJogosToolStripMenuItem
            // 
            this.buscarJogosToolStripMenuItem.Name = "buscarJogosToolStripMenuItem";
            this.buscarJogosToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.buscarJogosToolStripMenuItem.Text = "Buscar Jogos";
            this.buscarJogosToolStripMenuItem.Click += new System.EventHandler(this.buscarJogosToolStripMenuItem_Click);
            // 
            // alterarJogosToolStripMenuItem
            // 
            this.alterarJogosToolStripMenuItem.Name = "alterarJogosToolStripMenuItem";
            this.alterarJogosToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.alterarJogosToolStripMenuItem.Text = "Alterar Jogos";
            this.alterarJogosToolStripMenuItem.Click += new System.EventHandler(this.alterarJogosToolStripMenuItem_Click);
            // 
            // deletarJogosToolStripMenuItem
            // 
            this.deletarJogosToolStripMenuItem.Name = "deletarJogosToolStripMenuItem";
            this.deletarJogosToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.deletarJogosToolStripMenuItem.Text = "Deletar Jogos";
            this.deletarJogosToolStripMenuItem.Click += new System.EventHandler(this.deletarJogosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gerenciamentoDeJogosToolStripMenuItem;
        private ToolStripMenuItem cadastrarJogosToolStripMenuItem;
        private ToolStripMenuItem buscarJogosToolStripMenuItem;
        private ToolStripMenuItem alterarJogosToolStripMenuItem;
        private ToolStripMenuItem deletarJogosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}