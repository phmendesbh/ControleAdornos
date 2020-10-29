namespace ControleAdornos
{
    partial class FrmPalavras
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvPalavras = new System.Windows.Forms.DataGridView();
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.pnlCor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(9, 58);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(72, 27);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlCor);
            this.panel1.Controls.Add(this.cmbCores);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPalavra);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 93);
            this.panel1.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(373, 70);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Palavra:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPalavra.Location = new System.Drawing.Point(9, 29);
            this.txtPalavra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPalavra.MaxLength = 26;
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(229, 23);
            this.txtPalavra.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(167, 58);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(72, 27);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(89, 58);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(72, 27);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Modificar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgvPalavras
            // 
            this.dgvPalavras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalavras.Location = new System.Drawing.Point(13, 113);
            this.dgvPalavras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPalavras.Name = "dgvPalavras";
            this.dgvPalavras.ReadOnly = true;
            this.dgvPalavras.Size = new System.Drawing.Size(488, 396);
            this.dgvPalavras.TabIndex = 11;
            this.dgvPalavras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriais_CellClick);
            // 
            // cmbCores
            // 
            this.cmbCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCores.FormattingEnabled = true;
            this.cmbCores.Location = new System.Drawing.Point(296, 29);
            this.cmbCores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(184, 23);
            this.cmbCores.TabIndex = 2;
            this.cmbCores.SelectionChangeCommitted += new System.EventHandler(this.cmbCores_SelectionChangeCommitted);
            // 
            // pnlCor
            // 
            this.pnlCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCor.Location = new System.Drawing.Point(250, 29);
            this.pnlCor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCor.Name = "pnlCor";
            this.pnlCor.Size = new System.Drawing.Size(38, 24);
            this.pnlCor.TabIndex = 14;
            this.pnlCor.Tag = "Selecione a cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cor";
            // 
            // FrmPalavras
            // 
            this.AcceptButton = this.btnAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 516);
            this.Controls.Add(this.dgvPalavras);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPalavras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palavras";
            this.Load += new System.EventHandler(this.FrmPalavras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chtLetras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvPalavras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCor;
        private System.Windows.Forms.ComboBox cmbCores;
    }
}

