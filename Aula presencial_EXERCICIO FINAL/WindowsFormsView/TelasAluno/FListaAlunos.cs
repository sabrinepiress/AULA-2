using System;
using System.Windows.Forms;
using Controllers;
using Modelos;
using Controllers.DAL;

namespace WindowsFormsView.TelasAluno
{
    public partial class FListaAlunos : Form
    {
        Contexto contexto = new Contexto();

        public FListaAlunos()
        {
            InitializeComponent();
        }

        private void frmListaAlunos_Load(object sender, EventArgs e)
        {
            AlunosController alunosController = new AlunosController();
            dvgAlunos.DataSource = alunosController.ListarTodos();
        }
    }
}
