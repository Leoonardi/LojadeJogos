namespace LojadeJogos.view
{
    partial class TelaCadastrarJogos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxcadasnome = new System.Windows.Forms.TextBox();
            this.txtboxcadasgenero = new System.Windows.Forms.TextBox();
            this.txtboxcadasplataforma = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Jogo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(242, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = " Cadastro de jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plataforma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(117, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genero";
            // 
            // txtboxcadasnome
            // 
            this.txtboxcadasnome.Location = new System.Drawing.Point(265, 144);
            this.txtboxcadasnome.Name = "txtboxcadasnome";
            this.txtboxcadasnome.Size = new System.Drawing.Size(190, 23);
            this.txtboxcadasnome.TabIndex = 6;
            // 
            // txtboxcadasgenero
            // 
            this.txtboxcadasgenero.Location = new System.Drawing.Point(265, 210);
            this.txtboxcadasgenero.Name = "txtboxcadasgenero";
            this.txtboxcadasgenero.Size = new System.Drawing.Size(190, 23);
            this.txtboxcadasgenero.TabIndex = 7;
            // 
            // txtboxcadasplataforma
            // 
            this.txtboxcadasplataforma.Location = new System.Drawing.Point(265, 269);
            this.txtboxcadasplataforma.Name = "txtboxcadasplataforma";
            this.txtboxcadasplataforma.Size = new System.Drawing.Size(190, 23);
            this.txtboxcadasplataforma.TabIndex = 8;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(499, 139);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(98, 31);
            this.btncadastrar.TabIndex = 9;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // TelaCadastrarJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtboxcadasplataforma);
            this.Controls.Add(this.txtboxcadasgenero);
            this.Controls.Add(this.txtboxcadasnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastrarJogos";
            this.Text = "TelaCadastrarJogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtboxcadasnome;
        private TextBox txtboxcadasgenero;
        private TextBox txtboxcadasplataforma;
        private Button btncadastrar;
    }
}