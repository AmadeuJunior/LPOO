using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_g2
{
    public class clsClientes : clsPessoa
    {
        #region atributos

        public DateTime _DataNasc;
        public double _SaldoDev;
        private string p;
        private string p_2;
        private string p_3;
        private string p_4;
        private string p_5;
        private string p_6;
        private DateTime dateTime;

        public clsClientes(string pCodigo, string pEmail, string pEndereco, string pFone, string p_5, string pNome, DateTime DataNasc)
        {
          
            this.p = pCodigo;
            this.p_2 = pEmail;
            this.p_3 = pEndereco;
            this.p_4 = pFone;
            this.p_5 = p_5;
            this.p_6 = pNome;
            this.dateTime = DataNasc;
        }

        #endregion

        #region Propriedades

        public DateTime DataNasc
        {
            get { return _DataNasc; }
            set { _DataNasc = value; }
        }
        public double SaldoDev
        {
            get { return _SaldoDev; }
            set { _SaldoDev = value; }
        }

        #endregion


    }
}
