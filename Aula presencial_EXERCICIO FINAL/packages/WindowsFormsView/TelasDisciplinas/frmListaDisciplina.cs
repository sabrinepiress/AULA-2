using System;
using System.Windows.Forms;
using Controllers;

namespace WindowsFormsView.TelasDisciplinas
{
    public partial class frmListaDisciplina : Form
    {
        public frmListaDisciplina()
        {
            InitializeComponent();
        }

        private void frmListaDisciplina_Load(object sender, EventArgs e)
        {
            DisciplinaController disciplinaController = new DisciplinaController();
            dgvDisc.DataSource = disciplinaController.ListarTodosDisc();
        }
    }
}
