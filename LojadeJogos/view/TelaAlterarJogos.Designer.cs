namespace LojadeJogos.view
{
    partial class TelaAlterarJogos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxaltnome = new System.Windows.Forms.TextBox();
            this.txtboxaltgenero = new System.Windows.Forms.TextBox();
            this.txtboxaltplataforma = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(108, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(108, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genêro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(95, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plataforma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(226, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alteramento de Jogos";
            // 
            // txtboxaltnome
            // 
            this.txtboxaltnome.Location = new System.Drawing.Point(279, 131);
            this.txtboxaltnome.Name = "txtboxaltnome";
            this.txtboxaltnome.Size = new System.Drawing.Size(156, 23);
            this.txtboxaltnome.TabIndex = 5;
            // 
            // txtboxaltgenero
            // 
            this.txtboxaltgenero.Location = new System.Drawing.Point(279, 224);
            this.txtboxaltgenero.Name = "txtboxaltgenero";
            this.txtboxaltgenero.Size = new System.Drawing.Size(156, 23);
            this.txtboxaltgenero.TabIndex = 6;
            // 
            // txtboxaltplataforma
            // 
            this.txtboxaltplataforma.Location = new System.Drawing.Point(279, 298);
            this.txtboxaltplataforma.Name = "txtboxaltplataforma";
            this.txtboxaltplataforma.Size = new System.Drawing.Size(156, 23);
            this.txtboxaltplataforma.TabIndex = 7;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(509, 130);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(98, 33);
            this.btnpesquisar.TabIndex = 8;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(433, 358);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(224, 67);
            this.btnconfirmar.TabIndex = 9;
            this.btnconfirmar.Text = "Confirmar Alteramento";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // TelaAlterarJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.txtboxaltplataforma);
            this.Controls.Add(this.txtboxaltgenero);
            this.Controls.Add(this.txtboxaltnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaAlterarJogos";
            this.Text = "TelaAlterarJogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtboxaltnome;
        private TextBox txtboxaltgenero;
        private TextBox txtboxaltplataforma;
        private Button btnpesquisar;
        private Button btnconfirmar;
    }
}