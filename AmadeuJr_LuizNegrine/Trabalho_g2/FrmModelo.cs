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
    public partial class FrmModelo : Form
    {
        public FrmModelo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = " ";
            txtFone.Text = " ";
            txtEndereco.Text = "";
            txtEmail.Text = "";
            txtCodigo.Text = " ";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            clsPessoa oPessoa = new clsPessoa();
            oPessoa.Excluir();
        }

      
    }
}
