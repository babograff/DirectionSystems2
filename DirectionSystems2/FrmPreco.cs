using DirectionSystems2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectionSystems2
{
    public partial class FrmPreco : Form
    {
        public FrmPreco(int Codigo, string nome)
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
            TxtNome.Text = Codigo + " - " + nome;

            if (Outros == null)
            {
                Outros = new DataTable();
                Outros.Columns.Add("CodigoOutros", typeof(string));
                Outros.Columns.Add("Nome", typeof(string));
                Outros.Columns.Add("Subtotal", typeof(string));
            }

            Outros.Rows.Add("1","Água", "0");
            Outros.Rows.Add("2", "Gás", "0");
            Outros.Rows.Add("3", "Energia elétrica", "0");
            Outros.Rows.Add("4", "Depreciação equipamento", "0");
            Outros.Rows.Add("5", "Embalagem", "0");
            Outros.Rows.Add("6", "Funcionários", "0");
            Outros.Rows.Add("7", "Outros", "0");
            GridOutros.DataSource = Outros;
            Somatoria();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmSelecaoPreco Producao = new FrmSelecaoPreco();
            Producao.Visible = true;
            this.Close();
        }

        private void FrmPreco_Load(object sender, EventArgs e)
        {

        }
        private Double TotalProduto;
        private Double TotalOutros;
        private DataTable Produtos;
        private DataTable Outros;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSelecaoPrecoProduto Insumo = new FrmSelecaoPrecoProduto();
            Insumo.ShowDialog();

            if (Produtos == null)
            {
                Produtos = new DataTable();
                Produtos.Columns.Add("Codigo", typeof(string));
                Produtos.Columns.Add("CodigoImportado", typeof(string));
                Produtos.Columns.Add("Nome", typeof(string));
                Produtos.Columns.Add("Quantidade", typeof(string));
                Produtos.Columns.Add("Unidade", typeof(string));
                Produtos.Columns.Add("Subtotal", typeof(string));
            }

            Produtos.Rows.Add(Insumo.CodProdutoPreco, Insumo.CodigoProdImportadoPreco, Insumo.NomePreco, Insumo.QuantidadePreco, Insumo.MedidaPreco, Convert.ToDouble(Insumo.ValorPreco) * Convert.ToDouble(Insumo.QuantidadePreco));

            Somatoria();

            GridProduto.DataSource = Produtos;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmSelecaoPreco Preco = new FrmSelecaoPreco();
                Preco.Show();
                this.Close();
            }
        }

        private void GridOutros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridOutros.Columns["ExcluirOutros"].Index)
            {
                foreach (DataRow row in Outros.Rows)
                {
                    if (row["CodigoOutros"].ToString() == Convert.ToString(GridOutros["CodigoOutros", e.RowIndex].Value))
                    {
                        row.Delete();
                        break;
                    }
                }
                GridOutros.DataSource = null;
                GridOutros.DataSource = Outros;

                Somatoria();
            }
        }

        private void Somatoria()
        {
            TotalProduto = 0;
            TotalOutros = 0;
            if (Produtos != null)
            foreach (DataRow row in Produtos.Rows)
            {
                TotalProduto = TotalProduto + Convert.ToDouble(row["Subtotal"].ToString());
            }

            if (Outros != null)
            foreach (DataRow row in Outros.Rows)
            {
                TotalOutros = TotalOutros + Convert.ToDouble(row["Subtotal"].ToString());
            }

            LblSubtotal.Text = string.Format("{0:C}", TotalProduto + TotalOutros);
            LblTotal.Text = string.Format("{0:C}", TotalProduto + TotalOutros);
        }

        private void GridProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridProduto.Columns["Excluir"].Index)
            {
                foreach (DataRow row in Produtos.Rows)
                {
                    if (row["Codigo"].ToString() == Convert.ToString(GridProduto["Codigo", e.RowIndex].Value))
                    {
                        row.Delete();
                        break;
                    }
                }
                GridProduto.DataSource = null;
                GridProduto.DataSource = Produtos;

                Somatoria();
            }
            else if (e.ColumnIndex == GridProduto.Columns["Editar"].Index)
            {
                FrmPrecoEditarInsumo Insumo = new FrmPrecoEditarInsumo();
                Insumo.ShowDialog();
            }
        }
    }
}