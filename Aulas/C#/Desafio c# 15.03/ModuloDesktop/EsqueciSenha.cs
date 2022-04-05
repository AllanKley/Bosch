using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDesktop
{
    public partial class EsqueciSenha : Form
    {
        List<string> Perguntas = new List<string>();
        List<string> Campo = new List<string>();
        int IndexAnswer;
        public EsqueciSenha()
        {
            InitializeComponent();

            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de coneção de conexão 
            
            SqlCommand query = new SqlCommand("Select  * from Pergunta", conexao); // comando de query
            conexao.Open();

            SqlDataReader dataReader = query.ExecuteReader();

            while (dataReader.Read()) // se tiver algo no query
            {
                Perguntas.Add(dataReader[1].ToString()); // adicionando os dados das perguntas em uma lista em ordem
                Campo.Add(dataReader[2].ToString()); // adcionando os dados do Nome do CAmpo em uma lista em ordem
            }

            lblQuestion.Text = Perguntas[0]; // mostrando a primeira pergunta 
            DataPicker.Show(); // mostrando o campo de escolha de data 
            txbResposta.Hide(); // escondendo a tela de Esqueceu a text box
            IndexAnswer = 0; // setando o indexAnswer como a 0´para  aprimeira pergunta 

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            string idUsuario = EmailValidation.idUsuario;
            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de coneção de conexão 

            SqlCommand query = new SqlCommand($"Select {Campo[IndexAnswer]} from Usuarios " +
                $"where idusuario = {idUsuario}", conexao); // comando de query
            // se utiliza o Campo[indexAnswer para pegar o nome da coluna que contem a resposta da pergunta
            conexao.Open();
             // lendo as resposta das perguntas 
            SqlDataReader dataReader = query.ExecuteReader();
            dataReader.Read();

            if(IndexAnswer == 0) // se for a primeira pergunta
            {
                if (DataPicker.Value.Date == Convert.ToDateTime(dataReader[0]).Date)  // conversao de datetime para date
                    {
                    MessageBox.Show("RespostaCorreta");
                    this.Hide();
                    SenhaRandomica TrocarSenha = new SenhaRandomica();
                    TrocarSenha.Show();
                }
                else
                {
                    MessageBox.Show("Resposta InCorreta");
                    IndexAnswer++;
                }
            }
            else  // caso a resposta nao  seja um date time
            {
                if(dataReader[0].ToString() == txbResposta.Text)
                {
                    MessageBox.Show("RespostaCorreta");
                    this.Hide();
                    SenhaRandomica TrocarSenha = new SenhaRandomica();
                    TrocarSenha.Show();
                }
                else
                {
                    MessageBox.Show("Resposta Errada aaa");
                    txbResposta.Text = "";
                    IndexAnswer++;
                }
            }

            
            if(IndexAnswer == Perguntas.Count) 
            {
                DataPicker.Show();
                DataPicker.Value = DateTime.Now;
                txbResposta.Hide();
                IndexAnswer = 0;
                lblQuestion.Text = Perguntas[IndexAnswer];
            }
            else if (IndexAnswer > 0)
            {
                DataPicker.Hide();
                txbResposta.Show();
                lblQuestion.Text = Perguntas[IndexAnswer];
            }

        }
    }
}
