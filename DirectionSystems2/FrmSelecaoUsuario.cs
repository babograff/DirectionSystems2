using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;

namespace DirectionSystems2
{
    public partial class FrmSelecaoUsuario : Form
    {
        ClassConexao Conexao = new ClassConexao();
        public FrmSelecaoUsuario()
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
            CboStatus.SelectedIndex = 1;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        private void FrmSelecaoUsuario_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spUsuarioGrid", conn);
            cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
            cmd.Parameters.AddWithValue("@Status", CboStatus.SelectedIndex);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                GridUsuario.DataSource = data;
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

        ClassConexao conexao = new ClassConexao();
        private void GridUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridUsuario.Columns["Editar"].Index)
            {
                FrmCadastroUsuario CadastroUsuario = new FrmCadastroUsuario(Convert.ToInt32(GridUsuario["CodUsuario", e.RowIndex].Value));
                CadastroUsuario.Show();
                this.Visible = false;
            }
            else if (e.ColumnIndex == GridUsuario.Columns["Excluir"].Index)
            {
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = Conexao.AbreConexao();
                    SqlCommand cmd = new SqlCommand("spUsuarioDelete", conn);
                    cmd.Parameters.AddWithValue("@CodUsuario", GridUsuario["CodUsuario", e.RowIndex].Value.ToString());
                    cmd.Parameters.AddWithValue("@ID", ClassUtilidades.CodUsuario);
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Registro excluído com sucesso!");

                            Server myServer = conexao.GetServer();
                            Database db = myServer.Databases["BomGosto"];

                            User user1 = db.Users[GridUsuario["Usuário", e.RowIndex].Value.ToString()];
                            user1.Drop();

                            Login Login1 = myServer.Logins[GridUsuario["Usuário", e.RowIndex].Value.ToString()];
                            Login1.Drop();

                            Pesquisar();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir registro!");
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
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario CadastroUsuario = new FrmCadastroUsuario(0);
            CadastroUsuario.Show();
            this.Visible = false;
        }
    }
}