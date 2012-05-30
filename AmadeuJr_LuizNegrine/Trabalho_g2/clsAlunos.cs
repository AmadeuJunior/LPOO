using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_g2
{
    public class clsAlunos : clsPessoa
    {
        #region Atributos

        public string _Curso;
        public DateTime _DataInicio;
        private string p;
        private DateTime dateTime;
        private string p_2;
        private string p_3;
        private string p_4;
        private string p_5;
        private string p_6;

        #endregion

        #region Construtor
                
        public clsAlunos(string pMatricula, DateTime dateTime)
        {
            
            this.p = pMatricula;
            this.dateTime = dateTime;
        }

        public clsAlunos(string p, string p_2, string p_3, string p_4, string p_5, string p_6, DateTime dateTime)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
            this.p_3 = p_3;
            this.p_4 = p_4;
            this.p_5 = p_5;
            this.p_6 = p_6;
            this.dateTime = dateTime;
        }

        #endregion

        #region Propriedades

        public string Curso
        {
            get { return _Curso; }
            set { _Curso = value; }
        }
        public DateTime DataNasc
        {
            get { return _DataInicio; }
            set { _DataInicio = value; }
        }
        #endregion

    }
}
