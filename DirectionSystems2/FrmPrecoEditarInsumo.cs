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
    public partial class FrmPrecoEditarInsumo : Form
    {
        public FrmPrecoEditarInsumo(int Codigo)
        {
            InitializeComponent();
        }

        private void FrmPrecoEditarInsumo_Load(object sender, EventArgs e)
        {

        }

        public string CodProdutoPreco { get; set; }
        public string CodigoProdImportadoPreco { get; set; }
        public string NomePreco { get; set; }
        public string QuantidadePreco { get; set; }
        public string MedidaPreco { get; set; }

    }
}
