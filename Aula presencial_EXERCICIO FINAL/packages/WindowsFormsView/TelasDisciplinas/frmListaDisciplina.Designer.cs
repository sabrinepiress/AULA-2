namespace WindowsFormsView.TelasDisciplinas
{
    partial class frmListaDisciplina
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
            this.dgvDisc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisc
            // 
            this.dgvDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisc.Location = new System.Drawing.Point(0, 0);
            this.dgvDisc.Name = "dgvDisc";
            this.dgvDisc.Size = new System.Drawing.Size(534, 181);
            this.dgvDisc.TabIndex = 0;
            // 
            // frmListaDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 181);
            this.Controls.Add(this.dgvDisc);
            this.Name = "frmListaDisciplina";
            this.Text = "Lista das Disciplinas";
            this.Load += new System.EventHandler(this.frmListaDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisc;
    }
}