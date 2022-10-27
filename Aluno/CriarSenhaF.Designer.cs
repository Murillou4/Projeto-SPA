namespace SPA.Forms.Aluno
{
    partial class CriarSenhaF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarSenhaF));
            this.CriarNovaSenhaPB = new System.Windows.Forms.PictureBox();
            this.SenhaPB = new System.Windows.Forms.PictureBox();
            this.ConfirmarSenhaPB = new System.Windows.Forms.PictureBox();
            this.CancelarPB = new System.Windows.Forms.PictureBox();
            this.EnviarPB = new System.Windows.Forms.PictureBox();
            this.SenhaTB = new System.Windows.Forms.TextBox();
            this.ConfirmarSenhaTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CriarNovaSenhaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenhaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmarSenhaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnviarPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CriarNovaSenhaPB
            // 
            this.CriarNovaSenhaPB.BackColor = System.Drawing.Color.Transparent;
            this.CriarNovaSenhaPB.Image = ((System.Drawing.Image)(resources.GetObject("CriarNovaSenhaPB.Image")));
            this.CriarNovaSenhaPB.Location = new System.Drawing.Point(71, 39);
            this.CriarNovaSenhaPB.Name = "CriarNovaSenhaPB";
            this.CriarNovaSenhaPB.Size = new System.Drawing.Size(211, 90);
            this.CriarNovaSenhaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CriarNovaSenhaPB.TabIndex = 0;
            this.CriarNovaSenhaPB.TabStop = false;
            // 
            // SenhaPB
            // 
            this.SenhaPB.BackColor = System.Drawing.Color.Transparent;
            this.SenhaPB.Image = ((System.Drawing.Image)(resources.GetObject("SenhaPB.Image")));
            this.SenhaPB.Location = new System.Drawing.Point(51, 166);
            this.SenhaPB.Name = "SenhaPB";
            this.SenhaPB.Size = new System.Drawing.Size(261, 38);
            this.SenhaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SenhaPB.TabIndex = 1;
            this.SenhaPB.TabStop = false;
            // 
            // ConfirmarSenhaPB
            // 
            this.ConfirmarSenhaPB.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmarSenhaPB.Image = ((System.Drawing.Image)(resources.GetObject("ConfirmarSenhaPB.Image")));
            this.ConfirmarSenhaPB.Location = new System.Drawing.Point(51, 220);
            this.ConfirmarSenhaPB.Name = "ConfirmarSenhaPB";
            this.ConfirmarSenhaPB.Size = new System.Drawing.Size(261, 38);
            this.ConfirmarSenhaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ConfirmarSenhaPB.TabIndex = 2;
            this.ConfirmarSenhaPB.TabStop = false;
            // 
            // CancelarPB
            // 
            this.CancelarPB.BackColor = System.Drawing.Color.Transparent;
            this.CancelarPB.Image = ((System.Drawing.Image)(resources.GetObject("CancelarPB.Image")));
            this.CancelarPB.Location = new System.Drawing.Point(71, 269);
            this.CancelarPB.Name = "CancelarPB";
            this.CancelarPB.Size = new System.Drawing.Size(80, 30);
            this.CancelarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CancelarPB.TabIndex = 3;
            this.CancelarPB.TabStop = false;
            this.CancelarPB.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // EnviarPB
            // 
            this.EnviarPB.BackColor = System.Drawing.Color.Transparent;
            this.EnviarPB.Image = ((System.Drawing.Image)(resources.GetObject("EnviarPB.Image")));
            this.EnviarPB.Location = new System.Drawing.Point(192, 269);
            this.EnviarPB.Name = "EnviarPB";
            this.EnviarPB.Size = new System.Drawing.Size(80, 30);
            this.EnviarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EnviarPB.TabIndex = 4;
            this.EnviarPB.TabStop = false;
            this.EnviarPB.Click += new System.EventHandler(this.EnviarPB_Click);
            this.EnviarPB.MouseEnter += new System.EventHandler(this.EnviarPB_MouseEnter);
            this.EnviarPB.MouseLeave += new System.EventHandler(this.EnviarPB_MouseLeave);
            // 
            // SenhaTB
            // 
            this.SenhaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SenhaTB.Location = new System.Drawing.Point(71, 176);
            this.SenhaTB.Name = "SenhaTB";
            this.SenhaTB.PasswordChar = '*';
            this.SenhaTB.Size = new System.Drawing.Size(226, 13);
            this.SenhaTB.TabIndex = 5;
            this.SenhaTB.TextChanged += new System.EventHandler(this.SenhaTB_TextChanged);
            this.SenhaTB.Enter += new System.EventHandler(this.SenhaTB_Enter);
            this.SenhaTB.Leave += new System.EventHandler(this.SenhaTB_Leave);
            // 
            // ConfirmarSenhaTB
            // 
            this.ConfirmarSenhaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmarSenhaTB.Location = new System.Drawing.Point(71, 230);
            this.ConfirmarSenhaTB.Name = "ConfirmarSenhaTB";
            this.ConfirmarSenhaTB.PasswordChar = '*';
            this.ConfirmarSenhaTB.Size = new System.Drawing.Size(226, 13);
            this.ConfirmarSenhaTB.TabIndex = 6;
            this.ConfirmarSenhaTB.TextChanged += new System.EventHandler(this.ConfirmarSenhaTB_TextChanged);
            this.ConfirmarSenhaTB.Enter += new System.EventHandler(this.ConfirmarSenhaTB_Enter);
            this.ConfirmarSenhaTB.Leave += new System.EventHandler(this.ConfirmarSenhaTB_Leave);
            // 
            // CriarSenhaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(355, 320);
            this.Controls.Add(this.ConfirmarSenhaTB);
            this.Controls.Add(this.SenhaTB);
            this.Controls.Add(this.EnviarPB);
            this.Controls.Add(this.CancelarPB);
            this.Controls.Add(this.ConfirmarSenhaPB);
            this.Controls.Add(this.SenhaPB);
            this.Controls.Add(this.CriarNovaSenhaPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarSenhaF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriarSenhaF";
            this.Activated += new System.EventHandler(this.CriarSenhaF_Activated);
            this.Load += new System.EventHandler(this.CriarSenhaF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CriarNovaSenhaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenhaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmarSenhaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelarPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnviarPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CriarNovaSenhaPB;
        private System.Windows.Forms.PictureBox SenhaPB;
        private System.Windows.Forms.PictureBox ConfirmarSenhaPB;
        private System.Windows.Forms.PictureBox CancelarPB;
        private System.Windows.Forms.PictureBox EnviarPB;
        private System.Windows.Forms.TextBox SenhaTB;
        private System.Windows.Forms.TextBox ConfirmarSenhaTB;
    }
}