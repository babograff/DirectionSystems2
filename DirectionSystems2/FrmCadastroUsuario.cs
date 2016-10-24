using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using System.Drawing;

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
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TxtNome.Text = reader[1].ToString();
                        TxtSobrenome.Text = reader[2].ToString();
                        CboStatus.SelectedIndex = CboStatus.Items.IndexOf(reader[3].ToString());
                        TxtUsuario.Text = reader[4].ToString();
                        TxtAuxiliar.Text = reader[5].ToString();
                        checkBox1.Checked = Convert.ToBoolean(reader[6]);
                        checkBox2.Checked = Convert.ToBoolean(reader[7]);
                        checkBox3.Checked = Convert.ToBoolean(reader[8]);
                        checkBox4.Checked = Convert.ToBoolean(reader[9]);
                        checkBox7.Checked = Convert.ToBoolean(reader[10]);
                        checkBox5.Checked = Convert.ToBoolean(reader[11]);
                        checkBox6.Checked = Convert.ToBoolean(reader[12]);
                        
                        TxtNome.Enabled = false;
                        TxtSobrenome.Enabled = false;
                        TxtNome.BackColor = Color.FromName("ScrollBar");
                        TxtSobrenome.BackColor = Color.FromName("ScrollBar");
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
                Server myServer = conexao.GetServer();
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
                cmd.Parameters.AddWithValue("@Sobrenome", TxtSobrenome.Text);
                cmd.Parameters.AddWithValue("@Status", CboStatus.SelectedIndex);
                cmd.Parameters.AddWithValue("@ID", ClassUtilidades.CodUsuario);
                cmd.Parameters.AddWithValue("@Encomendas", checkBox1.Checked);
                cmd.Parameters.AddWithValue("@Configuracoes", checkBox2.Checked);
                cmd.Parameters.AddWithValue("@Producao", checkBox3.Checked);
                cmd.Parameters.AddWithValue("@Cadastros", checkBox4.Checked);
                cmd.Parameters.AddWithValue("@CadastroUsuario", checkBox7.Checked);
                cmd.Parameters.AddWithValue("@Estoque", checkBox5.Checked);
                cmd.Parameters.AddWithValue("@Relatorios", checkBox6.Checked);

                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    conn.Open();
                    if (TxtCodigo.Text != "Novo")
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Database db = myServer.Databases["BomGosto"];

                            User user1 = db.Users[TxtUsuario.Text];
                            user1.Drop();

                            Login Login1 = myServer.Logins[TxtUsuario.Text];
                            Login1.Drop();

                            Login login = new Login(myServer, TxtUsuario.Text);
                            login.LoginType = LoginType.SqlLogin;
                            login.Create(TxtSenha.Text);
                            login.AddToRole("sysadmin");

                            User user = new User(db, TxtUsuario.Text);
                            user.Login = TxtUsuario.Text;
                            user.Create();
                        }
                        else
                            MessageBox.Show("Registro não encontrado para atualização", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            TxtCodigo.Text = reader[0].ToString();
                            MessageBox.Show("Registro incuído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Login login = new Login(myServer, TxtUsuario.Text);
                            login.LoginType = LoginType.SqlLogin;
                            login.Create(TxtSenha.Text);
                            login.AddToRole("sysadmin");

                            Database db = myServer.Databases["BomGosto"];
                            User user = new User(db, TxtUsuario.Text);
                            user.Login = TxtUsuario.Text;
                            user.Create();

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
                MessageBox.Show("Campo SOBRENOME vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ChbSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
        }

        ClassConexao conexao = new ClassConexao();

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TxtUsuario.Text = TxtNome.Text + "." + TxtSobrenome.Text;
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            TxtUsuario.Text = TxtNome.Text + "." + TxtSobrenome.Text;
        }
    }
}