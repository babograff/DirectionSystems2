namespace DirectionSystems2
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.TxtCaminhoRestore = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnBackup = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCaminho = new System.Windows.Forms.TextBox();
            this.TxtBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.BtnAjuda = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnFexar = new System.Windows.Forms.PictureBox();
            this.BtnUsuario = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.rodape1 = new DirectionSystems2.Componentes.Rodape();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.TxtCaminhoRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBackup)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCaminhoRestore
            // 
            this.TxtCaminhoRestore.Controls.Add(this.progressBar1);
            this.TxtCaminhoRestore.Controls.Add(this.BtnBackup);
            this.TxtCaminhoRestore.Controls.Add(this.label4);
            this.TxtCaminhoRestore.Controls.Add(this.TxtCaminho);
            this.TxtCaminhoRestore.Controls.Add(this.TxtBanco);
            this.TxtCaminhoRestore.Controls.Add(this.label2);
            this.TxtCaminhoRestore.Location = new System.Drawing.Point(45, 140);
            this.TxtCaminhoRestore.Name = "TxtCaminhoRestore";
            this.TxtCaminhoRestore.Size = new System.Drawing.Size(821, 154);
            this.TxtCaminhoRestore.TabIndex = 40;
            this.TxtCaminhoRestore.TabStop = false;
            this.TxtCaminhoRestore.Text = "Backup";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 121);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(788, 23);
            this.progressBar1.TabIndex = 47;
            // 
            // BtnBackup
            // 
            this.BtnBackup.BackColor = System.Drawing.Color.Transparent;
            this.BtnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBackup.Image = global::DirectionSystems2.Properties.Resources.Salvar;
            this.BtnBackup.Location = new System.Drawing.Point(679, 73);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(120, 30);
            this.BtnBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnBackup.TabIndex = 46;
            this.BtnBackup.TabStop = false;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Caminho Arquivo";
            // 
            // TxtCaminho
            // 
            this.TxtCaminho.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtCaminho.Cursor = System.Windows.Forms.Cursors.No;
            this.TxtCaminho.Enabled = false;
            this.TxtCaminho.Location = new System.Drawing.Point(11, 83);
            this.TxtCaminho.Name = "TxtCaminho";
            this.TxtCaminho.Size = new System.Drawing.Size(662, 20);
            this.TxtCaminho.TabIndex = 44;
            this.TxtCaminho.Text = "C:\\DirectionSystems2\\Backup BD";
            // 
            // TxtBanco
            // 
            this.TxtBanco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtBanco.Cursor = System.Windows.Forms.Cursors.No;
            this.TxtBanco.Enabled = false;
            this.TxtBanco.Location = new System.Drawing.Point(9, 36);
            this.TxtBanco.Name = "TxtBanco";
            this.TxtBanco.Size = new System.Drawing.Size(790, 20);
            this.TxtBanco.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banco de dados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(45, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 113);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::DirectionSystems2.Properties.Resources.Salvar;
            this.pictureBox2.Location = new System.Drawing.Point(679, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Caminho Arquivo";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(11, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(662, 20);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "C:\\DirectionSystems2\\Backup BD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox4);
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
            this.panel2.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 64);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(319, 42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 64);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
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
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click_1);
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
            this.BtnUsuario.Location = new System.Drawing.Point(416, 42);
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
            // rodape1
            // 
            this.rodape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rodape1.Location = new System.Drawing.Point(-2, 678);
            this.rodape1.Name = "rodape1";
            this.rodape1.Size = new System.Drawing.Size(903, 22);
            this.rodape1.TabIndex = 25;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(11, 84);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(788, 23);
            this.progressBar2.TabIndex = 48;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TxtCaminhoRestore);
            this.Controls.Add(this.rodape1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBackup";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.TxtCaminhoRestore.ResumeLayout(false);
            this.TxtCaminhoRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBackup)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFexar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.Rodape rodape1;
        private System.Windows.Forms.GroupBox TxtCaminhoRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCaminho;
        private System.Windows.Forms.PictureBox BtnBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.PictureBox BtnAjuda;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnFexar;
        private System.Windows.Forms.PictureBox BtnUsuario;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}