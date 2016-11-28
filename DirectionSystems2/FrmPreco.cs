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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSelecaoPrecoProduto Insumo = new FrmSelecaoPrecoProduto();
            Insumo.ShowDialog();
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
    }
}
