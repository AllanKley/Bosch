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
using System.IO;


namespace ModuloDesktop
{
    public partial class TelaPerfil : Form
    {
        Image file;
       
        public TelaPerfil()
        {
            InitializeComponent();

            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de conexão 
            SqlCommand comando;
            try
            {
                comando = new SqlCommand($"SELECT Foto from Usuarios where idUsuario = {EmailValidation.idUsuario}", conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();

                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Foto"]);
                    PicturePerfil.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Usuário sem foto de perfil | {0}", ex);
                PicturePerfil.Image = Image.FromFile(@"S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\1 - Alunos\Allan Kley\Desafio c# 15.03\DataFiles\Icones\SemFoto.png");
            }


           
      
            comando = new SqlCommand($"Select * from Usuarios where IdUsuario ={EmailValidation.idUsuario}", conexao); // comando de select 
            conexao.Open();
            SqlDataReader dr = comando.ExecuteReader();
            dr.Read();

            //preenchendo os campos dos dados do perfil
            TxbEmail.Text = dr[1].ToString();
            TxbEmail.Enabled = false;
            TxbApelido.Text = dr[4].ToString();
            TxbCor.Text = dr[6].ToString();
            TxbTime.Text = dr[5].ToString();
            TxbSenha.Text = dr[2].ToString();

            string strDataNas = dr[7].ToString(); // pegando a data de nascimento  do table e transformando em string

            DateTime DataNasc = Convert.ToDateTime(strDataNas); // convertendo a tstring para datetime
            TxbNascimento.Value = DataNasc; // colocando datetime  na tela


            TxbSenha.UseSystemPasswordChar = true;
            OlhoAberto.Visible = true;
            OlhoCortado.Visible = false;

        }

        //ISSO SERVE PRA DAR UPLOAD EM UMA IMAGEM
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
                PicturePerfil.Image = file;
            }
        }



        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
           

            // PEGA OS APELIDOS DO SERVIDOR
            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;";
            SqlConnection conexao = new SqlConnection(ServerConnection);
            SqlCommand comando;
            comando = new SqlCommand("Select apelido from Usuarios", conexao);
            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();



            //CONVERSÃO IMAGEM PARA HEXADECIMAL
            byte[] imageData = null;

            using (var ms = new MemoryStream())
            {
                PicturePerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }


            
            conexao.Close();



            // CASO NAO TENHAM APELIDOS REPETIDOS OU CAMPOS VAZIOS FAZ UPLOAD DOS DADOS NO SERVIDOR
            if ((TxbSenha.Text != "") && (TxbApelido.Text != "") && (TxbTime.Text != "") && (TxbCor.Text != ""))
            {

               
                    string strSQL = $"UPDATE Usuarios SET Senha = @SENHA, apelido= @APELIDO, timeFavorito= @TIME, corFavorita= @COR, Foto = @Foto, DataCadastro = @DataCadastro, nascimento = @nascimento where idUsuario = {EmailValidation.idUsuario}";
                    comando = new SqlCommand(strSQL, conexao);



                    comando.Parameters.AddWithValue("@SENHA", TxbSenha.Text);
                    comando.Parameters.AddWithValue("@APELIDO", TxbApelido.Text);
                    comando.Parameters.AddWithValue("@TIME", TxbTime.Text);
                    comando.Parameters.AddWithValue("@COR", TxbCor.Text);
                    comando.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = imageData;
                    comando.Parameters.AddWithValue("@nascimento", TxbNascimento.Value.ToString());
                    comando.Parameters.AddWithValue("@DataCadastro", DateTime.Now.Date);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario Atualizado");

                    conexao.Close();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
        }

        private void OlhoCortado_Click(object sender, EventArgs e)
        {
            TxbSenha.UseSystemPasswordChar = true;
            OlhoAberto.Visible = true;
            OlhoCortado.Visible = false;
        }

        private void OlhoAberto_Click(object sender, EventArgs e)
        {
            TxbSenha.UseSystemPasswordChar = false;
            OlhoAberto.Visible = false;
            OlhoCortado.Visible = true;
        }
    }
}
