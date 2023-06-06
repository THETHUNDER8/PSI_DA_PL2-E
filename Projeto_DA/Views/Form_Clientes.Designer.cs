namespace Projeto_DA.Views
{
    partial class Form_Clientes
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
            this.btn_criarCliente = new System.Windows.Forms.Button();
            this.listb_clientes = new System.Windows.Forms.ListBox();
            this.btn_eleminarCliente = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_morada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_numFiscal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 392);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_criarCliente
            // 
            this.btn_criarCliente.Location = new System.Drawing.Point(40, 226);
            this.btn_criarCliente.Name = "btn_criarCliente";
            this.btn_criarCliente.Size = new System.Drawing.Size(118, 55);
            this.btn_criarCliente.TabIndex = 2;
            this.btn_criarCliente.Text = "Registar Cliente";
            this.btn_criarCliente.UseVisualStyleBackColor = true;
            this.btn_criarCliente.Click += new System.EventHandler(this.btn_criarCliente_Click);
            // 
            // listb_clientes
            // 
            this.listb_clientes.FormattingEnabled = true;
            this.listb_clientes.Location = new System.Drawing.Point(457, 43);
            this.listb_clientes.Name = "listb_clientes";
            this.listb_clientes.Size = new System.Drawing.Size(272, 238);
            this.listb_clientes.TabIndex = 3;
            // 
            // btn_eleminarCliente
            // 
            this.btn_eleminarCliente.Location = new System.Drawing.Point(457, 309);
            this.btn_eleminarCliente.Name = "btn_eleminarCliente";
            this.btn_eleminarCliente.Size = new System.Drawing.Size(272, 44);
            this.btn_eleminarCliente.TabIndex = 4;
            this.btn_eleminarCliente.Text = "Eliminar Cliente";
            this.btn_eleminarCliente.UseVisualStyleBackColor = true;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(40, 104);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(215, 20);
            this.tb_nome.TabIndex = 5;
            // 
            // tb_morada
            // 
            this.tb_morada.Location = new System.Drawing.Point(40, 143);
            this.tb_morada.Name = "tb_morada";
            this.tb_morada.Size = new System.Drawing.Size(215, 20);
            this.tb_morada.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Morada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Número Fiscal:";
            // 
            // tb_numFiscal
            // 
            this.tb_numFiscal.Location = new System.Drawing.Point(40, 182);
            this.tb_numFiscal.Name = "tb_numFiscal";
            this.tb_numFiscal.Size = new System.Drawing.Size(215, 20);
            this.tb_numFiscal.TabIndex = 11;
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_numFiscal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_morada);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.btn_eleminarCliente);
            this.Controls.Add(this.listb_clientes);
            this.Controls.Add(this.btn_criarCliente);
            this.Controls.Add(this.btn_back);
            this.Name = "Form_Clientes";
            this.Text = "Form_Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_criarCliente;
        private System.Windows.Forms.ListBox listb_clientes;
        private System.Windows.Forms.Button btn_eleminarCliente;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_morada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_numFiscal;
    }
}