namespace PS
{
    partial class F_Agendar
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
            this.Btn_Agendar = new System.Windows.Forms.Button();
            this.Dg_compra = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_CodProduto = new System.Windows.Forms.TextBox();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_compra)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.Btn_Agendar);
            this.panel2.Controls.Add(this.Dg_compra);
            this.panel2.Location = new System.Drawing.Point(338, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 387);
            this.panel2.TabIndex = 13;
            // 
            // Btn_Agendar
            // 
            this.Btn_Agendar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Agendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agendar.Location = new System.Drawing.Point(20, 354);
            this.Btn_Agendar.Name = "Btn_Agendar";
            this.Btn_Agendar.Size = new System.Drawing.Size(272, 23);
            this.Btn_Agendar.TabIndex = 11;
            this.Btn_Agendar.Text = "Agendar";
            this.Btn_Agendar.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Tb_CodProduto);
            this.panel1.Controls.Add(this.Btn_Adicionar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 387);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código do Produto";
            // 
            // Tb_CodProduto
            // 
            this.Tb_CodProduto.Location = new System.Drawing.Point(120, 23);
            this.Tb_CodProduto.Name = "Tb_CodProduto";
            this.Tb_CodProduto.Size = new System.Drawing.Size(71, 20);
            this.Tb_CodProduto.TabIndex = 9;
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Adicionar.Location = new System.Drawing.Point(197, 21);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Adicionar.TabIndex = 8;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = false;
            // 
            // F_Agendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(659, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Agendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_compra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Agendar;
        private System.Windows.Forms.DataGridView Dg_compra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_CodProduto;
        private System.Windows.Forms.Button Btn_Adicionar;
    }
}