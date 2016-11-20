using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;

namespace DirectionSystems2
{
    public partial class FrmSelecaoFuncionario : Form
    {
        ClassConexao Conexao = new ClassConexao();
        public FrmSelecaoFuncionario()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSelecaoFuncionario_Load(object sender, EventArgs e)
        {

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
                Application.Exit();
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario CadastroFuncionario = new FrmCadastroFuncionario(0);
            CadastroFuncionario.Visible = true;
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spFuncionarioGrid", conn);
            cmd.Parameters.AddWithValue("@Nome", txtNomeFuncionario.Text);
            cmd.Parameters.AddWithValue("@Status", CboStatus.SelectedIndex);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                GridFuncionario.DataSource = data;
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

        private void GridFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridFuncionario.Columns["Editar"].Index)
            {
                FrmCadastroFuncionario CadastroFuncionario = new FrmCadastroFuncionario(Convert.ToInt32(GridFuncionario["CodFuncionario", e.RowIndex].Value));
                CadastroFuncionario.Show();
                this.Visible = false;
            }
            else if (e.ColumnIndex == GridFuncionario.Columns["Excluir"].Index)
            {
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = Conexao.AbreConexao();
                    SqlCommand cmd = new SqlCommand("spUsuarioDelete", conn);
                    cmd.Parameters.AddWithValue("@CodFuncionario", GridFuncionario["CodFuncionario", e.RowIndex].Value.ToString());
                    cmd.Parameters.AddWithValue("@ID", ClassUtilidades.CodUsuario);
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
