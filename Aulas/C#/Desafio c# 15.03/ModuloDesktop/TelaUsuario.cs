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
    public partial class TelaUsuario : Form
    {
        Image file;
        bool repetido=false;
        public TelaUsuario()
        {
            InitializeComponent();

            AutoCompleteStringCollection dadosListaTime = new AutoCompleteStringCollection();
            AutoCompleteStringCollection dadosListaCor = new AutoCompleteStringCollection();

            // TUDO ISSO SERVE PRA APARECER O EMAIL NO CAMPO DE EMAIL E TRAVAR ESSE CAMPO
            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; 
            SqlConnection conexao = new SqlConnection(ServerConnection);  
            SqlCommand comando;
            comando = new SqlCommand($"Select Email from Usuarios where IdUsuario ={EmailValidation.idUsuario}", conexao);
            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
            dataReader.Read();

            TxbEmail.Text = dataReader[0].ToString();
            TxbEmail.Enabled = false;
            conexao.Close();



            // ADICIONA OS DADOS DE TIMES PARA O AUTOCOMPLETE
            comando = new SqlCommand($"Select timeFavorito from Usuarios", conexao);
            conexao.Open();
            dataReader = comando.ExecuteReader();
            dataReader.Read();

            while (dataReader.Read())
            {
                dadosListaTime.Add(dataReader[0].ToString());
            }
            conexao.Close();


            // ADICIONA OS DADOS DE CORES PARA O AUTOCOMPLETE
            comando = new SqlCommand($"Select corFavorita from Usuarios", conexao);
            conexao.Open();
            dataReader = comando.ExecuteReader();
            dataReader.Read();

            while (dataReader.Read())
            {
                dadosListaCor.Add(dataReader[0].ToString());
            }
            conexao.Close();

            TxbTime.AutoCompleteCustomSource = dadosListaTime;
            TxbCor.AutoCompleteCustomSource = dadosListaCor;

            

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



        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            repetido = false;

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


            // COMPARA OS APELIDOS PARA ENCONTRAR REPETIDOS
            while (dataReader.Read())
            {
                if (TxbApelido.Text == dataReader[0].ToString())
                {
                    repetido = true;
                }
            }
            conexao.Close();

           

            // CASO NAO TENHAM APELIDOS REPETIDOS OU CAMPOS VAZIOS FAZ UPLOAD DOS DADOS NO SERVIDOR
            if ((TxbSenha.Text != "") && (TxbApelido.Text != "") && (TxbTime.Text != "") && (TxbCor.Text != ""))
            {

                if (!repetido)
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

                    MessageBox.Show("Usuario Criado");

                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Apelido Repetido");
                    
                }

            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
            
        }

        
    }
}
