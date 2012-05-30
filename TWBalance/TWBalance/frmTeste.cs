using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Twitterizer;

namespace TWBalance
{
    public partial class frmPrincipal : Form
    {

        Twitterizer.OAuthTokens TOKEN = new Twitterizer.OAuthTokens();

        public frmPrincipal()
        {
            InitializeComponent();
        }


        public frmPrincipal(Twitterizer.OAuthTokens oauth_tokens)
        {
            //Construtor que recebe o Token do Twitterizer


            TOKEN = oauth_tokens;
            InitializeComponent();
        }

        private void frmTeste_Load(object sender, EventArgs e)
        {


            //Busca do BurnTwitter (Serviço que faz o meio de campo de autenticação com o Twitter) a TimeLine do Usuário


            DataSet dsTwitter = ExecutaTW("GET", "amadeujjunior", "bixoferpa@12", "http://burntwitterapi.appspot.com/api/DkPFpw2VX/statuses/home_timeline.xml");
            dg.DataSource = dsTwitter.Tables["status"];
        }



        private DataSet ExecutaTW(string method, string user, string pwd, string url)
        {
            
            //Metodo que faz as requisições HTTP e retorna um DataSet com os dados.
            
            
            HttpWebRequest request;
            WebResponse response;
            StreamReader reader = null;
            DataSet ds = new DataSet();

            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = method;
                request.Credentials = new NetworkCredential(user, pwd);
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream());

                ds.ReadXml(reader);
                reader.Close();

                return ds;
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao twitter!");
                return null;
            }
        }

    


        private void btnPostar_Click(object sender, EventArgs e)
        {

            //Demostração usando a API Twitterizer para Postar

            Twitterizer.TwitterStatus.Update(TOKEN, txtPost.Text.ToString());

            txtPost.Text = (" ");
          
        }

        private void btnMentions_Click(object sender, EventArgs e)
        {


            //Busca do BurnTwitter (Serviço que faz o meio de campo de autenticação com o Twitter) as Mentions do Usuário   
           DataSet dsTwitter = ExecutaTW("GET", "amadeujjunior", "bixoferpa@12", "http://burntwitterapi.appspot.com/api/DkPFpw2VX/statuses/mentions.xml");

           dg.DataSource = dsTwitter.Tables["status"];
        
  
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
            
        {
            
            //Atualiza a TimeLine
            DataSet dsTwitter = ExecutaTW("GET", "amadeujjunior", "bixoferpa@12", "http://burntwitterapi.appspot.com/api/DkPFpw2VX/statuses/home_timeline.xml");
            dg.DataSource = dsTwitter.Tables["status"];
  
        }

        private void txtPost_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}
