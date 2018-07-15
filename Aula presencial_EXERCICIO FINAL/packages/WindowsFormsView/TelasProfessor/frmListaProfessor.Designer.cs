namespace WindowsFormsView.TelasProfessor
{
    partial class frmListaProfessor
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
            this.dgvProf = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProf
            // 
            this.dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProf.Location = new System.Drawing.Point(0, 0);
            this.dgvProf.Name = "dgvProf";
            this.dgvProf.Size = new System.Drawing.Size(585, 189);
            this.dgvProf.TabIndex = 0;
            // 
            // frmListaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 189);
            this.Controls.Add(this.dgvProf);
            this.Name = "frmListaProfessor";
            this.Text = "Lista de Professores";
            this.Load += new System.EventHandler(this.frmListaProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProf;
    }
}