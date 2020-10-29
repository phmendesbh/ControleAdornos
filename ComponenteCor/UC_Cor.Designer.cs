namespace ComponenteCor
{
    partial class UC_Cor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlCor
            // 
            this.pnlCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCor.Location = new System.Drawing.Point(1, 18);
            this.pnlCor.Name = "pnlCor";
            this.pnlCor.Size = new System.Drawing.Size(33, 21);
            this.pnlCor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cor";
            // 
            // cmbCores
            // 
            this.cmbCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCores.DropDownWidth = 158;
            this.cmbCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCores.FormattingEnabled = true;
            this.cmbCores.Location = new System.Drawing.Point(40, 18);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(158, 21);
            this.cmbCores.TabIndex = 2;
            this.cmbCores.SelectionChangeCommitted += new System.EventHandler(this.cmbCores_SelectionChangeCommitted);
            // 
            // UC_Cor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbCores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCor);
            this.Name = "UC_Cor";
            this.Size = new System.Drawing.Size(200, 42);
            this.Load += new System.EventHandler(this.UC_Cor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCores;
    }
}
