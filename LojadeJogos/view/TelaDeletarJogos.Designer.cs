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
            this.txtboxexcluplataforma = new System.Windows.Forms.TextBox();
            this.txtboxexclugenero = new System.Windows.Forms.TextBox();
            this.txtboxexclunome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(562, 199);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(98, 31);
            this.btnpesquisar.TabIndex = 17;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtboxexcluplataforma
            // 
            this.txtboxexcluplataforma.Location = new System.Drawing.Point(312, 329);
            this.txtboxexcluplataforma.Name = "txtboxexcluplataforma";
            this.txtboxexcluplataforma.Size = new System.Drawing.Size(190, 23);
            this.txtboxexcluplataforma.TabIndex = 16;
            // 
            // txtboxexclugenero
            // 
            this.txtboxexclugenero.Location = new System.Drawing.Point(312, 270);
            this.txtboxexclugenero.Name = "txtboxexclugenero";
            this.txtboxexclugenero.Size = new System.Drawing.Size(190, 23);
            this.txtboxexclugenero.TabIndex = 15;
            // 
            // txtboxexclunome
            // 
            this.txtboxexclunome.Location = new System.Drawing.Point(312, 204);
            this.txtboxexclunome.Name = "txtboxexclunome";
            this.txtboxexclunome.Size = new System.Drawing.Size(190, 23);
            this.txtboxexclunome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(148, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Plataforma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(295, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Excluir Jogo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome do Jogo";
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(337, 380);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(165, 44);
            this.btndeletar.TabIndex = 18;
            this.btndeletar.Text = "Deletar Jogo";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // TelaDeletarJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.txtboxexcluplataforma);
            this.Controls.Add(this.txtboxexclugenero);
            this.Controls.Add(this.txtboxexclunome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TelaDeletarJogos";
            this.Text = "TelaDeletarJogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnpesquisar;
        private TextBox txtboxexcluplataforma;
        private TextBox txtboxexclugenero;
        private TextBox txtboxexclunome;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private Button btndeletar;
    }
}