namespace Projeto_DA.Views
{
    partial class Form_Sessoes
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
            this.listb_salas = new System.Windows.Forms.ListBox();
            this.listb_filmes = new System.Windows.Forms.ListBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Picker_dataHora = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listb_sessoes = new System.Windows.Forms.ListBox();
            this.btn_criarSessao = new System.Windows.Forms.Button();
            this.btn_eliminarSessao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_bilhetes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 415);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // listb_salas
            // 
            this.listb_salas.FormattingEnabled = true;
            this.listb_salas.Location = new System.Drawing.Point(6, 32);
            this.listb_salas.Name = "listb_salas";
            this.listb_salas.Size = new System.Drawing.Size(178, 251);
            this.listb_salas.TabIndex = 2;
            // 
            // listb_filmes
            // 
            this.listb_filmes.FormattingEnabled = true;
            this.listb_filmes.Location = new System.Drawing.Point(8, 34);
            this.listb_filmes.Name = "listb_filmes";
            this.listb_filmes.Size = new System.Drawing.Size(280, 251);
            this.listb_filmes.TabIndex = 3;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(42, 214);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(100, 20);
            this.tb_preco.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dat/Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preço";
            // 
            // Picker_dataHora
            // 
            this.Picker_dataHora.Location = new System.Drawing.Point(42, 119);
            this.Picker_dataHora.Name = "Picker_dataHora";
            this.Picker_dataHora.Size = new System.Drawing.Size(211, 20);
            this.Picker_dataHora.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listb_salas);
            this.groupBox1.Location = new System.Drawing.Point(290, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 336);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salas disponiveis";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listb_filmes);
            this.groupBox2.Location = new System.Drawing.Point(495, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 337);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filmes em exibição";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_criarSessao);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.Picker_dataHora);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_preco);
            this.groupBox3.Location = new System.Drawing.Point(339, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 385);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criar Sessão";
            // 
            // listb_sessoes
            // 
            this.listb_sessoes.FormattingEnabled = true;
            this.listb_sessoes.Location = new System.Drawing.Point(12, 41);
            this.listb_sessoes.Name = "listb_sessoes";
            this.listb_sessoes.Size = new System.Drawing.Size(321, 329);
            this.listb_sessoes.TabIndex = 4;
            // 
            // btn_criarSessao
            // 
            this.btn_criarSessao.Location = new System.Drawing.Point(42, 284);
            this.btn_criarSessao.Name = "btn_criarSessao";
            this.btn_criarSessao.Size = new System.Drawing.Size(75, 23);
            this.btn_criarSessao.TabIndex = 11;
            this.btn_criarSessao.Text = "Criar";
            this.btn_criarSessao.UseVisualStyleBackColor = true;
            this.btn_criarSessao.Click += new System.EventHandler(this.btn_criarSessao_Click);
            // 
            // btn_eliminarSessao
            // 
            this.btn_eliminarSessao.Location = new System.Drawing.Point(12, 374);
            this.btn_eliminarSessao.Name = "btn_eliminarSessao";
            this.btn_eliminarSessao.Size = new System.Drawing.Size(321, 23);
            this.btn_eliminarSessao.TabIndex = 12;
            this.btn_eliminarSessao.Text = "Eliminar";
            this.btn_eliminarSessao.UseVisualStyleBackColor = true;
            this.btn_eliminarSessao.Click += new System.EventHandler(this.btn_eliminarSessao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "€";
            // 
            // btn_bilhetes
            // 
            this.btn_bilhetes.Location = new System.Drawing.Point(12, 12);
            this.btn_bilhetes.Name = "btn_bilhetes";
            this.btn_bilhetes.Size = new System.Drawing.Size(321, 23);
            this.btn_bilhetes.TabIndex = 13;
            this.btn_bilhetes.Text = "Comprar Bilhetes";
            this.btn_bilhetes.UseVisualStyleBackColor = true;
            this.btn_bilhetes.Click += new System.EventHandler(this.btn_bilhetes_Click);
            // 
            // Form_Sessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.btn_bilhetes);
            this.Controls.Add(this.btn_eliminarSessao);
            this.Controls.Add(this.listb_sessoes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_back);
            this.Name = "Form_Sessoes";
            this.Text = "Form_Sessoes";
            this.Load += new System.EventHandler(this.Form_Sessoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox listb_salas;
        private System.Windows.Forms.ListBox listb_filmes;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Picker_dataHora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listb_sessoes;
        private System.Windows.Forms.Button btn_criarSessao;
        private System.Windows.Forms.Button btn_eliminarSessao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_bilhetes;
    }
}