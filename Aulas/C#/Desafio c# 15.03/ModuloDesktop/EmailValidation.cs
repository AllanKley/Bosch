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

namespace ModuloDesktop
{
    public partial class EmailValidation : Form
    {

        public static string idUsuario;
        bool cadastrado = false;


        public EmailValidation()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            cadastrado = false;
            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de coneção de conexão 
            SqlCommand comando;
            comando = new SqlCommand("Select * from Usuarios", conexao);
            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
     


            while (dataReader.Read())
            {
                if (TbxEmail.Text == dataReader[1].ToString())
                {
                    if (dataReader[9].ToString() == "") // CONVIDADO
                    {
                        idUsuario = dataReader[0].ToString();

                        TelaUsuario novoUsuario = new TelaUsuario();
                        this.Hide();
                        novoUsuario.Show();

                    }
                    else                                // CADASTRADO
                    {
                     

                        idUsuario = dataReader[0].ToString();

                        Login login = new Login();
                        this.Hide();
                        login.Show();
                        

                    }
                    cadastrado = true;
                }
            }
            if (!cadastrado)                            // NÃO CADASTRADO
            {
                MessageBox.Show("Email não Convidado");
            }
            conexao.Close();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
