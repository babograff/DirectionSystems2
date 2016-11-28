namespace DirectionSystems2
{
    partial class FrmNotificacaoDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificacaoDetalhe));
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescricao = new DevExpress.XtraEditors.MemoEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescricao.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDescricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtData);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 370);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notificação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titulo";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(293, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(522, 20);
            this.TxtNome.TabIndex = 6;
            // 
            // TxtData
            // 
            this.TxtData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtData.Enabled = false;
            this.TxtData.Location = new System.Drawing.Point(150, 43);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(135, 20);
            this.TxtData.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Data";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Enabled = false;
            this.TxtDescricao.Location = new System.Drawing.Point(9, 69);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Properties.Appearance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtDescricao.Properties.Appearance.Options.UseBackColor = true;
            this.TxtDescricao.Size = new System.Drawing.Size(806, 295);
            this.TxtDescricao.TabIndex = 43;
            // 
            // FrmNotificacaoDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 394);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNotificacaoDetalhe";
            this.Text = "Notificação - detalhe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.MemoEdit TxtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNome;
    }
}