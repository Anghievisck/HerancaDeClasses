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
    public partial class frmCadastroProfessor : Form
    {
        Professor professor;
        public frmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            professor = new Professor(txtNomeProf.Text, (Convert.ToInt32(txtIdadeProf.Text)), txtTitulacao.Text);
            txtNomeProf.Clear();
            txtIdadeProf.Clear();
            txtTitulacao.Clear();
        }

        private void btnExibirProf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(professor.ImprimeDados());
        }

        private void btnVoltarProf_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome principal = new frmHome();
            principal.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
