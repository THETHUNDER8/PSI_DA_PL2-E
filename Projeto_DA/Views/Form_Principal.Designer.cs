namespace Projeto_DA
{
    partial class Form_Principal
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
            this.bnt_cinema = new System.Windows.Forms.Button();
            this.btn_filmes = new System.Windows.Forms.Button();
            this.btn_sessoes = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_Funcionaios = new System.Windows.Forms.Button();
            this.btn_alt_Funcionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_cinema
            // 
            this.bnt_cinema.Location = new System.Drawing.Point(64, 66);
            this.bnt_cinema.Name = "bnt_cinema";
            this.bnt_cinema.Size = new System.Drawing.Size(75, 23);
            this.bnt_cinema.TabIndex = 0;
            this.bnt_cinema.Text = "Cinema";
            this.bnt_cinema.UseVisualStyleBackColor = true;
            this.bnt_cinema.Click += new System.EventHandler(this.bnt_cinema_Click);
            // 
            // btn_filmes
            // 
            this.btn_filmes.Location = new System.Drawing.Point(64, 118);
            this.btn_filmes.Name = "btn_filmes";
            this.btn_filmes.Size = new System.Drawing.Size(75, 23);
            this.btn_filmes.TabIndex = 1;
            this.btn_filmes.Text = "Filmes";
            this.btn_filmes.UseVisualStyleBackColor = true;
            // 
            // btn_sessoes
            // 
            this.btn_sessoes.Location = new System.Drawing.Point(64, 177);
            this.btn_sessoes.Name = "btn_sessoes";
            this.btn_sessoes.Size = new System.Drawing.Size(75, 23);
            this.btn_sessoes.TabIndex = 2;
            this.btn_sessoes.Text = "Sessões";
            this.btn_sessoes.UseVisualStyleBackColor = true;
            // 
            // btn_clientes
            // 
            this.btn_clientes.Location = new System.Drawing.Point(64, 230);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(75, 23);
            this.btn_clientes.TabIndex = 3;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            // 
            // btn_Funcionaios
            // 
            this.btn_Funcionaios.Location = new System.Drawing.Point(64, 287);
            this.btn_Funcionaios.Name = "btn_Funcionaios";
            this.btn_Funcionaios.Size = new System.Drawing.Size(75, 23);
            this.btn_Funcionaios.TabIndex = 4;
            this.btn_Funcionaios.Text = "Funcionários";
            this.btn_Funcionaios.UseVisualStyleBackColor = true;
            // 
            // btn_alt_Funcionario
            // 
            this.btn_alt_Funcionario.Location = new System.Drawing.Point(64, 343);
            this.btn_alt_Funcionario.Name = "btn_alt_Funcionario";
            this.btn_alt_Funcionario.Size = new System.Drawing.Size(75, 23);
            this.btn_alt_Funcionario.TabIndex = 5;
            this.btn_alt_Funcionario.Text = "Alterar";
            this.btn_alt_Funcionario.UseVisualStyleBackColor = true;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_alt_Funcionario);
            this.Controls.Add(this.btn_Funcionaios);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.btn_sessoes);
            this.Controls.Add(this.btn_filmes);
            this.Controls.Add(this.bnt_cinema);
            this.Name = "Form_Principal";
            this.Text = " Formulário Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt_cinema;
        private System.Windows.Forms.Button btn_filmes;
        private System.Windows.Forms.Button btn_sessoes;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_Funcionaios;
        private System.Windows.Forms.Button btn_alt_Funcionario;
    }
}

