namespace PS
{
    partial class F_ComprarProduto
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
            this.Dg_compra = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Tb_CodProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_comprar = new System.Windows.Forms.Button();
            this.Tb_qtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_compra)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.Btn_comprar);
            this.panel2.Controls.Add(this.Dg_compra);
            this.panel2.Location = new System.Drawing.Point(338, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 387);
            this.panel2.TabIndex = 11;
            // 
            // Dg_compra
            // 
            this.Dg_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_compra.Location = new System.Drawing.Point(20, 21);
            this.Dg_compra.Name = "Dg_compra";
            this.Dg_compra.Size = new System.Drawing.Size(272, 327);
            this.Dg_compra.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Tb_qtProduto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Tb_CodProduto);
            this.panel1.Controls.Add(this.Btn_Adicionar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 387);
            this.panel1.TabIndex = 10;
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Adicionar.Location = new System.Drawing.Point(163, 209);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Adicionar.TabIndex = 8;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = false;
            // 
            // Tb_CodProduto
            // 
            this.Tb_CodProduto.Location = new System.Drawing.Point(163, 157);
            this.Tb_CodProduto.Name = "Tb_CodProduto";
            this.Tb_CodProduto.Size = new System.Drawing.Size(75, 20);
            this.Tb_CodProduto.TabIndex = 9;
            this.Tb_CodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_CodProduto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código do Produto";
            // 
            // Btn_comprar
            // 
            this.Btn_comprar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_comprar.Location = new System.Drawing.Point(20, 354);
            this.Btn_comprar.Name = "Btn_comprar";
            this.Btn_comprar.Size = new System.Drawing.Size(272, 23);
            this.Btn_comprar.TabIndex = 11;
            this.Btn_comprar.Text = "Comprar";
            this.Btn_comprar.UseVisualStyleBackColor = false;
            // 
            // Tb_qtProduto
            // 
            this.Tb_qtProduto.Location = new System.Drawing.Point(163, 183);
            this.Tb_qtProduto.Name = "Tb_qtProduto";
            this.Tb_qtProduto.Size = new System.Drawing.Size(75, 20);
            this.Tb_qtProduto.TabIndex = 11;
            this.Tb_qtProduto.TextChanged += new System.EventHandler(this.Tb_qtProduto_TextChanged);
            this.Tb_qtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_qtProduto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantidade do Produto";
            // 
            // F_ComprarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(659, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ComprarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Produto";
            this.Load += new System.EventHandler(this.F_ComprarProduto_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_compra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dg_compra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_comprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_CodProduto;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_qtProduto;
    }
}