using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ModuloDesktop.Esqueceu_a_senha;

namespace ModuloDesktop
{
    public partial class LoginEsqueceuSenha : Form
    {
        int count = 10;
        Timer MyTimer = new Timer();
        public LoginEsqueceuSenha()
        {
            InitializeComponent();

            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de coneção de conexão 
            SqlCommand comando;
            comando = new SqlCommand($"Select Email from Usuarios where IdUsuario ={EmailValidation.idUsuario}", conexao);
            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
            dataReader.Read();


            TxbEmail.Text = dataReader[0].ToString();
            TxbEmail.Enabled = false;
            conexao.Close();

            TxbSenha.Enabled = false;
            count = 10;
        }

        private void BtnColar_Click(object sender, EventArgs e)
        {
            TxbSenha.Text = Clipboard.GetText(); 
        }

        private void LoginEsqueceuSenha_Load(object sender, EventArgs e)
        {
            
            MyTimer.Interval = (1000);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();

            Bola1.Visible = false;
            Bola2.Visible = false;
            Bola3.Visible = false;
            Bola4.Visible = false;
            Bola5.Visible = false;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if(count > 0)
            {
                lblTempo.Text = $"Tempo restante: {count} segundos";
            }

            
            if(count == 0)
            {
                count = -222;
                lblTempo.Text = "Tempo restante: 0 segundos";
                MessageBox.Show("Tempo Esgotado");
                this.Hide();
                Login TelaLogin = new Login();
                TelaLogin.Show();
                MyTimer.Stop();
            }
            else
            {

                if (count % 2 == 0)
                {
                    switch (count / 2)
                    {
                        case 1:
                            Bola5.Visible = true;
                            break;
                        case 2:
                            Bola4.Visible = true;
                            break;
                        case 3:
                            Bola3.Visible = true;
                            break;
                        case 4:
                            Bola2.Visible = true;
                            break;
                        case 5:
                            Bola1.Visible = true;
                            break;

                    }
                }
            }

            if(count >=0)
            {
                count--;
            }
            else
            {
                count = -222;
            }

            
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();

            if (TxbSenha.Text == SenhaRandomica.Senha)
            {
                MessageBox.Show("Senha Correta");
                AlterarSenha AlterarSenha = new AlterarSenha();
                this.Hide();
                AlterarSenha.Show();
            }
            else
            {
                MessageBox.Show("Senha incorreta! Tente novamente");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
