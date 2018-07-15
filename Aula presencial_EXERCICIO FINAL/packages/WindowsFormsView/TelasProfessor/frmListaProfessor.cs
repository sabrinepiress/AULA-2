using System;
using System.Windows.Forms;
using Controllers;

namespace WindowsFormsView.TelasProfessor
{
    public partial class frmListaProfessor : Form
    {
        public frmListaProfessor()
        {
            InitializeComponent();
        }

        private void frmListaProfessor_Load(object sender, EventArgs e)
        {
            ProfessorController professorController = new ProfessorController();
            dgvProf.DataSource = professorController.ListarTodosProf();
        }
    }
}
