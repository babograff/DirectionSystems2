using System;
using System.Windows.Forms;
using DirectionSystems2.Properties;

namespace DirectionSystems2.Componentes
{
    public partial class MenuCadastro : UserControl
    {
        public MenuCadastro()
        {
            InitializeComponent();
        }

        string NomeFormulario;
        public void Formulario(string nome)
        {
            NomeFormulario = nome;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSelecaoClienteFornecedor ClienteFornecedor = new FrmSelecaoClienteFornecedor();
            ClienteFornecedor.Visible = true;
            FechaFormulario();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.MenuClienteFornecedorAtivo;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.MenuClienteFornecedor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            FechaFormulario();
        }

        private void FechaFormulario()
        {
            if (NomeFormulario == "SelecaoClienteFornecedor")
            {
                FrmSelecaoClienteFornecedor SelecaoClienteFornecedor = new FrmSelecaoClienteFornecedor();
                SelecaoClienteFornecedor.Close();
            }
        }
    }
}
