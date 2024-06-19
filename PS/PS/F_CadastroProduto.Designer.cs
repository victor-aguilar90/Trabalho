namespace PS
{
    partial class F_CadastroProduto
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
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.QtdP = new System.Windows.Forms.TextBox();
            this.PrecoP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Cadastro = new System.Windows.Forms.Label();
            this.DescP = new System.Windows.Forms.TextBox();
            this.NomeProduto = new System.Windows.Forms.TextBox();
            this.Btn_gerarExcel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.Btn_gerarExcel);
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
            this.dataGridView1.Size = new System.Drawing.Size(272, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.Btn_Cadastrar);
            this.panel1.Controls.Add(this.QtdP);
            this.panel1.Controls.Add(this.PrecoP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Lb_Cadastro);
            this.panel1.Controls.Add(this.DescP);
            this.panel1.Controls.Add(this.NomeProduto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 387);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(69, 335);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cadastrar.TabIndex = 24;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // QtdP
            // 
            this.QtdP.Location = new System.Drawing.Point(37, 191);
            this.QtdP.Name = "QtdP";
            this.QtdP.Size = new System.Drawing.Size(31, 20);
            this.QtdP.TabIndex = 3;
            this.QtdP.TextChanged += new System.EventHandler(this.Tb_QuantidadeDeProduto_TextChanged);
            this.QtdP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_TelefoneFunc_KeyPress);
            // 
            // PrecoP
            // 
            this.PrecoP.Location = new System.Drawing.Point(37, 151);
            this.PrecoP.Name = "PrecoP";
            this.PrecoP.Size = new System.Drawing.Size(136, 20);
            this.PrecoP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Descrição do produto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantidade do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Preço do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome do produto";
            // 
            // Lb_Cadastro
            // 
            this.Lb_Cadastro.AutoSize = true;
            this.Lb_Cadastro.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Cadastro.Location = new System.Drawing.Point(33, 53);
            this.Lb_Cadastro.Name = "Lb_Cadastro";
            this.Lb_Cadastro.Size = new System.Drawing.Size(178, 28);
            this.Lb_Cadastro.TabIndex = 15;
            this.Lb_Cadastro.Text = "Cadastro de produto";
            // 
            // DescP
            // 
            this.DescP.Location = new System.Drawing.Point(38, 230);
            this.DescP.Multiline = true;
            this.DescP.Name = "DescP";
            this.DescP.Size = new System.Drawing.Size(253, 99);
            this.DescP.TabIndex = 4;
            // 
            // NomeProduto
            // 
            this.NomeProduto.Location = new System.Drawing.Point(37, 112);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Size = new System.Drawing.Size(136, 20);
            this.NomeProduto.TabIndex = 0;
            // 
            // Btn_gerarExcel
            // 
            this.Btn_gerarExcel.BackColor = System.Drawing.Color.Khaki;
            this.Btn_gerarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_gerarExcel.Location = new System.Drawing.Point(20, 356);
            this.Btn_gerarExcel.Name = "Btn_gerarExcel";
            this.Btn_gerarExcel.Size = new System.Drawing.Size(272, 23);
            this.Btn_gerarExcel.TabIndex = 25;
            this.Btn_gerarExcel.Text = "Excel";
            this.Btn_gerarExcel.UseVisualStyleBackColor = false;
            // 
            // F_CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(659, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.F_CadastroProduto_Load);
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
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.TextBox QtdP;
        private System.Windows.Forms.TextBox PrecoP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Cadastro;
        private System.Windows.Forms.TextBox DescP;
        private System.Windows.Forms.TextBox NomeProduto;
        private System.Windows.Forms.Button Btn_gerarExcel;
    }
}