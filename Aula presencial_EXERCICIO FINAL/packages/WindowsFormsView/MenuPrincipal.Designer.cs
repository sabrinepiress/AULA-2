namespace WindowsFormsView
{
    partial class MenuPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListarP = new System.Windows.Forms.Button();
            this.btnCadastrarP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListarDisc = new System.Windows.Forms.Button();
            this.btnCadDisc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(6, 48);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 19);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListarP);
            this.groupBox2.Controls.Add(this.btnCadastrarP);
            this.groupBox2.Location = new System.Drawing.Point(105, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professores";
            // 
            // btnListarP
            // 
            this.btnListarP.Location = new System.Drawing.Point(6, 47);
            this.btnListarP.Name = "btnListarP";
            this.btnListarP.Size = new System.Drawing.Size(75, 23);
            this.btnListarP.TabIndex = 2;
            this.btnListarP.Text = "Listar";
            this.btnListarP.UseVisualStyleBackColor = true;
            this.btnListarP.Click += new System.EventHandler(this.btnListarP_Click);
            // 
            // btnCadastrarP
            // 
            this.btnCadastrarP.Location = new System.Drawing.Point(6, 19);
            this.btnCadastrarP.Name = "btnCadastrarP";
            this.btnCadastrarP.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarP.TabIndex = 1;
            this.btnCadastrarP.Text = "Cadastrar";
            this.btnCadastrarP.UseVisualStyleBackColor = true;
            this.btnCadastrarP.Click += new System.EventHandler(this.btnCadastrarP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListarDisc);
            this.groupBox3.Controls.Add(this.btnCadDisc);
            this.groupBox3.Location = new System.Drawing.Point(198, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disciplinas";
            // 
            // btnListarDisc
            // 
            this.btnListarDisc.Location = new System.Drawing.Point(6, 47);
            this.btnListarDisc.Name = "btnListarDisc";
            this.btnListarDisc.Size = new System.Drawing.Size(75, 23);
            this.btnListarDisc.TabIndex = 2;
            this.btnListarDisc.Text = "Listar";
            this.btnListarDisc.UseVisualStyleBackColor = true;
            this.btnListarDisc.Click += new System.EventHandler(this.btnListarDisc_Click);
            // 
            // btnCadDisc
            // 
            this.btnCadDisc.Location = new System.Drawing.Point(6, 19);
            this.btnCadDisc.Name = "btnCadDisc";
            this.btnCadDisc.Size = new System.Drawing.Size(75, 23);
            this.btnCadDisc.TabIndex = 1;
            this.btnCadDisc.Text = "Cadastrar";
            this.btnCadDisc.UseVisualStyleBackColor = true;
            this.btnCadDisc.Click += new System.EventHandler(this.btnCadDisc_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(299, 99);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListarP;
        private System.Windows.Forms.Button btnCadastrarP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnListarDisc;
        private System.Windows.Forms.Button btnCadDisc;
    }
}