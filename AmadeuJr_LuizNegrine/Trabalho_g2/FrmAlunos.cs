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
    public partial class FrmAlunos : FrmModelo
    {
        public FrmAlunos()
        {
            InitializeComponent();
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {

        }

       
        

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNumeroMatricula.Text = " ";
            dtpDataInicio.Value = dtpDataInicio.Value;
            cbxCurso.Text = " ";
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            clsAlunos oAlunos = new clsAlunos(txtCodigo.Text,
                                                    txtEmail.Text,
                                                    txtEndereco.Text,
                                                    txtFone.Text,
                                                    txtNome.Text,
                                                    txtNumeroMatricula.Text,
                                                    dtpDataInicio.Value);
            clsPessoa.Gravar();
        }
    }
}
