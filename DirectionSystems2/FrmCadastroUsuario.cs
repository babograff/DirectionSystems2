using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;

namespace DirectionSystems2
{
    public partial class FrmCadastroUsuario : Form
    {
        ClassConexao Conexao = new ClassConexao();
        SqlDataReader reader;
        public FrmCadastroUsuario(int Codigo)
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
            TxtNome.Focus();
            if (Codigo == 0)
            {
                TxtCodigo.Text = "Novo";
                CboStatus.SelectedIndex = 1;
            }
            else
            {
                TxtCodigo.Text = Codigo.ToString();
                SqlConnection conn = Conexao.AbreConexao();
                SqlCommand cmd = new SqlCommand("spUsuarioSelecaoInterna", conn);
                cmd.Parameters.AddWithValue("@CodUsuario", Codigo);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TxtNome.Text = reader[1].ToString();
                        CboStatus.SelectedIndex = CboStatus.Items.IndexOf(reader[2].ToString());
                        TxtUsuario.Text = reader[3].ToString();
                        TxtSenha.Text = reader[4].ToString();
                    }
                    else {
                        MessageBox.Show("Usuário inexistente");
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
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        private void BtnClienteFornecedor_Click(object sender, EventArgs e)
        {
            FrmSelecaoClienteFornecedor ClienteFornecedor = new FrmSelecaoClienteFornecedor();
            ClienteFornecedor.Visible = true;
            this.Close();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmSelecaoProduto Produto = new FrmSelecaoProduto();
            Produto.Visible = true;
            this.Close();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            FrmSelecaoFuncionario Funcionario = new FrmSelecaoFuncionario();
            Funcionario.Visible = true;
            this.Close();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmSelecaoUsuario Usuario = new FrmSelecaoUsuario();
            Usuario.Visible = true;
            this.Close();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFexar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                string Codigo;
                if (TxtCodigo.Text == "Novo")
                {
                    Codigo = "0";
                }
                else
                {
                    Codigo = TxtCodigo.Text;
                }

                SqlConnection conn = Conexao.AbreConexao();
                SqlCommand cmd = new SqlCommand("spUsuarioNovo", conn);
                cmd.Parameters.AddWithValue("@CodUsuario", Codigo);
                cmd.Parameters.AddWithValue("@Usuario ", TxtUsuario.Text);
                cmd.Parameters.AddWithValue("@Senha", TxtSenha.Text);
                cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                cmd.Parameters.AddWithValue("@Status", CboStatus.SelectedIndex);
                cmd.Parameters.AddWithValue("@ID", ClassUtilidades.CodUsuario);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    if (TxtCodigo.Text != "Novo")
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Registro atualizado com sucesso!");
                        else
                            MessageBox.Show("Registro não encontrado para atualização");

                    }
                    else
                    {
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            TxtCodigo.Text = reader[0].ToString();
                            MessageBox.Show("Registro incuído com sucesso!");

                        }
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
        }

        private bool Valida()
        {
            if (TxtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo NOME vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }
            else if (TxtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Campo USUÁRIO vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsuario.Focus();
                return false;
            }
            else if (TxtSenha.Text == string.Empty)
            {
                MessageBox.Show("Campo SENHA vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSenha.Focus();
                return false;
            }
            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmSelecaoUsuario Usuario = new FrmSelecaoUsuario();
                Usuario.Show();
                this.Close();
            }
        }
    }
}