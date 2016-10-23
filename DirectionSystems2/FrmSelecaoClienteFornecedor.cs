using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Properties;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DirectionSystems2
{
    public partial class FrmSelecaoClienteFornecedor : Form
    {
        ClassConexao Conexao = new ClassConexao();
        public FrmSelecaoClienteFornecedor()
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
            CboStatus.SelectedIndex = 1;
            CboTipo.SelectedIndex = 0;
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

        private void FrmSelecaoClienteFornecedor_Load(object sender, EventArgs e)
        {
            GridClienteFornecedor.AutoGenerateColumns = false;
            Pesquisar();
        }

        private void BtnClienteFornecedor_Click(object sender, EventArgs e)
        {
            FrmSelecaoClienteFornecedor ClienteFornecedor = new FrmSelecaoClienteFornecedor();
            ClienteFornecedor.Visible = true;
            this.Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        private void BtnFexar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClienteFornecedor_MouseHover(object sender, EventArgs e)
        {
            BtnClienteFornecedor.Image = Resources.MenuClienteFornecedorAtivo;
        }

        private void BtnClienteFornecedor_MouseLeave(object sender, EventArgs e)
        {
            BtnClienteFornecedor.Image = Resources.MenuClienteFornecedor;
        }

        private void BtnMenu_MouseHover(object sender, EventArgs e)
        {
            BtnMenu.Image = Resources.BotaoHomeAtivo;
        }

        private void BtnMenu_MouseLeave(object sender, EventArgs e)
        {
            BtnMenu.Image = Resources.BotaoHome;
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmSelecaoProduto Produto = new FrmSelecaoProduto();
            Produto.Visible = true;
            this.Close();
        }

        private void BtnProduto_MouseHover(object sender, EventArgs e)
        {
            BtnProduto.Image = Resources.MenuProdutoAtivo;
        }

        private void BtnProduto_MouseLeave(object sender, EventArgs e)
        {
            BtnProduto.Image = Resources.MenuProduto;
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            FrmSelecaoFuncionario Funcionario = new FrmSelecaoFuncionario();
            Funcionario.Visible = true;
            this.Close();
        }

        private void BtnFuncionario_MouseHover(object sender, EventArgs e)
        {
            BtnFuncionario.Image = Resources.MenuFuncionarioAtivo;
        }

        private void BtnFuncionario_MouseLeave(object sender, EventArgs e)
        {
            BtnFuncionario.Image = Resources.MenuFuncionario;
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmSelecaoUsuario Usuario = new FrmSelecaoUsuario();
            Usuario.Visible = true;
            this.Close();
        }

        private void BtnUsuario_MouseHover(object sender, EventArgs e)
        {
            BtnUsuario.Image = Resources.MenuUsuarioAtivo;
        }

        private void BtnUsuario_MouseLeave(object sender, EventArgs e)
        {
            BtnUsuario.Image = Resources.MenuUsuario;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroClienteFornecedor CadastroClienteFornecedor = new FrmCadastroClienteFornecedor(0);
            CadastroClienteFornecedor.Visible = true;
            this.Close();
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        public static string MascaraCnpjCpf(string pCnpjCpf)
        {
            string result = "";
            if (pCnpjCpf.Length == 14)
            {
                result = pCnpjCpf.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
            }
            if (pCnpjCpf.Length == 11)
            {
                result = pCnpjCpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            }
            if ((pCnpjCpf.Length != 11) && (pCnpjCpf.Length != 14))
            {
                result = pCnpjCpf;
            }
            return result;
        }

        private void Pesquisar()
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spClienteFornecedorGrid", conn);
            cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
            cmd.Parameters.AddWithValue("@CPFCNPJ", TxtCPFCNPJ.Text);
            cmd.Parameters.AddWithValue("@Tipo", CboTipo.SelectedIndex);
            cmd.Parameters.AddWithValue("@Status", CboStatus.SelectedIndex);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                GridClienteFornecedor.DataSource = data;
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

        private void GridClienteFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridClienteFornecedor.Columns["Editar"].Index)
            {
                FrmCadastroClienteFornecedor CadastroClienteFornecedor = new FrmCadastroClienteFornecedor(Convert.ToInt32(GridClienteFornecedor["CodClienteFornecedor", e.RowIndex].Value));
                CadastroClienteFornecedor.Show();
                this.Visible = false;
            }
            else if (e.ColumnIndex == GridClienteFornecedor.Columns["Excluir"].Index)
            {
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = Conexao.AbreConexao();
                    SqlCommand cmd = new SqlCommand("spClienteFornecedorDelete", conn);
                    cmd.Parameters.AddWithValue("@CodClienteFornecedor", GridClienteFornecedor["CodClienteFornecedor", e.RowIndex].Value.ToString());
                    cmd.Parameters.AddWithValue("@ID", ClassUtilidades.CodUsuario);
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        conn.Open();
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

        private void TxtCPFCNPJ_Leave(object sender, EventArgs e)
        {
            TxtCPFCNPJ.Text = MascaraCnpjCpf(TxtCPFCNPJ.Text);
        }

        private void TxtCPFCNPJ_Enter(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9a-zA-Z]+");
            TxtCPFCNPJ.Text = rgx.Replace(TxtCPFCNPJ.Text, "");
        }

        private void TxtCPFCNPJ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
