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
    public partial class FrmClientes : FrmModelo
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            clsClientes oClientes = new clsClientes(txtCodigo.Text, 
                                                    txtEmail.Text,
                                                    txtEndereco.Text,
                                                    txtFone.Text, 
                                                    txtNome.Text, 
                                                    txtSaldoDevedor.Text, 
                                                    dtpDataNasc.Value);
            clsPessoa.Gravar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtSaldoDevedor.Text = " ";
            dtpDataNasc.Value = dtpDataNasc.Value;
        }
    }
}
