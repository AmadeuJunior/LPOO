using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {

        string pNome;


        public Form1()
        {
            InitializeComponent();
        }
        #region Atributos

        private string _arquivo;
        private string _menssagem;

        #endregion
        // ve se botão esta selecionado
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

           
            if (btnNegrito.CheckState == CheckState.Checked)
            {
                //coloca fonte em negrito
                Font fot = new Font(Font, FontStyle.Bold);
                rtbRecebe.SelectionFont = fot;
            }
            else
            {
                //coloca texto normal
                Font fot = new Font(Font, FontStyle.Regular);
                rtbRecebe.SelectionFont = fot;
            }
        }

        //fecha janela
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        //abri documento
        private void menuAbrir_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = @"C:\Documentos"; //caminho
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                
                try
                {
                   
                        FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        pNome = openFileDialog1.FileName;    
                        StreamReader m_streamReader = new StreamReader(fs);
                        // Lendo para o arquivo usando a classe StreamReader
                     
                        m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

                        // Lê cada linha do stream e efetua o parse até alcançar a última linha
                        this.rtbRecebe.Text = "";
                        string linha = m_streamReader.ReadLine();
                        while (linha != null)
                        {
                            this.rtbRecebe.Text += linha + "\n";
                            linha = m_streamReader.ReadLine();
                        }
                        //Fecha o Stream
                        m_streamReader.Close();
                    }
                
                catch (Exception em)
                {
                    MessageBox.Show(" Erro : " + em.Message.ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuSalvar_Click(object sender, EventArgs e)
        {
            try
            {

           //     if (pNome == "")
             //   {

                    // Obtem o nome do arquivo para salvar
                    if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //abre o stream para escrever e cria um StreamWriter para usar na implementacao do stream
                        FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter m_streamWriter = new StreamWriter(fs);
                        m_streamWriter.Flush();

                        // Escreve o artigo usando a classe StreamWriter
                        m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

                        // Escrever no controle rich edit control
                        m_streamWriter.Write(this.rtbRecebe.Text);

                        // fecha o arquivo
                        m_streamWriter.Flush();
                        m_streamWriter.Close();
                    }
               /* }
                else
                {
                    FileStream fs = new FileStream(pNome, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter m_streamWriter = new StreamWriter(fs);
                    m_streamWriter.Flush();

                    // Escreve o artigo usando a classe StreamWriter
                    m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

                    // Escrever no controle rich edit control
                    m_streamWriter.Write(this.rtbRecebe.Text);

                    // fecha o arquivo
                    m_streamWriter.Flush();
                    m_streamWriter.Close();
                }*/

            }
            catch (Exception em)
            {
                MessageBox.Show(" Erro : " + em.Message.ToString());
            }
        }

       
        private void btnItalico_CheckedChanged(object sender, EventArgs e)
        {
            if (btnItalico.CheckState == CheckState.Checked)
            {
                //coloca fonte em italico
                Font fot = new Font(Font, FontStyle.Italic);
                rtbRecebe.SelectionFont = fot;

            }
            else
            {
                //coloca texto normal
                Font fot = new Font(Font, FontStyle.Regular);
                rtbRecebe.SelectionFont = fot;
            }
        }

        private void btnSublinhado_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSublinhado.CheckState == CheckState.Checked)
            {
                //coloca fonte sublinhada
                Font fot = new Font(Font, FontStyle.Underline);
                rtbRecebe.SelectionFont = fot;
            }
            else
            {
                //coloca texto normal
                Font fot = new Font(Font, FontStyle.Regular);
                rtbRecebe.SelectionFont = fot;
            }
        }

        private void fonteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                rtbRecebe.Font = fontDialog1.Font;
                rtbRecebe.SelectionFont = fontDialog1.Font;
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();   
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbRecebe.Text = "";
        }

       
  }
}

