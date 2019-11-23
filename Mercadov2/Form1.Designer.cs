namespace Mercadov2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCarrinhodeCompras = new System.Windows.Forms.ListBox();
            this.txtCod_Barrras = new System.Windows.Forms.MaskedTextBox();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.MaskedTextBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod. Barras";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço";
            // 
            // lstCarrinhodeCompras
            // 
            this.lstCarrinhodeCompras.FormattingEnabled = true;
            this.lstCarrinhodeCompras.Location = new System.Drawing.Point(249, 12);
            this.lstCarrinhodeCompras.Name = "lstCarrinhodeCompras";
            this.lstCarrinhodeCompras.Size = new System.Drawing.Size(120, 212);
            this.lstCarrinhodeCompras.TabIndex = 6;
            // 
            // txtCod_Barrras
            // 
            this.txtCod_Barrras.Location = new System.Drawing.Point(127, 90);
            this.txtCod_Barrras.Mask = "0 000 000 000";
            this.txtCod_Barrras.Name = "txtCod_Barrras";
            this.txtCod_Barrras.Size = new System.Drawing.Size(100, 20);
            this.txtCod_Barrras.TabIndex = 8;
            this.txtCod_Barrras.ValidatingType = typeof(int);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(127, 126);
            this.txtPreco.Mask = "$ 00,00";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 9;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(127, 57);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProduto.TabIndex = 10;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(249, 247);
            this.txtSubtotal.Mask = "$ 00,00";
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(120, 20);
            this.txtSubtotal.TabIndex = 11;
            this.txtSubtotal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(21, 201);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 23);
            this.btnRetirar.TabIndex = 12;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(127, 201);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 287);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCod_Barrras);
            this.Controls.Add(this.lstCarrinhodeCompras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCarrinhodeCompras;
        private System.Windows.Forms.MaskedTextBox txtCod_Barrras;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.MaskedTextBox txtSubtotal;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnAdicionar;
    }
}

