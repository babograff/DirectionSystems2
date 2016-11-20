namespace DirectionSystems2
{
    partial class FrmCadastroEncomendaSelecaoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEncomendaSelecaoProduto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtImportado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.GridProduto = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.PictureBox();
            this.Selecionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoImportado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtImportado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.GridProduto);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 336);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados produto";
            // 
            // TxtImportado
            // 
            this.TxtImportado.BackColor = System.Drawing.Color.White;
            this.TxtImportado.Location = new System.Drawing.Point(147, 43);
            this.TxtImportado.Name = "TxtImportado";
            this.TxtImportado.Size = new System.Drawing.Size(135, 20);
            this.TxtImportado.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Código importado";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.Location = new System.Drawing.Point(6, 43);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(135, 20);
            this.TxtCodigo.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nome ";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.White;
            this.TxtNome.Location = new System.Drawing.Point(288, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(397, 20);
            this.TxtNome.TabIndex = 57;
            // 
            // GridProduto
            // 
            this.GridProduto.AllowUserToAddRows = false;
            this.GridProduto.AllowUserToDeleteRows = false;
            this.GridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Codigo,
            this.CodigoImportado,
            this.Nome,
            this.Valor,
            this.UnidadeMedida});
            this.GridProduto.Location = new System.Drawing.Point(6, 69);
            this.GridProduto.Name = "GridProduto";
            this.GridProduto.ReadOnly = true;
            this.GridProduto.Size = new System.Drawing.Size(809, 261);
            this.GridProduto.TabIndex = 48;
            this.GridProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProduto_CellClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(716, 353);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 30);
            this.BtnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCancelar.TabIndex = 55;
            this.BtnCancelar.TabStop = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Image = global::DirectionSystems2.Properties.Resources.Selecionar;
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
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
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // UnidadeMedida
            // 
            this.UnidadeMedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnidadeMedida.DataPropertyName = "Medida";
            this.UnidadeMedida.HeaderText = "Unidade Medida";
            this.UnidadeMedida.Name = "UnidadeMedida";
            this.UnidadeMedida.ReadOnly = true;
            // 
            // FrmCadastroEncomendaSelecaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroEncomendaSelecaoProduto";
            this.Text = "Cadastro Encomenda - Seleção produto";
            this.Load += new System.EventHandler(this.FrmCadastroEncomendaSelecaoProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridProduto;
        private System.Windows.Forms.PictureBox BtnCancelar;
        private System.Windows.Forms.TextBox TxtImportado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DataGridViewImageColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoImportado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadeMedida;
    }
}