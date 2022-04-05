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

namespace ModuloDesktop.Esqueceu_a_senha
{
    public partial class AlterarSenha : Form
    {
        public AlterarSenha()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string novaSenha = TxbSenha.Text;
            if (novaSenha != null)
            {
                string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;";// caminho de conexão com o DB
                SqlConnection conexao = new SqlConnection(ServerConnection); // instancia de objeto de conecao com o db
                
                SqlCommand comando = new SqlCommand("Update Usuarios Set Senha = (@senha) where idUsuario = (@id)", conexao);
                comando.Parameters.AddWithValue("@senha", novaSenha);
                comando.Parameters.AddWithValue("@id", EmailValidation.idUsuario);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Senha alterada !");
                this.Hide();
                Login login = new Login();
                login.Show();

            }
            else
            {
                MessageBox.Show("Não é permitido senhas vazias" +
                    "Tente Novamente");
            }
            
        }
    }
}
