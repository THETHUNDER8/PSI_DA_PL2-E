namespace Projeto_DA.Views
{
    partial class Form_Funcionarios
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
            this.btn_editarFuncionario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_funcao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_morada = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.btn_eleminarFuncionario = new System.Windows.Forms.Button();
            this.listb_Funcionario = new System.Windows.Forms.ListBox();
            this.btn_criarFuncionario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_salario = new System.Windows.Forms.TextBox();
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
            // btn_editarFuncionario
            // 
            this.btn_editarFuncionario.Location = new System.Drawing.Point(212, 253);
            this.btn_editarFuncionario.Name = "btn_editarFuncionario";
            this.btn_editarFuncionario.Size = new System.Drawing.Size(118, 55);
            this.btn_editarFuncionario.TabIndex = 23;
            this.btn_editarFuncionario.Text = "Editar Funcionario";
            this.btn_editarFuncionario.UseVisualStyleBackColor = true;
            this.btn_editarFuncionario.Click += new System.EventHandler(this.btn_editarFuncionario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Função:";
            // 
            // tb_funcao
            // 
            this.tb_funcao.Location = new System.Drawing.Point(60, 171);
            this.tb_funcao.Name = "tb_funcao";
            this.tb_funcao.Size = new System.Drawing.Size(270, 20);
            this.tb_funcao.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Morada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome:";
            // 
            // tb_morada
            // 
            this.tb_morada.Location = new System.Drawing.Point(60, 132);
            this.tb_morada.Name = "tb_morada";
            this.tb_morada.Size = new System.Drawing.Size(270, 20);
            this.tb_morada.TabIndex = 18;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(60, 93);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(270, 20);
            this.tb_nome.TabIndex = 17;
            // 
            // btn_eleminarFuncionario
            // 
            this.btn_eleminarFuncionario.Location = new System.Drawing.Point(472, 336);
            this.btn_eleminarFuncionario.Name = "btn_eleminarFuncionario";
            this.btn_eleminarFuncionario.Size = new System.Drawing.Size(272, 44);
            this.btn_eleminarFuncionario.TabIndex = 16;
            this.btn_eleminarFuncionario.Text = "Eliminar Funcionario";
            this.btn_eleminarFuncionario.UseVisualStyleBackColor = true;
            this.btn_eleminarFuncionario.Click += new System.EventHandler(this.btn_eleminarFuncionario_Click);
            // 
            // listb_Funcionario
            // 
            this.listb_Funcionario.FormattingEnabled = true;
            this.listb_Funcionario.Location = new System.Drawing.Point(362, 70);
            this.listb_Funcionario.Name = "listb_Funcionario";
            this.listb_Funcionario.Size = new System.Drawing.Size(382, 238);
            this.listb_Funcionario.TabIndex = 15;
            this.listb_Funcionario.SelectedIndexChanged += new System.EventHandler(this.listb_Funcionario_SelectedIndexChanged);
            // 
            // btn_criarFuncionario
            // 
            this.btn_criarFuncionario.Location = new System.Drawing.Point(60, 253);
            this.btn_criarFuncionario.Name = "btn_criarFuncionario";
            this.btn_criarFuncionario.Size = new System.Drawing.Size(118, 55);
            this.btn_criarFuncionario.TabIndex = 14;
            this.btn_criarFuncionario.Text = "Registar Funcionario";
            this.btn_criarFuncionario.UseVisualStyleBackColor = true;
            this.btn_criarFuncionario.Click += new System.EventHandler(this.btn_criarFuncionario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Salário:";
            // 
            // tb_salario
            // 
            this.tb_salario.Location = new System.Drawing.Point(60, 215);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(270, 20);
            this.tb_salario.TabIndex = 24;
            // 
            // Form_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_salario);
            this.Controls.Add(this.btn_editarFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_funcao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_morada);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.btn_eleminarFuncionario);
            this.Controls.Add(this.listb_Funcionario);
            this.Controls.Add(this.btn_criarFuncionario);
            this.Controls.Add(this.btn_back);
            this.Name = "Form_Funcionarios";
            this.Text = "Form_Funcionarios";
            this.Load += new System.EventHandler(this.Form_Funcionarios_Load);
            this.Click += new System.EventHandler(this.Form_Funcionarios_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_editarFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_funcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_morada;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button btn_eleminarFuncionario;
        private System.Windows.Forms.ListBox listb_Funcionario;
        private System.Windows.Forms.Button btn_criarFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_salario;
    }
}