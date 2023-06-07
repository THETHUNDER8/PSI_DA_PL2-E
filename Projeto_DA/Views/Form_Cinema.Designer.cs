namespace Projeto_DA.Views
{
    partial class Form_Cinema
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_criarSala = new System.Windows.Forms.Button();
            this.tb_coluna = new System.Windows.Forms.TextBox();
            this.tb_fila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_altCinema = new System.Windows.Forms.Button();
            this.lbl_NomeCinema = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.btn_eliminarSala = new System.Windows.Forms.Button();
            this.btn_editarSala = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_salasMax = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_morada = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listb_salas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 415);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_criarSala
            // 
            this.btn_criarSala.Location = new System.Drawing.Point(27, 153);
            this.btn_criarSala.Name = "btn_criarSala";
            this.btn_criarSala.Size = new System.Drawing.Size(85, 26);
            this.btn_criarSala.TabIndex = 1;
            this.btn_criarSala.Text = "Criar";
            this.btn_criarSala.UseVisualStyleBackColor = true;
            this.btn_criarSala.Click += new System.EventHandler(this.btn_criarSala_Click);
            // 
            // tb_coluna
            // 
            this.tb_coluna.Location = new System.Drawing.Point(171, 106);
            this.tb_coluna.Name = "tb_coluna";
            this.tb_coluna.Size = new System.Drawing.Size(100, 20);
            this.tb_coluna.TabIndex = 2;
            // 
            // tb_fila
            // 
            this.tb_fila.Location = new System.Drawing.Point(27, 106);
            this.tb_fila.Name = "tb_fila";
            this.tb_fila.Size = new System.Drawing.Size(100, 20);
            this.tb_fila.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coluna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fila";
            // 
            // btn_altCinema
            // 
            this.btn_altCinema.Location = new System.Drawing.Point(13, 271);
            this.btn_altCinema.Name = "btn_altCinema";
            this.btn_altCinema.Size = new System.Drawing.Size(164, 30);
            this.btn_altCinema.TabIndex = 6;
            this.btn_altCinema.Text = "Alterar definições do Cinema";
            this.btn_altCinema.UseVisualStyleBackColor = true;
            this.btn_altCinema.Click += new System.EventHandler(this.btn_altCinema_Click);
            // 
            // lbl_NomeCinema
            // 
            this.lbl_NomeCinema.AutoSize = true;
            this.lbl_NomeCinema.Location = new System.Drawing.Point(24, 29);
            this.lbl_NomeCinema.Name = "lbl_NomeCinema";
            this.lbl_NomeCinema.Size = new System.Drawing.Size(38, 13);
            this.lbl_NomeCinema.TabIndex = 9;
            this.lbl_NomeCinema.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Controls.Add(this.btn_eliminarSala);
            this.groupBox1.Controls.Add(this.btn_editarSala);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_fila);
            this.groupBox1.Controls.Add(this.tb_coluna);
            this.groupBox1.Controls.Add(this.btn_criarSala);
            this.groupBox1.Location = new System.Drawing.Point(443, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(27, 45);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 8;
            // 
            // btn_eliminarSala
            // 
            this.btn_eliminarSala.Location = new System.Drawing.Point(209, 153);
            this.btn_eliminarSala.Name = "btn_eliminarSala";
            this.btn_eliminarSala.Size = new System.Drawing.Size(85, 26);
            this.btn_eliminarSala.TabIndex = 7;
            this.btn_eliminarSala.Text = "Eliminar";
            this.btn_eliminarSala.UseVisualStyleBackColor = true;
            this.btn_eliminarSala.Click += new System.EventHandler(this.btn_eliminarSala_Click);
            // 
            // btn_editarSala
            // 
            this.btn_editarSala.Location = new System.Drawing.Point(118, 153);
            this.btn_editarSala.Name = "btn_editarSala";
            this.btn_editarSala.Size = new System.Drawing.Size(85, 26);
            this.btn_editarSala.TabIndex = 6;
            this.btn_editarSala.Text = "Editar";
            this.btn_editarSala.UseVisualStyleBackColor = true;
            this.btn_editarSala.Click += new System.EventHandler(this.btn_editarSala_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_salasMax);
            this.groupBox2.Controls.Add(this.lbl_email);
            this.groupBox2.Controls.Add(this.lbl_morada);
            this.groupBox2.Controls.Add(this.lbl_nome);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbl_NomeCinema);
            this.groupBox2.Controls.Add(this.btn_altCinema);
            this.groupBox2.Location = new System.Drawing.Point(28, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 330);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinema";
            // 
            // lbl_salasMax
            // 
            this.lbl_salasMax.AutoSize = true;
            this.lbl_salasMax.Location = new System.Drawing.Point(133, 196);
            this.lbl_salasMax.Name = "lbl_salasMax";
            this.lbl_salasMax.Size = new System.Drawing.Size(22, 13);
            this.lbl_salasMax.TabIndex = 16;
            this.lbl_salasMax.Text = "-----";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(65, 140);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(22, 13);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "-----";
            // 
            // lbl_morada
            // 
            this.lbl_morada.AutoSize = true;
            this.lbl_morada.Location = new System.Drawing.Point(76, 89);
            this.lbl_morada.Name = "lbl_morada";
            this.lbl_morada.Size = new System.Drawing.Size(25, 13);
            this.lbl_morada.TabIndex = 14;
            this.lbl_morada.Text = "------";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(68, 29);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(19, 13);
            this.lbl_nome.TabIndex = 13;
            this.lbl_nome.Text = "----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nº Maximo de salas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Morada:";
            // 
            // listb_salas
            // 
            this.listb_salas.FormattingEnabled = true;
            this.listb_salas.Location = new System.Drawing.Point(448, 261);
            this.listb_salas.Name = "listb_salas";
            this.listb_salas.Size = new System.Drawing.Size(303, 147);
            this.listb_salas.TabIndex = 12;
            this.listb_salas.SelectedIndexChanged += new System.EventHandler(this.listb_salas_SelectedIndexChanged);
            // 
            // Form_Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listb_salas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_back);
            this.Name = "Form_Cinema";
            this.Text = "Form_Cinema";
            this.Load += new System.EventHandler(this.Form_Cinema_Load);
            this.Click += new System.EventHandler(this.Form_Cinema_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_criarSala;
        private System.Windows.Forms.TextBox tb_coluna;
        private System.Windows.Forms.TextBox tb_fila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_altCinema;
        private System.Windows.Forms.Label lbl_NomeCinema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_eliminarSala;
        private System.Windows.Forms.Button btn_editarSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lbl_salasMax;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_morada;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listb_salas;
    }
}