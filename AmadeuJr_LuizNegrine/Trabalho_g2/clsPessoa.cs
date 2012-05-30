using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_g2
{
    
    
    public class clsPessoa
    {

        #region atributos

        public string _Nome;
        public string _Codigo;
        public string _Telefone;
        public string _Email;
        public string _Endereco;
      

        #endregion

        #region propriedades

        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }
        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }
        #endregion

        #region Construtor

                       
        #endregion

        #region metodos

        public void Excluir()
        {
            MessageBox.Show(" Excluido!!");
        }

        public static void Gravar()
        {
            MessageBox.Show("Gravado!!");
        }

        public void Novo()
        {
           
        }

        #endregion
    }
}
