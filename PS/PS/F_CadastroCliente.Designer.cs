﻿namespace PS
{
    partial class F_CadastroCliente
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.EnderecoCli = new System.Windows.Forms.TextBox();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.TelefoneCli = new System.Windows.Forms.TextBox();
            this.EmailCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Cadastro = new System.Windows.Forms.Label();
            this.NomeCli = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(338, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 387);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EnderecoCli);
            this.panel1.Controls.Add(this.Btn_Cadastrar);
            this.panel1.Controls.Add(this.TelefoneCli);
            this.panel1.Controls.Add(this.EmailCli);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Lb_Cadastro);
            this.panel1.Controls.Add(this.NomeCli);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 387);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Endereço do Cliente";
            // 
            // EnderecoCli
            // 
            this.EnderecoCli.Location = new System.Drawing.Point(83, 230);
            this.EnderecoCli.Name = "EnderecoCli";
            this.EnderecoCli.Size = new System.Drawing.Size(136, 20);
            this.EnderecoCli.TabIndex = 3;
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(106, 266);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cadastrar.TabIndex = 4;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // TelefoneCli
            // 
            this.TelefoneCli.Location = new System.Drawing.Point(83, 191);
            this.TelefoneCli.Name = "TelefoneCli";
            this.TelefoneCli.Size = new System.Drawing.Size(136, 20);
            this.TelefoneCli.TabIndex = 2;
            this.TelefoneCli.TextChanged += new System.EventHandler(this.TelefoneCli_TextChanged);
            // 
            // EmailCli
            // 
            this.EmailCli.Location = new System.Drawing.Point(83, 151);
            this.EmailCli.Name = "EmailCli";
            this.EmailCli.Size = new System.Drawing.Size(136, 20);
            this.EmailCli.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefone do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email do Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome do Cliente";
            // 
            // Lb_Cadastro
            // 
            this.Lb_Cadastro.AutoSize = true;
            this.Lb_Cadastro.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Cadastro.Location = new System.Drawing.Point(104, 42);
            this.Lb_Cadastro.Name = "Lb_Cadastro";
            this.Lb_Cadastro.Size = new System.Drawing.Size(83, 28);
            this.Lb_Cadastro.TabIndex = 15;
            this.Lb_Cadastro.Text = "Cadastro";
            // 
            // NomeCli
            // 
            this.NomeCli.Location = new System.Drawing.Point(83, 112);
            this.NomeCli.Name = "NomeCli";
            this.NomeCli.Size = new System.Drawing.Size(136, 20);
            this.NomeCli.TabIndex = 0;
            // 
            // F_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(659, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F_CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CadastroCliente";
            this.Load += new System.EventHandler(this.F_CadastroCliente_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnderecoCli;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.TextBox TelefoneCli;
        private System.Windows.Forms.TextBox EmailCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Cadastro;
        private System.Windows.Forms.TextBox NomeCli;
    }
}