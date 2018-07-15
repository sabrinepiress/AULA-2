namespace WindowsFormsView.TelasProfessor
{
    partial class frmCadastroProfessor
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
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Formação: ";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(68, 39);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxtCPF.TabIndex = 3;
            // 
            // txtFormacao
            // 
            this.txtFormacao.Location = new System.Drawing.Point(68, 65);
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(178, 20);
            this.txtFormacao.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 20);
            this.txtNome.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(78, 107);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(159, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 146);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtFormacao);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroProfessor";
            this.Text = "Cadastro de Professores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}