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
    public partial class FormJogos : Form
    {
        public FormJogos()
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
                    img_Perf.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Usuário sem foto de perfil | {0}", ex);
                img_Perf.Image = Image.FromFile(@"S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\1 - Alunos\Allan Kley\Desafio c# 15.03\DataFiles\Icones\SemFoto.png");
            }
        }

        private void FormJogos_Load(object sender, EventArgs e)
        {
            string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
            SqlConnection conn = new SqlConnection(ServerConnection);  // instancia de conexão 
      
            SqlDataAdapter sqlDa = new SqlDataAdapter("select Data, S1.Nome as Selecao1, Placar1, Placar2, S2.Nome as selecao2, Competicao.Local from Jogos INNER JOIN Competicao on Jogos.idCompeticao = Competicao.IdCompeticao INNER JOIN Selecao as S1 on Jogos.Selecao1 = S1.IdSelecao INNER JOIN Selecao as S2 on Jogos.Selecao2 = S2.IdSelecao", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            tb_Jogos.DataSource = dtbl;
            tb_Jogos.AutoGenerateColumns = false;
        }

        private void BtnConvidados_Click_1(object sender, EventArgs e)
        {
            MenuConvidados convidados = new MenuConvidados();
            convidados.Show();
            this.Hide();
        }

        private void img_Perf_Click(object sender, EventArgs e)
        {
            TelaPerfil perfil = new TelaPerfil();
            perfil.Show();
           
        }
    }
}
