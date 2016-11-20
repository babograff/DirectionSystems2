namespace DirectionSystems2
{
    partial class FrmProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducao));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.BtnAjuda = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnFexar = new System.Windows.Forms.PictureBox();
            this.BtnClienteFornecedor = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.GridProducao = new System.Windows.Forms.DataGridView();
            this.BtnCadastro = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPesquisar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.rodape1 = new DirectionSystems2.Componentes.Rodape();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodImportado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClienteFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCadastro)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
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
            this.panel2.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DirectionSystems2.Properties.Resources.MenuPreco;
            this.pictureBox1.Location = new System.Drawing.Point(467, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 64);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.BtnClienteFornecedor.Image = global::DirectionSystems2.Properties.Resources.MenuProducao2;
            this.BtnClienteFornecedor.Location = new System.Drawing.Point(370, 42);
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
            // GridProducao
            // 
            this.GridProducao.AllowUserToAddRows = false;
            this.GridProducao.AllowUserToDeleteRows = false;
            this.GridProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProducao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.CodProduto,
            this.CodImportado,
            this.Produto,
            this.Quantidade,
            this.Unidade,
            this.Nota});
            this.GridProducao.Location = new System.Drawing.Point(45, 230);
            this.GridProducao.Name = "GridProducao";
            this.GridProducao.ReadOnly = true;
            this.GridProducao.Size = new System.Drawing.Size(821, 442);
            this.GridProducao.TabIndex = 30;
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.BtnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastro.Image")));
            this.BtnCadastro.Location = new System.Drawing.Point(45, 122);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(120, 30);
            this.BtnCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCadastro.TabIndex = 39;
            this.BtnCadastro.TabStop = false;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPesquisar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Location = new System.Drawing.Point(45, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 66);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(9, 36);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(680, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // rodape1
            // 
            this.rodape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rodape1.Location = new System.Drawing.Point(-2, 678);
            this.rodape1.Name = "rodape1";
            this.rodape1.Size = new System.Drawing.Size(900, 22);
            this.rodape1.TabIndex = 29;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // CodProduto
            // 
            this.CodProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodProduto.DataPropertyName = "CodProduto";
            this.CodProduto.HeaderText = "Código Produto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            // 
            // CodImportado
            // 
            this.CodImportado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodImportado.DataPropertyName = "CodImportado";
            this.CodImportado.HeaderText = "Código Importado";
            this.CodImportado.Name = "CodImportado";
            this.CodImportado.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.DataPropertyName = "Nome";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Unidade
            // 
            this.Unidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unidade.DataPropertyName = "Unidade";
            this.Unidade.HeaderText = "Unidade";
            this.Unidade.Name = "Unidade";
            this.Unidade.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nota.DataPropertyName = "Nota";
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // FrmProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.BtnCadastro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridProducao);
            this.Controls.Add(this.rodape1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProducao";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClienteFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCadastro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GridProducao;
        private System.Windows.Forms.PictureBox BtnCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox BtnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodImportado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}