namespace DirectionSystems2
{
    partial class FrmCadastroEncomendaSelecaoProdutoQuantidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEncomendaSelecaoProdutoQuantidade));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtUnidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtImportado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.PictureBox();
            this.BtnSalvar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtUnidade);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.LblSubTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtQuantidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtImportado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 116);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados  do produto";
            // 
            // TxtUnidade
            // 
            this.TxtUnidade.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtUnidade.Enabled = false;
            this.TxtUnidade.Location = new System.Drawing.Point(150, 84);
            this.TxtUnidade.Name = "TxtUnidade";
            this.TxtUnidade.Size = new System.Drawing.Size(135, 20);
            this.TxtUnidade.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(291, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Valor";
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.Location = new System.Drawing.Point(289, 79);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(98, 25);
            this.LblSubTotal.TabIndex = 49;
            this.LblSubTotal.Text = "R$ 00,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Unidade medida *";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.BackColor = System.Drawing.Color.White;
            this.TxtQuantidade.Location = new System.Drawing.Point(9, 84);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(135, 20);
            this.TxtQuantidade.TabIndex = 44;
            this.TxtQuantidade.Text = "0";
            this.TxtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuantidade_KeyDown);
            this.TxtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidade_KeyPress);
            this.TxtQuantidade.Leave += new System.EventHandler(this.TxtQuantidade_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Quantidade*";
            // 
            // TxtImportado
            // 
            this.TxtImportado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtImportado.Enabled = false;
            this.TxtImportado.Location = new System.Drawing.Point(150, 43);
            this.TxtImportado.Name = "TxtImportado";
            this.TxtImportado.Size = new System.Drawing.Size(135, 20);
            this.TxtImportado.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Código importado*";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(9, 43);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(135, 20);
            this.TxtCodigo.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome*";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(291, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(397, 20);
            this.TxtNome.TabIndex = 6;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(718, 127);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 30);
            this.BtnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCancelar.TabIndex = 57;
            this.BtnCancelar.TabStop = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Location = new System.Drawing.Point(592, 127);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(120, 30);
            this.BtnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnSalvar.TabIndex = 56;
            this.BtnSalvar.TabStop = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
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
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmCadastroEncomendaSelecaoProdutoQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 169);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroEncomendaSelecaoProdutoQuantidade";
            this.Text = "Cadastro Encomenda - Seleção Produto / Quantidade";
            this.Load += new System.EventHandler(this.FrmCadastroEncomendaSelecaoProdutoQuantidade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtImportado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.PictureBox BtnCancelar;
        private System.Windows.Forms.PictureBox BtnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUnidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblSubTotal;
    }
}