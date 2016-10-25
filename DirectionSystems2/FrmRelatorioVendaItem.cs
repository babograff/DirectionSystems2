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
    public partial class FrmRelatorioVendaItem : Form
    {
        public FrmRelatorioVendaItem()
        {
            InitializeComponent();
        }

        private void FrmRelatorioVendaItem_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }
    }
}
