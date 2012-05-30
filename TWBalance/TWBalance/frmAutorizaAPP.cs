using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;



namespace TWBalance
{
    public partial class frmAutorizaAPP : Form
    {
        public frmAutorizaAPP()
        {
            InitializeComponent();
        }

        //Struct Tokens - Autenticação da APP
        struct Tokens
        {
            public string OAuth_Token;
            public string OAuth_Token_Secret;
            public bool IsEmpty { get; set; }
        }


        //Cria Token para autorizar APP

        Twitterizer.OAuthTokens oauth_tokens = new Twitterizer.OAuthTokens();

        Tokens tokens = new Tokens();
        protected string str_RequestToken;
        protected string consumerKey = "sIxIDToXMjwtZ8cba2RMow";
        protected string consumerSecret = "pDpWeCLWmwpVGbH9ojav0wgeWVHvttAxsp30DOidgAU";



        private void btnSolicitarPIN_Click(object sender, EventArgs e)
        {

            //Método para requisitar do Twitter PIN para autenticaxao oAuth

            str_RequestToken = Twitterizer.OAuthUtility.GetRequestToken(consumerKey, consumerSecret, "oob").Token;

            Uri auth = Twitterizer.OAuthUtility.BuildAuthorizationUri(str_RequestToken, true);
            try
            {
                System.Diagnostics.Process.Start(auth.AbsoluteUri);
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex + "Putzzz......", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {


            //Gera Token apartir do PIN

            if (txtInserePIN.Text == " ")
            {
                MessageBox.Show("Por favor, insira o número gerado pelo Twitter (PIN)", "Erro");
            }

            else
            {
                try
                {
                    string pin = txtInserePIN.Text.ToString();
                    Twitterizer.OAuthTokenResponse response = Twitterizer.OAuthUtility.GetAccessToken(consumerKey, consumerSecret, str_RequestToken, pin);

                    tokens.OAuth_Token = response.Token;
                    tokens.OAuth_Token_Secret = response.TokenSecret;

                    oauth_tokens.ConsumerKey = consumerKey;
                    oauth_tokens.ConsumerSecret = consumerSecret;
                    oauth_tokens.AccessToken = tokens.OAuth_Token;
                    oauth_tokens.AccessTokenSecret = tokens.OAuth_Token_Secret;

                    MessageBox.Show("Autorizado com sucesso!", "Mensagem");

                    frmPrincipal oFrm = new frmPrincipal(oauth_tokens);
                    oFrm.Show();
                }

                catch
                {
                    MessageBox.Show("Ocorreu um erro ao tentar conectar-se ao Twitter. Por favor, tente novamente.", "Erro");
                }
            }
        }

        private void txtInserePIN_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
