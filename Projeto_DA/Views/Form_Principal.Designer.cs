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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_funcionario = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnt_cinema
            // 
            this.bnt_cinema.Location = new System.Drawing.Point(6, 32);
            this.bnt_cinema.Name = "bnt_cinema";
            this.bnt_cinema.Size = new System.Drawing.Size(251, 46);
            this.bnt_cinema.TabIndex = 0;
            this.bnt_cinema.Text = "Cinema";
            this.bnt_cinema.UseVisualStyleBackColor = true;
            this.bnt_cinema.Click += new System.EventHandler(this.bnt_cinema_Click);
            // 
            // btn_filmes
            // 
            this.btn_filmes.Location = new System.Drawing.Point(6, 84);
            this.btn_filmes.Name = "btn_filmes";
            this.btn_filmes.Size = new System.Drawing.Size(251, 53);
            this.btn_filmes.TabIndex = 1;
            this.btn_filmes.Text = "Filmes";
            this.btn_filmes.UseVisualStyleBackColor = true;
            this.btn_filmes.Click += new System.EventHandler(this.btn_filmes_Click);
            // 
            // btn_sessoes
            // 
            this.btn_sessoes.Location = new System.Drawing.Point(6, 143);
            this.btn_sessoes.Name = "btn_sessoes";
            this.btn_sessoes.Size = new System.Drawing.Size(251, 47);
            this.btn_sessoes.TabIndex = 2;
            this.btn_sessoes.Text = "Sessões";
            this.btn_sessoes.UseVisualStyleBackColor = true;
            this.btn_sessoes.Click += new System.EventHandler(this.btn_sessoes_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Location = new System.Drawing.Point(6, 196);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(251, 51);
            this.btn_clientes.TabIndex = 3;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_Funcionaios
            // 
            this.btn_Funcionaios.Location = new System.Drawing.Point(6, 253);
            this.btn_Funcionaios.Name = "btn_Funcionaios";
            this.btn_Funcionaios.Size = new System.Drawing.Size(251, 59);
            this.btn_Funcionaios.TabIndex = 4;
            this.btn_Funcionaios.Text = "Funcionários";
            this.btn_Funcionaios.UseVisualStyleBackColor = true;
            this.btn_Funcionaios.Click += new System.EventHandler(this.btn_Funcionaios_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 342);
            this.listBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_funcionario);
            this.groupBox1.Controls.Add(this.btn_clientes);
            this.groupBox1.Controls.Add(this.btn_sessoes);
            this.groupBox1.Controls.Add(this.btn_Funcionaios);
            this.groupBox1.Controls.Add(this.btn_filmes);
            this.groupBox1.Controls.Add(this.bnt_cinema);
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 385);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(332, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 388);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sessões para o dia de hoje ";
            // 
            // cb_funcionario
            // 
            this.cb_funcionario.FormattingEnabled = true;
            this.cb_funcionario.Location = new System.Drawing.Point(6, 339);
            this.cb_funcionario.Name = "cb_funcionario";
            this.cb_funcionario.Size = new System.Drawing.Size(121, 21);
            this.cb_funcionario.TabIndex = 5;
            this.cb_funcionario.SelectedIndexChanged += new System.EventHandler(this.cb_funcionario_SelectedIndexChanged);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Principal";
            this.Text = " Formulário Principal";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt_cinema;
        private System.Windows.Forms.Button btn_filmes;
        private System.Windows.Forms.Button btn_sessoes;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_Funcionaios;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_funcionario;
    }
}

