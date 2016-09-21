namespace DirectionSystems2
{
    partial class FrmImportacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportacao));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.BtnAjuda = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnFexar = new System.Windows.Forms.PictureBox();
            this.BtnUsuario = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnImportar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboTabela = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNomeArquivo = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.PictureBox();
            this.GridDados = new System.Windows.Forms.DataGridView();
            this.rodape1 = new DirectionSystems2.Componentes.Rodape();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).BeginInit();
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
            this.panel2.Controls.Add(this.BtnUsuario);
            this.panel2.Controls.Add(this.LblTitulo);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 118);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 47);
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
            // BtnUsuario
            // 
            this.BtnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsuario.Image")));
            this.BtnUsuario.Location = new System.Drawing.Point(461, 47);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(91, 64);
            this.BtnUsuario.TabIndex = 19;
            this.BtnUsuario.TabStop = false;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
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
            this.groupBox1.Controls.Add(this.BtnImportar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboTabela);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNomeArquivo);
            this.groupBox1.Controls.Add(this.BtnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(45, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 83);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo";
            // 
            // BtnImportar
            // 
            this.BtnImportar.BackColor = System.Drawing.Color.Transparent;
            this.BtnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnImportar.Image = global::DirectionSystems2.Properties.Resources.Salvar;
            this.BtnImportar.Location = new System.Drawing.Point(695, 31);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(120, 30);
            this.BtnImportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnImportar.TabIndex = 45;
            this.BtnImportar.TabStop = false;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tabela";
            // 
            // CboTabela
            // 
            this.CboTabela.FormattingEnabled = true;
            this.CboTabela.Items.AddRange(new object[] {
            "Vendas",
            "Produtos",
            "Clientes",
            "Fornecedor"});
            this.CboTabela.Location = new System.Drawing.Point(6, 41);
            this.CboTabela.Name = "CboTabela";
            this.CboTabela.Size = new System.Drawing.Size(182, 21);
            this.CboTabela.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Caminho Arquivo";
            // 
            // TxtNomeArquivo
            // 
            this.TxtNomeArquivo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtNomeArquivo.Cursor = System.Windows.Forms.Cursors.No;
            this.TxtNomeArquivo.Enabled = false;
            this.TxtNomeArquivo.Location = new System.Drawing.Point(194, 42);
            this.TxtNomeArquivo.Name = "TxtNomeArquivo";
            this.TxtNomeArquivo.Size = new System.Drawing.Size(361, 20);
            this.TxtNomeArquivo.TabIndex = 41;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisar.Image")));
            this.BtnPesquisar.Location = new System.Drawing.Point(561, 31);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(120, 30);
            this.BtnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnPesquisar.TabIndex = 20;
            this.BtnPesquisar.TabStop = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // GridDados
            // 
            this.GridDados.AllowUserToAddRows = false;
            this.GridDados.AllowUserToDeleteRows = false;
            this.GridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDados.Location = new System.Drawing.Point(45, 253);
            this.GridDados.Name = "GridDados";
            this.GridDados.ReadOnly = true;
            this.GridDados.Size = new System.Drawing.Size(821, 408);
            this.GridDados.TabIndex = 41;
            // 
            // rodape1
            // 
            this.rodape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rodape1.Location = new System.Drawing.Point(-2, 678);
            this.rodape1.Name = "rodape1";
            this.rodape1.Size = new System.Drawing.Size(900, 22);
            this.rodape1.TabIndex = 23;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(821, 23);
            this.progressBar1.TabIndex = 42;
            // 
            // FrmImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GridDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rodape1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImportacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImportacao";
            this.Load += new System.EventHandler(this.FrmImportacao_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.PictureBox BtnAjuda;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnFexar;
        private System.Windows.Forms.PictureBox BtnUsuario;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Componentes.Rodape rodape1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNomeArquivo;
        private System.Windows.Forms.PictureBox BtnPesquisar;
        private System.Windows.Forms.PictureBox BtnImportar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboTabela;
        private System.Windows.Forms.DataGridView GridDados;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}