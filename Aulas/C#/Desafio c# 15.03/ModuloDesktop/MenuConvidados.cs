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
    public partial class MenuConvidados : Form
    {
        int count = 1;
        int page = 0;
        int wait = 1;
        int pageTotal = 0;
        int idPesquisa = 0;
        String dataCadastro;
        string dataConvite;
        string status;

        public MenuConvidados()
        {
            
            InitializeComponent();

            

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            BtnVoltar.Hide();
            AutoCompleteStringCollection dadosListaApelido = new AutoCompleteStringCollection();

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
                    img_Perf.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Usuário sem foto de perfil | {0}", ex);
                img_Perf.Image = Image.FromFile(@"S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\1 - Alunos\Allan Kley\Desafio c# 15.03\DataFiles\Icones\SemFoto.png");
            }




            conexao.Open();
            // Conta total de Paginas
            comando = new SqlCommand($"Select apelido from Usuarios where idIndicado = {EmailValidation.idUsuario} ", conexao);
            SqlDataReader dataReader = comando.ExecuteReader();


            while (dataReader.Read())
            {
                pageTotal++;
            }
  
            pageTotal = (pageTotal + 4 - 1) / 4;
            conexao.Close();

            PrintElements();



            // ADICIONA OS DADOS DE APELIDOS PARA O AUTOCOMPLETE
            comando = new SqlCommand($"Select apelido from Usuarios", conexao);
            conexao.Open();
            dataReader = comando.ExecuteReader();
            dataReader.Read();

            while (dataReader.Read())
            {
                dadosListaApelido.Add(dataReader[0].ToString());
            }

            TxbPesquisa.AutoCompleteCustomSource = dadosListaApelido;


            conexao.Close();

        }

        private void BtnProxPag_Click(object sender, EventArgs e)
        {
            page++;
            PrintElements();
        }

        private void BtnPagAnt_Click(object sender, EventArgs e)
        {
            page--;
            PrintElements();
        }

        private void img_Perf_Click(object sender, EventArgs e)
        {
            TelaPerfil perfil = new TelaPerfil();
            perfil.Show();
         
        }

        private void BtnJogos_Click_1(object sender, EventArgs e)
        {
            FormJogos jogos = new FormJogos();
            jogos.Show();
            this.Hide();
        }



        private void SearchPic_Click(object sender, EventArgs e)
        {
            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de conexão 
            SqlCommand comando = new SqlCommand("Select IdUsuario from Usuarios where apelido = (@apelido) ", conexao);

            comando.Parameters.AddWithValue("@apelido", TxbPesquisa.Text);

            conexao.Open();

            
            SqlDataReader dataReader = comando.ExecuteReader();


            dataReader.Read();


            idPesquisa = int.Parse(dataReader[0].ToString());

   
            PrintElements();

            conexao.Close();
        }



        private void PrintElements()
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            Status1.Hide();
            Status2.Hide();
            Status3.Hide();
            Status4.Hide();
            Status1.ForeColor = Color.Black;
            Status2.ForeColor = Color.Black;
            Status3.ForeColor = Color.Black;
            Status4.ForeColor = Color.Black;

            count = 1;
            wait = 0;


            if (page == 0)
            {
                BtnPagAnt.Hide();
            }
            else
            {
                BtnPagAnt.Show();
            }



            if (page + 1 == pageTotal)
            {
                BtnProxPag.Hide();
            }
            else
            {
                BtnProxPag.Show();
            }




            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instância de conexão 
            SqlCommand comando;

            if (idPesquisa != 0)
            {
                // ADICIONA OS DADOS DE NOME E TIME FAVORITO PARA O LISTVIEW
                comando = new SqlCommand($"Select apelido, DataCadastro, DataConvite from Usuarios where idUsuario = {idPesquisa}", conexao);
                conexao.Open();
                SqlDataReader dataReader = comando.ExecuteReader();

                dataReader.Read();

                dataCadastro = dataReader[1].ToString();
                dataConvite = dataReader[2].ToString();
                Status();


                textBox1.Show();
                pictureBox1.Show();
                Status1.Show();

                textBox1.Text = dataReader[0].ToString();
                Status1.Text = status;

                
                BtnVoltar.Show();
                BtnPagAnt.Hide();
                BtnProxPag.Hide();
            }
            else
            {
                // ADICIONA OS DADOS DE NOME E TIME FAVORITO PARA O LISTVIEW
                comando = new SqlCommand($"Select apelido, DataCadastro, DataConvite from Usuarios where idIndicado = {EmailValidation.idUsuario} order by apelido asc", conexao);
                conexao.Open();
                SqlDataReader dataReader = comando.ExecuteReader();

                

                while (dataReader.Read())
                {

                    dataCadastro = dataReader[1].ToString();
                    dataConvite = dataReader[2].ToString();
                    Status();

                    if (wait >= 4 * page)
                    {
                        if (count == 1)
                        {
                            textBox1.Show();
                            pictureBox1.Show();
                            Status1.Show();

                            textBox1.Text = dataReader[0].ToString();
                            Status1.Text = status;

                            if (status == "Pendente")
                            {
                                textBox1.Text = "anon";
                                Status1.ForeColor = Color.Yellow;
                 
                            }
                            else if (status == "Expirado")
                            {
                                textBox1.Text = "anon";
                                Status1.ForeColor = Color.Red;
            
                            }
                        }
                        else if (count == 2)
                        {
                            textBox2.Show();
                            pictureBox2.Show();
                            Status2.Show();
                            Status2.Text = status;

                            textBox2.Text = dataReader[0].ToString();
                            if (status == "Pendente")
                            {
                                textBox2.Text = "anon";
                                Status2.ForeColor = Color.Yellow;
                         
                            }
                            else if (status == "Expirado")
                            {
                                textBox2.Text = "anon";
                                Status2.ForeColor = Color.Red;
                          
                            }

                        }
                        else if (count == 3)
                        {
                            textBox3.Show();
                            pictureBox3.Show();
                            Status3.Show();
                            Status3.Text = status;

                            textBox3.Text = dataReader[0].ToString();
                            if (status == "Pendente")
                            {
                                textBox3.Text = "anon";
                                Status3.ForeColor = Color.Yellow;
                         
                            }
                            else if (status == "Expirado")
                            {
                                textBox3.Text = "anon";
                                Status3.ForeColor = Color.Red;
                            
                            }
                        }
                        else if (count == 4)
                        {
                            textBox4.Show();
                            pictureBox4.Show();
                            Status4.Show();
                            Status4.Text = status;

                            textBox4.Text = dataReader[0].ToString();

                            if (status == "Pendente")
                            {
                                textBox4.Text = "anon";
                                Status4.ForeColor = Color.Yellow;
               
                            }else if (status == "Expirado")
                            {
                                textBox4.Text = "anon";
                                Status4.ForeColor = Color.Red;
                    
                            }
                        }

                        count++;
                    }
                    wait++;

                }
                conexao.Close();
            }

            
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TxbPesquisa.Text = "";
            BtnVoltar.Hide();
            idPesquisa = 0;
            PrintElements();
        }



        private void Status()
        {

            if (dataCadastro == "")
            {
                TimeSpan span = DateTime.Now.Subtract(DateTime.Parse(dataConvite));

                if (span.Days > 30)
                {
                    status = "Expirado";
                }
                else
                {
                    status = "Pendente";
                }

                
            }
            else
            {
                
                status = "Cadastrado";
                
            }
        }




        private void BtnRevalidar_Click(object sender, EventArgs e)
        {
            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conexao = new SqlConnection(ServerConnection);  // instância de conexão 
            SqlCommand comando;

            string strSQL = $"UPDATE Usuarios SET DataConvite = @DataConvite where DataConvite <= Convert(datetime, @DataAnterior) and DataCadastro is null";
            comando = new SqlCommand(strSQL, conexao);

            
            comando.Parameters.AddWithValue("@DataConvite", DateTime.Now.Date);
            comando.Parameters.AddWithValue("@DataAnterior", DateTime.Now.AddDays(-30));

            conexao.Open();
            comando.ExecuteNonQuery();

            MessageBox.Show("Convites Atualizados");

            conexao.Close();
        }









        private void Status1_MouseHover(object sender, EventArgs e)
        {
            this.DiasCadastrado.Active = false;
            if (Status1.Text == "Cadastrado")
            {
                this.DiasCadastrado.Active = true;
                string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
                SqlConnection conexao = new SqlConnection(ServerConnection);  // instância de conexão 
                SqlCommand comando;

                comando = new SqlCommand($"Select DataCadastro from Usuarios where apelido = (@apelido) ", conexao);

                comando.Parameters.AddWithValue("@apelido", textBox1.Text);

                conexao.Open();
                SqlDataReader dataReader = comando.ExecuteReader();

                dataReader.Read();



                TimeSpan span = DateTime.Now.Subtract(DateTime.Parse(dataReader[0].ToString()));

                this.DiasCadastrado.SetToolTip(this.Status1, $"Dias desde o cadastro: {span.Days.ToString()}");
            }
           
        }

        private void Status2_MouseHover(object sender, EventArgs e)
        {
            this.DiasCadastrado.Active = false;
            if (Status2.Text == "Cadastrado")
            {
                this.DiasCadastrado.Active = true;
                string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
                SqlConnection conexao = new SqlConnection(ServerConnection);  // instância de conexão 
                SqlCommand comando;

                comando = new SqlCommand($"Select DataCadastro from Usuarios where apelido = (@apelido) ", conexao);

                comando.Parameters.AddWithValue("@apelido", textBox2.Text);
                conexao.Open();
                SqlDataReader dataReader = comando.ExecuteReader();

                dataReader.Read();



                TimeSpan span = DateTime.Now.Subtract(DateTime.Parse(dataReader[0].ToString()));

                this.DiasCadastrado.SetToolTip(this.Status2, $"Dias desde o cadastro: {span.Days.ToString()}");
            }
        }

        private void Status3_MouseHover(object sender, EventArgs e)
        {
            this.DiasCadastrado.Active = false;
            if (Status3.Text == "Cadastrado")
            {
                this.DiasCadastrado.Active = true;
                string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
                SqlConnection conexao = new SqlConnection(ServerConnection);  // instância de conexão 
                SqlCommand comando;

                comando = new SqlCommand($"Select DataCadastro from Usuarios where apelido = (@apelido) ", conexao);

                comando.Parameters.AddWithValue("@apelido", textBox3.Text);
                conexao.Open();
                SqlDataReader dataReader = comando.ExecuteReader();

                dataReader.Read();



                TimeSpan span = DateTime.Now.Subtract(DateTime.Parse(dataReader[0].ToString()));

                this.DiasCadastrado.SetToolTip(this.Status3, $"Dias desde o cadastro: {span.Days.ToString()}");
            }
        }

        private void Status4_MouseHover(object sender, EventArgs e)
        {
            this.DiasCadastrado.Active = false;
            if (Status4.Text == "Cadastrado")
            {
                this.DiasCadastrado.Active = true;
                string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
                SqlConnection conexao = new SqlConnection(ServerConnection);  // instância de conexão 
                SqlCommand comando;

                comando = new SqlCommand($"Select DataCadastro from Usuarios where apelido = (@apelido) ", conexao);

                comando.Parameters.AddWithValue("@apelido", textBox4.Text);
                conexao.Open();
                SqlDataReader dataReader = comando.ExecuteReader();

                dataReader.Read();



                TimeSpan span = DateTime.Now.Subtract(DateTime.Parse(dataReader[0].ToString()));

                this.DiasCadastrado.SetToolTip(this.Status4, $"Dias desde o cadastro: {span.Days.ToString()}");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Convidar convidar = new Convidar();
            convidar.Show();
        }
    }
}
