namespace LojadeJogos.view
{
    partial class TelaDePesquisa
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtboxpesqplataforma = new System.Windows.Forms.TextBox();
            this.txtboxpesqgenero = new System.Windows.Forms.TextBox();
            this.txtboxpesqnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(567, 150);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(98, 31);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtboxpesqplataforma
            // 
            this.txtboxpesqplataforma.Location = new System.Drawing.Point(312, 329);
            this.txtboxpesqplataforma.Name = "txtboxpesqplataforma";
            this.txtboxpesqplataforma.Size = new System.Drawing.Size(190, 23);
            this.txtboxpesqplataforma.TabIndex = 16;
            // 
            // txtboxpesqgenero
            // 
            this.txtboxpesqgenero.Location = new System.Drawing.Point(312, 270);
            this.txtboxpesqgenero.Name = "txtboxpesqgenero";
            this.txtboxpesqgenero.Size = new System.Drawing.Size(190, 23);
            this.txtboxpesqgenero.TabIndex = 15;
            // 
            // txtboxpesqnome
            // 
            this.txtboxpesqnome.Location = new System.Drawing.Point(312, 206);
            this.txtboxpesqnome.Name = "txtboxpesqnome";
            this.txtboxpesqnome.Size = new System.Drawing.Size(190, 23);
            this.txtboxpesqnome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(164, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(148, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Plataforma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(290, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pesquisar jogos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Titulo do Jogo";
            // 
            // textboxcod
            // 
            this.textboxcod.Location = new System.Drawing.Point(312, 155);
            this.textboxcod.Name = "textboxcod";
            this.textboxcod.Size = new System.Drawing.Size(190, 23);
            this.textboxcod.TabIndex = 19;
            this.textboxcod.TextChanged += new System.EventHandler(this.textboxcod_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(122, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Digite o codigo";
            // 
            // TelaDePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtboxpesqplataforma);
            this.Controls.Add(this.txtboxpesqgenero);
            this.Controls.Add(this.txtboxpesqnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TelaDePesquisa";
            this.Text = "TelaDePesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnbuscar;
        private TextBox txtboxpesqplataforma;
        private TextBox txtboxpesqgenero;
        private TextBox txtboxpesqnome;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private TextBox textboxcod;
        private Label label5;
    }
}