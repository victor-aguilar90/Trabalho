namespace PS
{
    partial class REcadastroFuncionario
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
            this.Dg_Func = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Visualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Tb_TelefoneFunc = new System.Windows.Forms.TextBox();
            this.Tb_EmailFunc = new System.Windows.Forms.TextBox();
            this.Tb_VerificacaoSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cb_Cargo = new System.Windows.Forms.ComboBox();
            this.Tb_SenhaFunc = new System.Windows.Forms.TextBox();
            this.Tb_NomeFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_CodFunc = new System.Windows.Forms.TextBox();
            this.Lb_Cadastro = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Func)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.Dg_Func);
            this.panel2.Location = new System.Drawing.Point(338, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 387);
            this.panel2.TabIndex = 9;
            // 
            // Dg_Func
            // 
            this.Dg_Func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Func.Location = new System.Drawing.Point(20, 21);
            this.Dg_Func.Name = "Dg_Func";
            this.Dg_Func.Size = new System.Drawing.Size(272, 346);
            this.Dg_Func.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.Btn_Visualizar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Btn_Cadastrar);
            this.panel1.Controls.Add(this.Tb_TelefoneFunc);
            this.panel1.Controls.Add(this.Tb_EmailFunc);
            this.panel1.Controls.Add(this.Tb_VerificacaoSenha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Cb_Cargo);
            this.panel1.Controls.Add(this.Tb_SenhaFunc);
            this.panel1.Controls.Add(this.Tb_NomeFunc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Tb_CodFunc);
            this.panel1.Controls.Add(this.Lb_Cadastro);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 387);
            this.panel1.TabIndex = 8;
            // 
            // Btn_Visualizar
            // 
            this.Btn_Visualizar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Visualizar.Location = new System.Drawing.Point(274, 260);
            this.Btn_Visualizar.Name = "Btn_Visualizar";
            this.Btn_Visualizar.Size = new System.Drawing.Size(22, 23);
            this.Btn_Visualizar.TabIndex = 8;
            this.Btn_Visualizar.Text = "👁";
            this.Btn_Visualizar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Verificação de Senha";
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(110, 343);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cadastrar.TabIndex = 7;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Tb_TelefoneFunc
            // 
            this.Tb_TelefoneFunc.Location = new System.Drawing.Point(82, 198);
            this.Tb_TelefoneFunc.Name = "Tb_TelefoneFunc";
            this.Tb_TelefoneFunc.Size = new System.Drawing.Size(136, 20);
            this.Tb_TelefoneFunc.TabIndex = 3;
            this.Tb_TelefoneFunc.TextChanged += new System.EventHandler(this.Tb_TelefoneFunc_TextChanged);
            // 
            // Tb_EmailFunc
            // 
            this.Tb_EmailFunc.Location = new System.Drawing.Point(82, 158);
            this.Tb_EmailFunc.Name = "Tb_EmailFunc";
            this.Tb_EmailFunc.Size = new System.Drawing.Size(136, 20);
            this.Tb_EmailFunc.TabIndex = 2;
            // 
            // Tb_VerificacaoSenha
            // 
            this.Tb_VerificacaoSenha.Location = new System.Drawing.Point(153, 262);
            this.Tb_VerificacaoSenha.Name = "Tb_VerificacaoSenha";
            this.Tb_VerificacaoSenha.Size = new System.Drawing.Size(107, 20);
            this.Tb_VerificacaoSenha.TabIndex = 5;
            this.Tb_VerificacaoSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Novo Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nova Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Novo Telefone do Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Novo Email do Funcionário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Novo Nome do Funcionário";
            // 
            // Cb_Cargo
            // 
            this.Cb_Cargo.FormattingEnabled = true;
            this.Cb_Cargo.Items.AddRange(new object[] {
            "Gerente",
            "Atendente"});
            this.Cb_Cargo.Location = new System.Drawing.Point(84, 301);
            this.Cb_Cargo.Name = "Cb_Cargo";
            this.Cb_Cargo.Size = new System.Drawing.Size(136, 21);
            this.Cb_Cargo.TabIndex = 6;
            // 
            // Tb_SenhaFunc
            // 
            this.Tb_SenhaFunc.Location = new System.Drawing.Point(35, 262);
            this.Tb_SenhaFunc.Name = "Tb_SenhaFunc";
            this.Tb_SenhaFunc.Size = new System.Drawing.Size(112, 20);
            this.Tb_SenhaFunc.TabIndex = 4;
            this.Tb_SenhaFunc.UseSystemPasswordChar = true;
            // 
            // Tb_NomeFunc
            // 
            this.Tb_NomeFunc.Location = new System.Drawing.Point(82, 119);
            this.Tb_NomeFunc.Name = "Tb_NomeFunc";
            this.Tb_NomeFunc.Size = new System.Drawing.Size(136, 20);
            this.Tb_NomeFunc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Codigo do Funcionário";
            // 
            // Tb_CodFunc
            // 
            this.Tb_CodFunc.Location = new System.Drawing.Point(251, 52);
            this.Tb_CodFunc.Name = "Tb_CodFunc";
            this.Tb_CodFunc.Size = new System.Drawing.Size(55, 20);
            this.Tb_CodFunc.TabIndex = 26;
            this.Tb_CodFunc.TextChanged += new System.EventHandler(this.Tb_CodFunc_TextChanged);
            // 
            // Lb_Cadastro
            // 
            this.Lb_Cadastro.AutoSize = true;
            this.Lb_Cadastro.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Cadastro.Location = new System.Drawing.Point(20, 46);
            this.Lb_Cadastro.Name = "Lb_Cadastro";
            this.Lb_Cadastro.Size = new System.Drawing.Size(106, 28);
            this.Lb_Cadastro.TabIndex = 15;
            this.Lb_Cadastro.Text = "RECadastro";
            // 
            // REcadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(659, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "REcadastroFuncionario";
            this.Text = "REcadastroFuncionario";
            this.Load += new System.EventHandler(this.REcadastroFuncionario_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Func)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dg_Func;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_Cadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_CodFunc;
        private System.Windows.Forms.Button Btn_Visualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.TextBox Tb_TelefoneFunc;
        private System.Windows.Forms.TextBox Tb_EmailFunc;
        private System.Windows.Forms.TextBox Tb_VerificacaoSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cb_Cargo;
        private System.Windows.Forms.TextBox Tb_SenhaFunc;
        private System.Windows.Forms.TextBox Tb_NomeFunc;
    }
}