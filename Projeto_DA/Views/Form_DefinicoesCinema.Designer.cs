namespace Projeto_DA.Views
{
    partial class Form_DefinicoesCinema
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
            this.btn_criarCinema = new System.Windows.Forms.Button();
            this.tb_nomeCinema = new System.Windows.Forms.TextBox();
            this.tb_moradaCinema = new System.Windows.Forms.TextBox();
            this.tb_emailCinema = new System.Windows.Forms.TextBox();
            this.tb_maxSalas = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Morada = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_criarCinema
            // 
            this.btn_criarCinema.Location = new System.Drawing.Point(122, 341);
            this.btn_criarCinema.Name = "btn_criarCinema";
            this.btn_criarCinema.Size = new System.Drawing.Size(75, 23);
            this.btn_criarCinema.TabIndex = 0;
            this.btn_criarCinema.Text = "OK";
            this.btn_criarCinema.UseVisualStyleBackColor = true;
            this.btn_criarCinema.Click += new System.EventHandler(this.btn_criarCinema_Click);
            // 
            // tb_nomeCinema
            // 
            this.tb_nomeCinema.Location = new System.Drawing.Point(111, 88);
            this.tb_nomeCinema.Name = "tb_nomeCinema";
            this.tb_nomeCinema.Size = new System.Drawing.Size(100, 20);
            this.tb_nomeCinema.TabIndex = 1;
            // 
            // tb_moradaCinema
            // 
            this.tb_moradaCinema.Location = new System.Drawing.Point(111, 144);
            this.tb_moradaCinema.Name = "tb_moradaCinema";
            this.tb_moradaCinema.Size = new System.Drawing.Size(100, 20);
            this.tb_moradaCinema.TabIndex = 2;
            // 
            // tb_emailCinema
            // 
            this.tb_emailCinema.Location = new System.Drawing.Point(111, 207);
            this.tb_emailCinema.Name = "tb_emailCinema";
            this.tb_emailCinema.Size = new System.Drawing.Size(100, 20);
            this.tb_emailCinema.TabIndex = 3;
            // 
            // tb_maxSalas
            // 
            this.tb_maxSalas.Location = new System.Drawing.Point(111, 267);
            this.tb_maxSalas.Name = "tb_maxSalas";
            this.tb_maxSalas.Size = new System.Drawing.Size(100, 20);
            this.tb_maxSalas.TabIndex = 4;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(108, 72);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Nome";
            // 
            // Morada
            // 
            this.Morada.AutoSize = true;
            this.Morada.Location = new System.Drawing.Point(108, 128);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(43, 13);
            this.Morada.TabIndex = 6;
            this.Morada.Text = "Morada";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(108, 191);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº maximo de salas";
            // 
            // Form_DefinicoesCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.tb_maxSalas);
            this.Controls.Add(this.tb_emailCinema);
            this.Controls.Add(this.tb_moradaCinema);
            this.Controls.Add(this.tb_nomeCinema);
            this.Controls.Add(this.btn_criarCinema);
            this.Name = "Form_DefinicoesCinema";
            this.Text = "Form_DefinicoesCinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_criarCinema;
        private System.Windows.Forms.TextBox tb_nomeCinema;
        private System.Windows.Forms.TextBox tb_moradaCinema;
        private System.Windows.Forms.TextBox tb_emailCinema;
        private System.Windows.Forms.TextBox tb_maxSalas;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Morada;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label4;
    }
}