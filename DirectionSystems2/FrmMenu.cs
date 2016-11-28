using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Properties;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using System.Threading;
namespace DirectionSystems2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            new Thread(NovaThread).Start();
            NovaThread();

            new Thread(NovaThread2).Start();
            NovaThread2();

            new Thread(NovaThread3).Start();
            NovaThread3();

            LblTitulo.Text = ClassUtilidades.VersaoSistema;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spNotificacao", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                if (data.Rows.Count == 0)
                {
                    pictureBox2.Visible = false;
                }
                else if (data.Rows.Count == 1)
                {
                    pictureBox2.Image = Resources._01;
                }
                else if (data.Rows.Count == 2)
                {
                    pictureBox2.Image = Resources._02;
                }
                else if (data.Rows.Count == 3)
                {
                    pictureBox2.Image = Resources._03;
                }
                else if (data.Rows.Count == 4)
                {
                    pictureBox2.Image = Resources._04;
                }
                else if (data.Rows.Count == 5)
                {
                    pictureBox2.Image = Resources._051;
                }
                else if (data.Rows.Count > 5)
                {
                    pictureBox2.Image = Resources._052;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.FechaConexao(conn);
            }
        }

    private void NovaThread()
    {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spSugestaoProducao", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.FechaConexao(conn);
            }
        }

        private void NovaThread2()
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spSugestaoExameFuncionario", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.FechaConexao(conn);
            }
        }

        private void NovaThread3()
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spSugestaoCompra", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.FechaConexao(conn);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_LBUTTONDOWN)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnFexar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmEncomenda Encomenda = new FrmEncomenda();
            Encomenda.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlDataReader reader;
        ClassConexao Conexao = new ClassConexao();
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
           // if (Permissao("Cadastros"))
           // {
                this.Visible = false;
                FrmSelecaoClienteFornecedor ClienteFornecedor = new FrmSelecaoClienteFornecedor();
                ClienteFornecedor.Visible = true;
           // }
           // else
            //{
            //    MessageBox.Show("Usuário sem permissão!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           // }
        }

        private bool Permissao(string Pagina)
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spPermissao", conn);
            cmd.Parameters.AddWithValue("@CodUsuario", ClassUtilidades.CodUsuario);
            cmd.Parameters.AddWithValue("@Pagina", "Cadastros");
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            reader = cmd.ExecuteReader();
            string a = reader[0].ToString();
            return reader[0].ToString() == "0" ? false : true;
            Conexao.FechaConexao(conn);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
          //  if (Permissao("Configuracoes"))
           // {
                this.Visible = false;
                FrmImportacao Importacao = new FrmImportacao();
                Importacao.Visible = true;
           // }
          //  else
           // {
           //     MessageBox.Show("Usuário sem permissão!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           // }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
          //  if (Permissao("Relatorios"))
           // {
                this.Visible = false;
                FrmRelatorioVendaItem Relatorios = new FrmRelatorioVendaItem();
                Relatorios.Visible = true;
          //  }
           /// else
          ///  {
          //      MessageBox.Show("Usuário sem permissão!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          //  }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmInventario Inventario = new FrmInventario();
            Inventario.Visible = true;
        }

        private void BtnNotificacoes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmNotificacao Notificacao = new FrmNotificacao();
            Notificacao.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmProducao Producao = new FrmProducao();
            Producao.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmNotificacao Notificacao = new FrmNotificacao();
            Notificacao.Visible = true;
        }
    }
}
