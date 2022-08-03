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
    public partial class frmCadastrarAluno : Form
    {
        Aluno aluno;
        public frmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void frmCadastrarAluno_Load(object sender, EventArgs e)
        {
            aluno = new Aluno(txtNomeAluno, (Convert.ToInt32(txtIdadeAluno.Text), txtCurso.Text);
            txtNomeAluno.Clear();
            txtIdadeAluno.Clear();
            txtCurso.Clear();
        }
        
        public void btnExibirAluno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aluno.ImprimeDados());
        }
    }
}
