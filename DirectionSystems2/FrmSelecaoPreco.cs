using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;

namespace DirectionSystems2
{
    public partial class FrmSelecaoPreco : Form
    {
        public FrmSelecaoPreco()
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
            Pesquisar();
        }


        private void FrmSelecaoPreco_Load(object sender, EventArgs e)
        {

        }

        ClassConexao Conexao = new ClassConexao();
        private void Pesquisar()
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spProdutoGrid", conn);
            cmd.Parameters.AddWithValue("@Nome", "");
            cmd.Parameters.AddWithValue("@CodBarras", "");
            cmd.Parameters.AddWithValue("@Status",1);
            cmd.Parameters.AddWithValue("@Tipo", 1);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
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

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        private void BtnClienteFornecedor_Click(object sender, EventArgs e)
        {
            FrmProducao Producao = new FrmProducao();
            Producao.Visible = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmSelecaoPreco Producao = new FrmSelecaoPreco();
            Producao.Visible = true;
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

        private void GridProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridProduto.Columns["Editar"].Index)
            {
                FrmPreco Preco = new FrmPreco(Convert.ToInt32(GridProduto["CodProduto", e.RowIndex].Value), Convert.ToString(GridProduto["Nome", e.RowIndex].Value));
                Preco.Show();
                this.Visible = false;
            }
        }
    }
}
