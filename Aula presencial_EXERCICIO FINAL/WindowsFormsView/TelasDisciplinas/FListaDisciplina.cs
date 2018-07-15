using System;
using System.Windows.Forms;
using Controllers;

namespace WindowsFormsView.TelasDisciplinas
{
    public partial class FListaDisciplina : Form
    {
        public FListaDisciplina()
        {
            InitializeComponent();
        }

        private void FListaDisciplina_Load(object sender, EventArgs e)
        {
            DisciplinaController disciplinaController = new DisciplinaController();
            dgvDisc.DataSource = disciplinaController.ListarTodosDisc();
        }
    }
}
