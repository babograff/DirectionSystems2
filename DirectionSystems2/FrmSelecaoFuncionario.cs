﻿using DirectionSystems2.Classes;
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
    public partial class FrmSelecaoFuncionario : Form
    {
        public FrmSelecaoFuncionario()
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
        }

        private void FrmSelecaoFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
