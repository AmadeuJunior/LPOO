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
    public partial class FrmFuncionarios : FrmModelo
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtSalario.Text = " ";
            dtpDataAdmissao.Value = dtpDataAdmissao.Value;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            clsFuncionarios oFuncionario = new clsFuncionarios(txtCodigo.Text,
                                                    txtEmail.Text,
                                                    txtEndereco.Text,
                                                    txtFone.Text,
                                                    txtNome.Text,
                                                    txtSalario.Text,
                                                    dtpDataAdmissao.Value);
            clsPessoa.Gravar();
        }
    }
}
