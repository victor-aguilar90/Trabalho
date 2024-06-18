namespace PS
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_Login = new System.Windows.Forms.Label();
            this.Btn_duvida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_visualizar = new System.Windows.Forms.Button();
            this.Tb_nome = new System.Windows.Forms.TextBox();
            this.Tb_senha = new System.Windows.Forms.TextBox();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.Lb_Login);
            this.panel1.Controls.Add(this.Btn_duvida);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_visualizar);
            this.panel1.Controls.Add(this.Tb_nome);
            this.panel1.Controls.Add(this.Tb_senha);
            this.panel1.Controls.Add(this.Btn_Entrar);
            this.panel1.Location = new System.Drawing.Point(192, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 390);
            this.panel1.TabIndex = 0;
            // 
            // Lb_Login
            // 
            this.Lb_Login.AutoSize = true;
            this.Lb_Login.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Login.Location = new System.Drawing.Point(109, 104);
            this.Lb_Login.Name = "Lb_Login";
            this.Lb_Login.Size = new System.Drawing.Size(56, 28);
            this.Lb_Login.TabIndex = 14;
            this.Lb_Login.Text = "Login";
            // 
            // Btn_duvida
            // 
            this.Btn_duvida.BackColor = System.Drawing.Color.Khaki;
            this.Btn_duvida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_duvida.Location = new System.Drawing.Point(243, 362);
            this.Btn_duvida.Name = "Btn_duvida";
            this.Btn_duvida.Size = new System.Drawing.Size(24, 25);
            this.Btn_duvida.TabIndex = 11;
            this.Btn_duvida.Text = "?";
            this.Btn_duvida.UseVisualStyleBackColor = false;
            this.Btn_duvida.Click += new System.EventHandler(this.Btn_duvida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // Btn_visualizar
            // 
            this.Btn_visualizar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_visualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_visualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_visualizar.Location = new System.Drawing.Point(217, 199);
            this.Btn_visualizar.Name = "Btn_visualizar";
            this.Btn_visualizar.Size = new System.Drawing.Size(24, 25);
            this.Btn_visualizar.TabIndex = 10;
            this.Btn_visualizar.Text = "👁";
            this.Btn_visualizar.UseVisualStyleBackColor = false;
            this.Btn_visualizar.Click += new System.EventHandler(this.Btn_visualizar_Click);
            // 
            // Tb_nome
            // 
            this.Tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_nome.Location = new System.Drawing.Point(90, 153);
            this.Tb_nome.Name = "Tb_nome";
            this.Tb_nome.Size = new System.Drawing.Size(121, 20);
            this.Tb_nome.TabIndex = 7;
            // 
            // Tb_senha
            // 
            this.Tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_senha.Location = new System.Drawing.Point(90, 202);
            this.Tb_senha.Name = "Tb_senha";
            this.Tb_senha.Size = new System.Drawing.Size(121, 20);
            this.Tb_senha.TabIndex = 8;
            this.Tb_senha.UseSystemPasswordChar = true;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Entrar.Location = new System.Drawing.Point(100, 249);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(75, 25);
            this.Btn_Entrar.TabIndex = 9;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = false;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(659, 411);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_Login;
        private System.Windows.Forms.Button Btn_duvida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_visualizar;
        private System.Windows.Forms.TextBox Tb_nome;
        private System.Windows.Forms.TextBox Tb_senha;
        private System.Windows.Forms.Button Btn_Entrar;
    }
}

