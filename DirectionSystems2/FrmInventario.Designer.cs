namespace DirectionSystems2
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.BtnAjuda = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnFexar = new System.Windows.Forms.PictureBox();
            this.BtnClienteFornecedor = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.GridInventario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CboTipoProduto = new System.Windows.Forms.ComboBox();
            this.BtnPesquisar = new System.Windows.Forms.PictureBox();
            this.rodape1 = new DirectionSystems2.Componentes.Rodape();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoImportado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClienteFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisar)).BeginInit();
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
            this.panel2.Controls.Add(this.BtnClienteFornecedor);
            this.panel2.Controls.Add(this.LblTitulo);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 118);
            this.panel2.TabIndex = 27;
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
            // BtnClienteFornecedor
            // 
            this.BtnClienteFornecedor.Image = global::DirectionSystems2.Properties.Resources.MenuInventário;
            this.BtnClienteFornecedor.Location = new System.Drawing.Point(416, 42);
            this.BtnClienteFornecedor.Name = "BtnClienteFornecedor";
            this.BtnClienteFornecedor.Size = new System.Drawing.Size(91, 64);
            this.BtnClienteFornecedor.TabIndex = 16;
            this.BtnClienteFornecedor.TabStop = false;
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
            // GridInventario
            // 
            this.GridInventario.AllowUserToAddRows = false;
            this.GridInventario.AllowUserToDeleteRows = false;
            this.GridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Codigo,
            this.CodigoImportado,
            this.Nome,
            this.Quantidade,
            this.Medida,
            this.DataAtualizacao});
            this.GridInventario.Location = new System.Drawing.Point(45, 198);
            this.GridInventario.Name = "GridInventario";
            this.GridInventario.ReadOnly = true;
            this.GridInventario.Size = new System.Drawing.Size(821, 474);
            this.GridInventario.TabIndex = 29;
            this.GridInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInventario_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CboTipoProduto);
            this.groupBox1.Controls.Add(this.BtnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(45, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 70);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tipo";
            // 
            // CboTipoProduto
            // 
            this.CboTipoProduto.FormattingEnabled = true;
            this.CboTipoProduto.Items.AddRange(new object[] {
            "Matéria prima (insumo)",
            "Produto acabado (Venda)"});
            this.CboTipoProduto.Location = new System.Drawing.Point(6, 34);
            this.CboTipoProduto.Name = "CboTipoProduto";
            this.CboTipoProduto.Size = new System.Drawing.Size(165, 21);
            this.CboTipoProduto.TabIndex = 25;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisar.Image")));
            this.BtnPesquisar.Location = new System.Drawing.Point(177, 25);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(120, 30);
            this.BtnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnPesquisar.TabIndex = 20;
            this.BtnPesquisar.TabStop = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // rodape1
            // 
            this.rodape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rodape1.Location = new System.Drawing.Point(-2, 678);
            this.rodape1.Name = "rodape1";
            this.rodape1.Size = new System.Drawing.Size(900, 22);
            this.rodape1.TabIndex = 28;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::DirectionSystems2.Properties.Resources.Editar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::DirectionSystems2.Properties.Resources.Editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.DataPropertyName = "CodProduto";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // CodigoImportado
            // 
            this.CodigoImportado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodigoImportado.DataPropertyName = "CodImportado";
            this.CodigoImportado.HeaderText = "Código Importado";
            this.CodigoImportado.Name = "CodigoImportado";
            this.CodigoImportado.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Medida
            // 
            this.Medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medida.DataPropertyName = "Medida";
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            // 
            // DataAtualizacao
            // 
            this.DataAtualizacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataAtualizacao.DataPropertyName = "Atualizacao";
            this.DataAtualizacao.HeaderText = "Atualização";
            this.DataAtualizacao.Name = "DataAtualizacao";
            this.DataAtualizacao.ReadOnly = true;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridInventario);
            this.Controls.Add(this.rodape1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClienteFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.PictureBox BtnAjuda;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnFexar;
        private System.Windows.Forms.PictureBox BtnClienteFornecedor;
        private System.Windows.Forms.Label LblTitulo;
        private Componentes.Rodape rodape1;
        private System.Windows.Forms.DataGridView GridInventario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox BtnPesquisar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboTipoProduto;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoImportado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtualizacao;
    }
}