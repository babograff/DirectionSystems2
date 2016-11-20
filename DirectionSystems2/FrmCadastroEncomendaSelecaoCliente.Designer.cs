namespace DirectionSystems2
{
    partial class FrmCadastroEncomendaSelecaoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEncomendaSelecaoCliente));
            this.GridCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.PictureBox();
            this.Selecionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCliente
            // 
            this.GridCliente.AllowUserToAddRows = false;
            this.GridCliente.AllowUserToDeleteRows = false;
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Codigo,
            this.CPFCNPJ,
            this.Nome,
            this.Endereco,
            this.Bairro,
            this.Cidade,
            this.UF,
            this.Telefone,
            this.Email});
            this.GridCliente.Location = new System.Drawing.Point(6, 69);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ReadOnly = true;
            this.GridCliente.Size = new System.Drawing.Size(809, 261);
            this.GridCliente.TabIndex = 48;
            this.GridCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TxtCPFCNPJ);
            this.groupBox1.Controls.Add(this.GridCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 336);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados cliente";
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
            // TxtCPFCNPJ
            // 
            this.TxtCPFCNPJ.BackColor = System.Drawing.Color.White;
            this.TxtCPFCNPJ.Location = new System.Drawing.Point(9, 43);
            this.TxtCPFCNPJ.Name = "TxtCPFCNPJ";
            this.TxtCPFCNPJ.Size = new System.Drawing.Size(128, 20);
            this.TxtCPFCNPJ.TabIndex = 9;
            this.TxtCPFCNPJ.Enter += new System.EventHandler(this.TxtCPFCNPJ_Enter);
            this.TxtCPFCNPJ.Leave += new System.EventHandler(this.TxtCPFCNPJ_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF / CNPJ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome ";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.White;
            this.TxtNome.Location = new System.Drawing.Point(150, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(539, 20);
            this.TxtNome.TabIndex = 6;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(713, 354);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 30);
            this.BtnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCancelar.TabIndex = 53;
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
            this.Codigo.DataPropertyName = "CodClienteFornecedor";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.DataPropertyName = "CPFCNPJ";
            this.CPFCNPJ.HeaderText = "CPFCNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "UF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // FrmCadastroEncomendaSelecaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroEncomendaSelecaoCliente";
            this.Text = "Cadastro Encomenda - Seleção Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridCliente;
        private System.Windows.Forms.PictureBox BtnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtCPFCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DataGridViewImageColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}