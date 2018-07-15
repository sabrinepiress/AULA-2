using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsView.TelasAluno;
using WindowsFormsView.TelasProfessor;
using WindowsFormsView.TelasDisciplinas;

namespace WindowsFormsView
{
    public partial class PagPrincipal : Form
    {
        public PagPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FCAluno frmaluno = new FCAluno();
            frmaluno.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FListaAlunos listaAlunos = new FListaAlunos();
            listaAlunos.Show();
        }

        private void btnCadastrarP_Click(object sender, EventArgs e)
        {
            frmCadastroProfessor frmprofessor = new frmCadastroProfessor();
            frmprofessor.Show();
        }

        private void btnListarP_Click(object sender, EventArgs e)
        {
            frmListaProfessor listaProfessor = new frmListaProfessor();
            listaProfessor.Show();
        }

        private void btnCadDisc_Click(object sender, EventArgs e)
        {
            frmCadastroDisciplina frmdisciplina = new frmCadastroDisciplina();
            frmdisciplina.Show();
        }

        private void btnListarDisc_Click(object sender, EventArgs e)
        {
            frmListaDisciplina listaDisciplina = new frmListaDisciplina();
            listaDisciplina.Show();
        }
    }
}
