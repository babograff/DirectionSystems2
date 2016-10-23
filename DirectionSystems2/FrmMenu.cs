using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using System.Drawing;
namespace DirectionSystems2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
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
                this.Close();
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
    }
}
