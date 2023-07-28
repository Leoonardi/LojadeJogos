namespace LojadeJogos.view
{
    partial class TelaDeletarJogos
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
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btndeletar = new System.Windows.Forms.Button();
            this.textboxcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxpesqplataforma = new System.Windows.Forms.TextBox();
            this.txtboxpesqgenero = new System.Windows.Forms.TextBox();
            this.txtboxpesqnome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(660, 82);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(98, 31);
            this.btnpesquisar.TabIndex = 17;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(280, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Excluir Jogo";
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(263, 405);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(165, 44);
            this.btndeletar.TabIndex = 18;
            this.btndeletar.Text = "Deletar Jogo";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // textboxcod
            // 
            this.textboxcod.Location = new System.Drawing.Point(443, 87);
            this.textboxcod.Name = "textboxcod";
            this.textboxcod.Size = new System.Drawing.Size(190, 23);
            this.textboxcod.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Digite o codigo que deseja deletar";
            // 
            // txtboxpesqplataforma
            // 
            this.txtboxpesqplataforma.Location = new System.Drawing.Point(238, 316);
            this.txtboxpesqplataforma.Name = "txtboxpesqplataforma";
            this.txtboxpesqplataforma.Size = new System.Drawing.Size(190, 23);
            this.txtboxpesqplataforma.TabIndex = 27;
            // 
            // txtboxpesqgenero
            // 
            this.txtboxpesqgenero.Location = new System.Drawing.Point(238, 257);
            this.txtboxpesqgenero.Name = "txtboxpesqgenero";
            this.txtboxpesqgenero.Size = new System.Drawing.Size(190, 23);
            this.txtboxpesqgenero.TabIndex = 26;
            // 
            // txtboxpesqnome
            // 
            this.txtboxpesqnome.Location = new System.Drawing.Point(238, 193);
            this.txtboxpesqnome.Name = "txtboxpesqnome";
            this.txtboxpesqnome.Size = new System.Drawing.Size(190, 23);
            this.txtboxpesqnome.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(90, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(74, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Plataforma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(48, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "Titulo do Jogo";
            // 
            // TelaDeletarJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(809, 582);
            this.Controls.Add(this.txtboxpesqplataforma);
            this.Controls.Add(this.txtboxpesqgenero);
            this.Controls.Add(this.txtboxpesqnome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textboxcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.label4);
            this.Name = "TelaDeletarJogos";
            this.Text = "TelaDeletarJogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnpesquisar;
        private Label label4;
        private Button btndeletar;
        private TextBox textboxcod;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtboxexclui;
        private TextBox txtboxgenero;
        private TextBox txtboxplataforma;
        private TextBox txtboxpesqplataforma;
        private TextBox txtboxpesqgenero;
        private TextBox txtboxpesqnome;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}