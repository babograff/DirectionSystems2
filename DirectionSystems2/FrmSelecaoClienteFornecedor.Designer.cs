namespace DirectionSystems2
{
    partial class FrmSelecaoClienteFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecaoClienteFornecedor));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.BtnAjuda = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnFexar = new System.Windows.Forms.PictureBox();
            this.BtnUsuario = new System.Windows.Forms.PictureBox();
            this.BtnFuncionario = new System.Windows.Forms.PictureBox();
            this.BtnProduto = new System.Windows.Forms.PictureBox();
            this.BtnClienteFornecedor = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelecionar = new System.Windows.Forms.PictureBox();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.GridClienteFornecedor = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.CodClienteFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.rodape1 = new DirectionSystems2.Componentes.Rodape();
            this.BtnCadastrar = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClienteFornecedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSelecionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridClienteFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCadastrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BtnMenu);
            this.panel2.Controls.Add(this.BtnAjuda);
            this.panel2.Controls.Add(this.BtnMaximizar);
            this.panel2.Controls.Add(this.BtnFexar);
            this.panel2.Controls.Add(this.BtnUsuario);
            this.panel2.Controls.Add(this.BtnFuncionario);
            this.panel2.Controls.Add(this.BtnProduto);
            this.panel2.Controls.Add(this.BtnClienteFornecedor);
            this.panel2.Controls.Add(this.LblTitulo);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 118);
            this.panel2.TabIndex = 18;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenu.BackgroundImage")));
            this.BtnMenu.Image = global::DirectionSystems2.Properties.Resources.BotaoHome;
            this.BtnMenu.Location = new System.Drawing.Point(45, 74);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(32, 32);
            this.BtnMenu.TabIndex = 27;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            this.BtnMenu.MouseLeave += new System.EventHandler(this.BtnMenu_MouseLeave);
            this.BtnMenu.MouseHover += new System.EventHandler(this.BtnMenu_MouseHover);
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAjuda.BackgroundImage")));
            this.BtnAjuda.Location = new System.Drawing.Point(828, 12);
            this.BtnAjuda.Name = "BtnAjuda";
            this.BtnAjuda.Size = new System.Drawing.Size(16, 16);
            this.BtnAjuda.TabIndex = 26;
            this.BtnAjuda.TabStop = false;
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.BackgroundImage")));
            this.BtnMaximizar.Location = new System.Drawing.Point(850, 12);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.BtnMaximizar.TabIndex = 25;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnFexar
            // 
            this.BtnFexar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFexar.BackgroundImage")));
            this.BtnFexar.Location = new System.Drawing.Point(872, 12);
            this.BtnFexar.Name = "BtnFexar";
            this.BtnFexar.Size = new System.Drawing.Size(16, 16);
            this.BtnFexar.TabIndex = 24;
            this.BtnFexar.TabStop = false;
            this.BtnFexar.Click += new System.EventHandler(this.BtnFexar_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.BackgroundImage = global::DirectionSystems2.Properties.Resources.MenuProduto;
            this.BtnUsuario.Image = global::DirectionSystems2.Properties.Resources.MenuUsuario;
            this.BtnUsuario.Location = new System.Drawing.Point(568, 47);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(53, 64);
            this.BtnUsuario.TabIndex = 19;
            this.BtnUsuario.TabStop = false;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            this.BtnUsuario.MouseLeave += new System.EventHandler(this.BtnUsuario_MouseLeave);
            this.BtnUsuario.MouseHover += new System.EventHandler(this.BtnUsuario_MouseHover);
            // 
            // BtnFuncionario
            // 
            this.BtnFuncionario.BackgroundImage = global::DirectionSystems2.Properties.Resources.MenuProduto;
            this.BtnFuncionario.Image = global::DirectionSystems2.Properties.Resources.MenuFuncionario;
            this.BtnFuncionario.Location = new System.Drawing.Point(482, 47);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.Size = new System.Drawing.Size(80, 64);
            this.BtnFuncionario.TabIndex = 18;
            this.BtnFuncionario.TabStop = false;
            this.BtnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            this.BtnFuncionario.MouseLeave += new System.EventHandler(this.BtnFuncionario_MouseLeave);
            this.BtnFuncionario.MouseHover += new System.EventHandler(this.BtnFuncionario_MouseHover);
            // 
            // BtnProduto
            // 
            this.BtnProduto.BackgroundImage = global::DirectionSystems2.Properties.Resources.MenuProduto;
            this.BtnProduto.Image = global::DirectionSystems2.Properties.Resources.MenuProduto;
            this.BtnProduto.Location = new System.Drawing.Point(422, 47);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Size = new System.Drawing.Size(54, 64);
            this.BtnProduto.TabIndex = 17;
            this.BtnProduto.TabStop = false;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            this.BtnProduto.MouseLeave += new System.EventHandler(this.BtnProduto_MouseLeave);
            this.BtnProduto.MouseHover += new System.EventHandler(this.BtnProduto_MouseHover);
            // 
            // BtnClienteFornecedor
            // 
            this.BtnClienteFornecedor.BackgroundImage = global::DirectionSystems2.Properties.Resources.MenuClienteFornecedor;
            this.BtnClienteFornecedor.Image = global::DirectionSystems2.Properties.Resources.MenuClienteFornecedor;
            this.BtnClienteFornecedor.Location = new System.Drawing.Point(278, 47);
            this.BtnClienteFornecedor.Name = "BtnClienteFornecedor";
            this.BtnClienteFornecedor.Size = new System.Drawing.Size(138, 64);
            this.BtnClienteFornecedor.TabIndex = 16;
            this.BtnClienteFornecedor.TabStop = false;
            this.BtnClienteFornecedor.Click += new System.EventHandler(this.BtnClienteFornecedor_Click);
            this.BtnClienteFornecedor.MouseLeave += new System.EventHandler(this.BtnClienteFornecedor_MouseLeave);
            this.BtnClienteFornecedor.MouseHover += new System.EventHandler(this.BtnClienteFornecedor_MouseHover);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(333, 10);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(263, 25);
            this.LblTitulo.TabIndex = 15;
            this.LblTitulo.Text = "DirectionSystems - versão";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtCPFCNPJ);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnSelecionar);
            this.groupBox1.Controls.Add(this.CboStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Location = new System.Drawing.Point(45, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 66);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "CPF / CNPJ";
            // 
            // TxtCPFCNPJ
            // 
            this.TxtCPFCNPJ.Location = new System.Drawing.Point(9, 36);
            this.TxtCPFCNPJ.Name = "TxtCPFCNPJ";
            this.TxtCPFCNPJ.Size = new System.Drawing.Size(139, 20);
            this.TxtCPFCNPJ.TabIndex = 27;
            this.TxtCPFCNPJ.TextChanged += new System.EventHandler(this.TxtCPFCNPJ_TextChanged);
            this.TxtCPFCNPJ.Enter += new System.EventHandler(this.TxtCPFCNPJ_Enter);
            this.TxtCPFCNPJ.Leave += new System.EventHandler(this.TxtCPFCNPJ_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Status";
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelecionar.Image")));
            this.BtnSelecionar.Location = new System.Drawing.Point(695, 27);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(120, 30);
            this.BtnSelecionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnSelecionar.TabIndex = 20;
            this.BtnSelecionar.TabStop = false;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // CboStatus
            // 
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Items.AddRange(new object[] {
            "Inativo",
            "Ativo"});
            this.CboStatus.Location = new System.Drawing.Point(568, 36);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(121, 21);
            this.CboStatus.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // CboTipo
            // 
            this.CboTipo.FormattingEnabled = true;
            this.CboTipo.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor"});
            this.CboTipo.Location = new System.Drawing.Point(441, 36);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Size = new System.Drawing.Size(121, 21);
            this.CboTipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(154, 36);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(281, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // GridClienteFornecedor
            // 
            this.GridClienteFornecedor.AllowUserToAddRows = false;
            this.GridClienteFornecedor.AllowUserToDeleteRows = false;
            this.GridClienteFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClienteFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Excluir,
            this.CodClienteFornecedor,
            this.CPFCNPJ,
            this.Nome,
            this.Tipo,
            this.Status});
            this.GridClienteFornecedor.Location = new System.Drawing.Point(45, 239);
            this.GridClienteFornecedor.Name = "GridClienteFornecedor";
            this.GridClienteFornecedor.ReadOnly = true;
            this.GridClienteFornecedor.Size = new System.Drawing.Size(821, 421);
            this.GridClienteFornecedor.TabIndex = 25;
            this.GridClienteFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridClienteFornecedor_CellClick);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::DirectionSystems2.Properties.Resources.Editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Excluir
            // 
            this.Excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Image = global::DirectionSystems2.Properties.Resources.Excluir;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            // 
            // CodClienteFornecedor
            // 
            this.CodClienteFornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodClienteFornecedor.DataPropertyName = "CodClienteFornecedor";
            this.CodClienteFornecedor.HeaderText = "Código";
            this.CodClienteFornecedor.Name = "CodClienteFornecedor";
            this.CodClienteFornecedor.ReadOnly = true;
            this.CodClienteFornecedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodClienteFornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPFCNPJ.DataPropertyName = "CPFCNPJ";
            this.CPFCNPJ.HeaderText = "CPF / CNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            this.CPFCNPJ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CPFCNPJ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::DirectionSystems2.Properties.Resources.Editar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.HeaderText = "Excluir";
            this.dataGridViewImageColumn2.Image = global::DirectionSystems2.Properties.Resources.Excluir;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // rodape1
            // 
            this.rodape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rodape1.Location = new System.Drawing.Point(-2, 678);
            this.rodape1.Name = "rodape1";
            this.rodape1.Size = new System.Drawing.Size(900, 22);
            this.rodape1.TabIndex = 1;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastrar.Image")));
            this.BtnCadastrar.Location = new System.Drawing.Point(45, 131);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(120, 30);
            this.BtnCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCadastrar.TabIndex = 26;
            this.BtnCadastrar.TabStop = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // FrmSelecaoClienteFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.GridClienteFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rodape1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSelecaoClienteFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelecaoClienteFornecedor";
            this.Load += new System.EventHandler(this.FrmSelecaoClienteFornecedor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClienteFornecedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSelecionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridClienteFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCadastrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Componentes.Rodape rodape1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.PictureBox BtnAjuda;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnFexar;
        private System.Windows.Forms.PictureBox BtnUsuario;
        private System.Windows.Forms.PictureBox BtnFuncionario;
        private System.Windows.Forms.PictureBox BtnProduto;
        private System.Windows.Forms.PictureBox BtnClienteFornecedor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCPFCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnSelecionar;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DataGridView GridClienteFornecedor;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox BtnCadastrar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodClienteFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}