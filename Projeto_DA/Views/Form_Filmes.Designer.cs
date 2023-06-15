namespace Projeto_DA.Views
{
    partial class Form_Filmes
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
            this.listb_Filmes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_nomeFilme = new System.Windows.Forms.TextBox();
            this.cb_categorias = new System.Windows.Forms.ComboBox();
            this.btn_criarFilme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_duracao = new System.Windows.Forms.TextBox();
            this.btn_Eleminar = new System.Windows.Forms.Button();
            this.btn_activate_deactivate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // listb_Filmes
            // 
            this.listb_Filmes.FormattingEnabled = true;
            this.listb_Filmes.Location = new System.Drawing.Point(60, 30);
            this.listb_Filmes.Name = "listb_Filmes";
            this.listb_Filmes.Size = new System.Drawing.Size(272, 303);
            this.listb_Filmes.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_activate_deactivate);
            this.groupBox1.Controls.Add(this.btn_Eleminar);
            this.groupBox1.Controls.Add(this.listb_Filmes);
            this.groupBox1.Location = new System.Drawing.Point(388, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 380);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filmes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_duracao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_criarFilme);
            this.groupBox2.Controls.Add(this.cb_categorias);
            this.groupBox2.Controls.Add(this.tb_nomeFilme);
            this.groupBox2.Location = new System.Drawing.Point(28, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 380);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criar Filme";
            // 
            // tb_nomeFilme
            // 
            this.tb_nomeFilme.Location = new System.Drawing.Point(28, 64);
            this.tb_nomeFilme.Name = "tb_nomeFilme";
            this.tb_nomeFilme.Size = new System.Drawing.Size(121, 20);
            this.tb_nomeFilme.TabIndex = 0;
            // 
            // cb_categorias
            // 
            this.cb_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categorias.FormattingEnabled = true;
            this.cb_categorias.Location = new System.Drawing.Point(28, 204);
            this.cb_categorias.Name = "cb_categorias";
            this.cb_categorias.Size = new System.Drawing.Size(121, 21);
            this.cb_categorias.TabIndex = 1;
            // 
            // btn_criarFilme
            // 
            this.btn_criarFilme.Location = new System.Drawing.Point(28, 255);
            this.btn_criarFilme.Name = "btn_criarFilme";
            this.btn_criarFilme.Size = new System.Drawing.Size(75, 23);
            this.btn_criarFilme.TabIndex = 2;
            this.btn_criarFilme.Text = "Criar Filme";
            this.btn_criarFilme.UseVisualStyleBackColor = true;
            this.btn_criarFilme.Click += new System.EventHandler(this.btn_criarFilme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria do Filme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duração";
            // 
            // tb_duracao
            // 
            this.tb_duracao.Location = new System.Drawing.Point(28, 132);
            this.tb_duracao.Name = "tb_duracao";
            this.tb_duracao.Size = new System.Drawing.Size(121, 20);
            this.tb_duracao.TabIndex = 5;
            // 
            // btn_Eleminar
            // 
            this.btn_Eleminar.Location = new System.Drawing.Point(60, 351);
            this.btn_Eleminar.Name = "btn_Eleminar";
            this.btn_Eleminar.Size = new System.Drawing.Size(125, 23);
            this.btn_Eleminar.TabIndex = 3;
            this.btn_Eleminar.Text = "Eleminar";
            this.btn_Eleminar.UseVisualStyleBackColor = true;
            this.btn_Eleminar.Click += new System.EventHandler(this.btn_Eleminar_Click);
            // 
            // btn_activate_deactivate
            // 
            this.btn_activate_deactivate.Location = new System.Drawing.Point(207, 351);
            this.btn_activate_deactivate.Name = "btn_activate_deactivate";
            this.btn_activate_deactivate.Size = new System.Drawing.Size(125, 23);
            this.btn_activate_deactivate.TabIndex = 4;
            this.btn_activate_deactivate.Text = "Ativar/Desativar";
            this.btn_activate_deactivate.UseVisualStyleBackColor = true;
            this.btn_activate_deactivate.Click += new System.EventHandler(this.btn_activate_deactivate_Click);
            // 
            // Form_Filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_back);
            this.Name = "Form_Filmes";
            this.Text = "Form_Filmes";
            this.Load += new System.EventHandler(this.Form_Filmes_Load);
            this.Click += new System.EventHandler(this.Form_Filmes_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox listb_Filmes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_criarFilme;
        private System.Windows.Forms.ComboBox cb_categorias;
        private System.Windows.Forms.TextBox tb_nomeFilme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_duracao;
        private System.Windows.Forms.Button btn_activate_deactivate;
        private System.Windows.Forms.Button btn_Eleminar;
    }
}