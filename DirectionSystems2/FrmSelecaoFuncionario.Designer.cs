namespace DirectionSystems2
{
    partial class FrmSelecaoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecaoFuncionario));
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
            this.rodape1 = new DirectionSystems2.Componentes.Rodape();
            this.BtnCadastrar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.GridFuncionario = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.CodFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClienteFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCadastrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).BeginInit();
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
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // rodape1
            // 
            this.rodape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rodape1.Location = new System.Drawing.Point(-2, 678);
            this.rodape1.Name = "rodape1";
            this.rodape1.Size = new System.Drawing.Size(900, 22);
            this.rodape1.TabIndex = 22;
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
            this.BtnCadastrar.TabIndex = 44;
            this.BtnCadastrar.TabStop = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomeFuncionario);
            this.groupBox1.Controls.Add(this.BtnPesquisar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboStatus);
            this.groupBox1.Location = new System.Drawing.Point(45, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 66);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(9, 36);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(553, 20);
            this.txtNomeFuncionario.TabIndex = 21;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisar.Image")));
            this.BtnPesquisar.Location = new System.Drawing.Point(695, 26);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(120, 30);
            this.BtnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnPesquisar.TabIndex = 20;
            this.BtnPesquisar.TabStop = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // CboStatus
            // 
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Items.AddRange(new object[] {
            "Inativo",
            "Ativo"});
            this.CboStatus.Location = new System.Drawing.Point(568, 35);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(121, 21);
            this.CboStatus.TabIndex = 4;
            // 
            // GridFuncionario
            // 
            this.GridFuncionario.AllowUserToAddRows = false;
            this.GridFuncionario.AllowUserToDeleteRows = false;
            this.GridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Excluir,
            this.CodFuncionario,
            this.CPF,
            this.Nome,
            this.Status});
            this.GridFuncionario.Location = new System.Drawing.Point(45, 239);
            this.GridFuncionario.Name = "GridFuncionario";
            this.GridFuncionario.ReadOnly = true;
            this.GridFuncionario.Size = new System.Drawing.Size(821, 421);
            this.GridFuncionario.TabIndex = 46;
            this.GridFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFuncionario_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::DirectionSystems2.Properties.Resources.Editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Image = global::DirectionSystems2.Properties.Resources.Excluir;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            // 
            // CodFuncionario
            // 
            this.CodFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodFuncionario.DataPropertyName = "CodFuncionario";
            this.CodFuncionario.HeaderText = "Código";
            this.CodFuncionario.Name = "CodFuncionario";
            this.CodFuncionario.ReadOnly = true;
            this.CodFuncionario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodFuncionario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CPF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // FrmSelecaoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.GridFuncionario);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rodape1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSelecaoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelecaoFuncionario";
            this.Load += new System.EventHandler(this.FrmSelecaoFuncionario_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.BtnCadastrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Componentes.Rodape rodape1;
        private System.Windows.Forms.PictureBox BtnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.PictureBox BtnPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.DataGridView GridFuncionario;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}