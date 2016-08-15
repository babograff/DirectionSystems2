using System.Windows.Forms;
using DirectionSystems2.Classes;

namespace DirectionSystems2.Componentes
{
    public partial class Rodape : UserControl
    {
        public Rodape()
        {
            InitializeComponent();
            LblCodUsuario.Text = ClassUtilidades.CodUsuario;
            LblNomeUsuario.Text = ClassUtilidades.NomeUsuario;
        }

        private void Rodape_Load(object sender, System.EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
