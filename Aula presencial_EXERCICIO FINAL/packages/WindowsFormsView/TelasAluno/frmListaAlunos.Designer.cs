namespace WindowsFormsView.TelasAluno
{
    partial class frmListaAlunos
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
            this.dvgAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgAlunos
            // 
            this.dvgAlunos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dvgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAlunos.Location = new System.Drawing.Point(2, 3);
            this.dvgAlunos.Name = "dvgAlunos";
            this.dvgAlunos.Size = new System.Drawing.Size(622, 190);
            this.dvgAlunos.TabIndex = 0;
            // 
            // frmListaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 194);
            this.Controls.Add(this.dvgAlunos);
            this.Name = "frmListaAlunos";
            this.Text = "Lista De Alunos";
            this.Load += new System.EventHandler(this.frmListaAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgAlunos;
    }
}