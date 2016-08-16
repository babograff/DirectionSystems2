using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Properties;
using DirectionSystems2.Classes;

namespace DirectionSystems2
{
    public partial class FrmSelecaoClienteFornecedor : Form
    {
        public FrmSelecaoClienteFornecedor()
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

        private void BtnAjuda_Click(object sender, EventArgs e)
        {

        }
    }
}
