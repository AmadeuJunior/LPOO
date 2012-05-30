using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_g2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            FrmAlunos objAlunos = new FrmAlunos();
            objAlunos.Show();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            FrmFuncionarios objFuncionario = new FrmFuncionarios();
            objFuncionario.Show();
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            FrmClientes objClientes = new FrmClientes();
            objClientes.Show();
        }
    }
}
