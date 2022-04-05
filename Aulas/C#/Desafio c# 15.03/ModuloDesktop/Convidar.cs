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
    public partial class Convidar : Form
    {
        bool repetido = false;

        public Convidar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            repetido = false;
            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instância de conexão 
            SqlCommand comando;

            comando = new SqlCommand($"Select Email from Usuarios", conexao);
            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                if(dataReader[0].ToString() == textBox1.Text)
                {
                    repetido = true;
                }
            }

            if (repetido == false)
            {
                string strSQL = $"insert into Usuarios (IdUsuarios, Email, DataConvite)" +
                    $"Values (@IdUsuarios, @Email, @DataConvite)";
                comando = new SqlCommand(strSQL, conexao);



                comando.Parameters.AddWithValue("@Email", TxbSenha.Text);
              
                comando.Parameters.AddWithValue("@DataConvite", DateTime.Now.Date);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            
        }
    }
}
