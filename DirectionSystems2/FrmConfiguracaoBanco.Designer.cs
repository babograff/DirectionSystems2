namespace DirectionSystems2
{
    partial class FrmConfiguracaoBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracaoBanco));
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.TxtPorta = new System.Windows.Forms.TextBox();
            this.TxtInstancia = new System.Windows.Forms.TextBox();
            this.TxtBanco = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(154, 244);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(139, 20);
            this.TxtIP.TabIndex = 1;
            // 
            // TxtPorta
            // 
            this.TxtPorta.Location = new System.Drawing.Point(154, 266);
            this.TxtPorta.Name = "TxtPorta";
            this.TxtPorta.Size = new System.Drawing.Size(139, 20);
            this.TxtPorta.TabIndex = 2;
            // 
            // TxtInstancia
            // 
            this.TxtInstancia.Location = new System.Drawing.Point(154, 288);
            this.TxtInstancia.Name = "TxtInstancia";
            this.TxtInstancia.Size = new System.Drawing.Size(139, 20);
            this.TxtInstancia.TabIndex = 3;
            // 
            // TxtBanco
            // 
            this.TxtBanco.Location = new System.Drawing.Point(154, 310);
            this.TxtBanco.Name = "TxtBanco";
            this.TxtBanco.Size = new System.Drawing.Size(139, 20);
            this.TxtBanco.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DirectionSystems2.Properties.Resources.BotaoSalvarMaior;
            this.pictureBox1.Location = new System.Drawing.Point(12, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 32);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DirectionSystems2.Properties.Resources.BotaoCancelarLogin;
            this.pictureBox2.Location = new System.Drawing.Point(12, 374);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 32);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // FrmConfiguracaoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(330, 530);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtBanco);
            this.Controls.Add(this.TxtInstancia);
            this.Controls.Add(this.TxtPorta);
            this.Controls.Add(this.TxtIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfiguracaoBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfiguracaoBanco";
            this.Load += new System.EventHandler(this.FrmConfiguracaoBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.TextBox TxtPorta;
        private System.Windows.Forms.TextBox TxtInstancia;
        private System.Windows.Forms.TextBox TxtBanco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}