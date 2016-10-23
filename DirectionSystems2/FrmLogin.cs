using DirectionSystems2.Properties;
using System;
using System.Data;
using System.Windows.Forms;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DirectionSystems2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        ClassConexao Conexao = new ClassConexao();
        ClassCriptoTexto CriptoTexto = new ClassCriptoTexto();
        SqlDataReader reader;

        private void Logar()
        {
            ClassUtilidades.User = CriptoTexto.Encrypt(TxtUsuario.Text);
            ClassUtilidades.Password = CriptoTexto.Encrypt(TxtSenha.Text);

            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spUsuario", conn);
            cmd.Parameters.AddWithValue("@Usuario", TxtUsuario.Text);
            cmd.Parameters.AddWithValue("@Senha", TxtSenha.Text);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ClassUtilidades.NomeUsuario = reader[1].ToString();
                    ClassUtilidades.CodUsuario = reader[0].ToString();
                    FrmLoginSucesso LoginSucesso = new FrmLoginSucesso();
                    LoginSucesso.Show();
                    this.Visible = false;
                }
                else {
                    this.Visible = false;
                    FrmLoginErro LoginErro = new FrmLoginErro();
                    LoginErro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                this.Visible = false;
                FrmLoginErro LoginErro = new FrmLoginErro();
                LoginErro.Visible = true;
            }
            finally
            {
                Conexao.FechaConexao(conn);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.BotaoLogarAtivo;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.BotaoLogar;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.BotaoCancelarLoginAtivo;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.BotaoCancelarLogin;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o seu login?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
