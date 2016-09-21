using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;

namespace DirectionSystems2
{
    public partial class FrmSelecaoProduto : Form
    {
        ClassConexao Conexao = new ClassConexao();
        public FrmSelecaoProduto()
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

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto CadastroProduto = new FrmCadastroProduto(0);
            CadastroProduto.Visible = true;
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(); 
        }

        private void Pesquisar()
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spProdutoGrid", conn);
            cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
            cmd.Parameters.AddWithValue("@CodBarras", txtCodBarras.Text);
            cmd.Parameters.AddWithValue("@Status", CboStatus.SelectedIndex);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                GridProduto.DataSource = data;
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

        private void GridProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridProduto.Columns["Editar"].Index)
            {
                FrmCadastroProduto CadastroProduto = new FrmCadastroProduto(Convert.ToInt32(GridProduto["CodProduto", e.RowIndex].Value));
                CadastroProduto.Show();
                this.Visible = false;
            }
            else if (e.ColumnIndex == GridProduto.Columns["Excluir"].Index)
            {
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = Conexao.AbreConexao();
                    SqlCommand cmd = new SqlCommand("spProdutoDelete", conn);
                    cmd.Parameters.AddWithValue("@CodProduto", GridProduto["CodProduto", e.RowIndex].Value.ToString());
                    cmd.Parameters.AddWithValue("@ID", ClassUtilidades.CodUsuario);
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Registro excluído com sucesso!");
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

        private void FrmSelecaoProduto_Load(object sender, EventArgs e)
        {
            GridProduto.AutoGenerateColumns = false;
            Pesquisar();
        }
    }
}
