namespace DirectionSystems2.Componentes
{
    partial class Rodape
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblNomeUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCodUsuario = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, -77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 23);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.LblNomeUsuario);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.LblCodUsuario);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 24);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // LblNomeUsuario
            // 
            this.LblNomeUsuario.AutoSize = true;
            this.LblNomeUsuario.Location = new System.Drawing.Point(58, 5);
            this.LblNomeUsuario.Name = "LblNomeUsuario";
            this.LblNomeUsuario.Size = new System.Drawing.Size(35, 13);
            this.LblNomeUsuario.TabIndex = 6;
            this.LblNomeUsuario.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // LblCodUsuario
            // 
            this.LblCodUsuario.AutoSize = true;
            this.LblCodUsuario.Location = new System.Drawing.Point(11, 5);
            this.LblCodUsuario.Name = "LblCodUsuario";
            this.LblCodUsuario.Size = new System.Drawing.Size(25, 13);
            this.LblCodUsuario.TabIndex = 0;
            this.LblCodUsuario.Text = "000";
            // 
            // Rodape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Rodape";
            this.Size = new System.Drawing.Size(900, 22);
            this.Load += new System.EventHandler(this.Rodape_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblNomeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCodUsuario;
    }
}
