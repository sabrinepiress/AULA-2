using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controllers;

namespace WindowsFormsView.TelasDisciplinas
{
    public partial class frmCadastroDisciplina : Form
    {
        public frmCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = string.Empty;
            txtCod.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Disciplina novaDisc = new Disciplina();

            novaDisc.Titulo = txtTitulo.Text;
            novaDisc.Codigo = txtCod.Text;

            DisciplinaController disciplinaController = new DisciplinaController();
            disciplinaController.Inserir(novaDisc);
        }
    }
}
