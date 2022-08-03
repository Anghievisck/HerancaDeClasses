using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heranca_de_classes
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCadastAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastrarAluno aluno = new frmCadastrarAluno();
            aluno.Show()
        }

        private void btnCadastProf_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroProfessor professor = new frmCadastroProfessor();
            professor.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
