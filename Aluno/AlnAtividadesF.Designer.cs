namespace SPA.Forms.Aluno
{
    partial class AlnAtividadesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlnAtividadesF));
            this.XisPB = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MinPB = new System.Windows.Forms.PictureBox();
            this.BordaPB = new System.Windows.Forms.PictureBox();
            this.FundoPB = new System.Windows.Forms.PictureBox();
            this.DataEntLbl = new System.Windows.Forms.Label();
            this.DescricaoRtxt = new System.Windows.Forms.RichTextBox();
            this.NomeLbl = new System.Windows.Forms.Label();
            this.AtividadesCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.XisPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // XisPB
            // 
            this.XisPB.BackColor = System.Drawing.Color.Transparent;
            this.XisPB.Image = ((System.Drawing.Image)(resources.GetObject("XisPB.Image")));
            this.XisPB.Location = new System.Drawing.Point(523, 6);
            this.XisPB.Name = "XisPB";
            this.XisPB.Size = new System.Drawing.Size(10, 10);
            this.XisPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.XisPB.TabIndex = 22;
            this.XisPB.TabStop = false;
            this.XisPB.Click += new System.EventHandler(this.XisPB_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MinPB
            // 
            this.MinPB.BackColor = System.Drawing.Color.Transparent;
            this.MinPB.Image = ((System.Drawing.Image)(resources.GetObject("MinPB.Image")));
            this.MinPB.Location = new System.Drawing.Point(503, 6);
            this.MinPB.Name = "MinPB";
            this.MinPB.Size = new System.Drawing.Size(10, 10);
            this.MinPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinPB.TabIndex = 20;
            this.MinPB.TabStop = false;
            this.MinPB.Click += new System.EventHandler(this.MinPB_Click);
            // 
            // BordaPB
            // 
            this.BordaPB.BackColor = System.Drawing.Color.Transparent;
            this.BordaPB.Image = ((System.Drawing.Image)(resources.GetObject("BordaPB.Image")));
            this.BordaPB.Location = new System.Drawing.Point(0, 0);
            this.BordaPB.Name = "BordaPB";
            this.BordaPB.Size = new System.Drawing.Size(550, 20);
            this.BordaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BordaPB.TabIndex = 19;
            this.BordaPB.TabStop = false;
            this.BordaPB.Click += new System.EventHandler(this.BordaPB_Click);
            this.BordaPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BordaPB_MouseDown);
            this.BordaPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BordaPB_MouseMove);
            this.BordaPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BordaPB_MouseUp);
            // 
            // FundoPB
            // 
            this.FundoPB.BackColor = System.Drawing.Color.Transparent;
            this.FundoPB.Image = ((System.Drawing.Image)(resources.GetObject("FundoPB.Image")));
            this.FundoPB.Location = new System.Drawing.Point(69, 147);
            this.FundoPB.Name = "FundoPB";
            this.FundoPB.Size = new System.Drawing.Size(420, 372);
            this.FundoPB.TabIndex = 23;
            this.FundoPB.TabStop = false;
            this.FundoPB.Click += new System.EventHandler(this.FundoPB_Click_1);
            // 
            // DataEntLbl
            // 
            this.DataEntLbl.AutoSize = true;
            this.DataEntLbl.BackColor = System.Drawing.Color.Transparent;
            this.DataEntLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataEntLbl.Location = new System.Drawing.Point(323, 252);
            this.DataEntLbl.Name = "DataEntLbl";
            this.DataEntLbl.Size = new System.Drawing.Size(87, 13);
            this.DataEntLbl.TabIndex = 27;
            this.DataEntLbl.Text = "Data de entrega:";
            this.DataEntLbl.Click += new System.EventHandler(this.DataEntLbl_Click);
            // 
            // DescricaoRtxt
            // 
            this.DescricaoRtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescricaoRtxt.ForeColor = System.Drawing.SystemColors.Window;
            this.DescricaoRtxt.Location = new System.Drawing.Point(107, 278);
            this.DescricaoRtxt.Name = "DescricaoRtxt";
            this.DescricaoRtxt.ReadOnly = true;
            this.DescricaoRtxt.Size = new System.Drawing.Size(340, 215);
            this.DescricaoRtxt.TabIndex = 28;
            this.DescricaoRtxt.Text = "";
            // 
            // NomeLbl
            // 
            this.NomeLbl.AutoSize = true;
            this.NomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.NomeLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.NomeLbl.Location = new System.Drawing.Point(66, 117);
            this.NomeLbl.Name = "NomeLbl";
            this.NomeLbl.Size = new System.Drawing.Size(35, 13);
            this.NomeLbl.TabIndex = 29;
            this.NomeLbl.Text = "label1";
            // 
            // AtividadesCB
            // 
            this.AtividadesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AtividadesCB.FormattingEnabled = true;
            this.AtividadesCB.Location = new System.Drawing.Point(287, 182);
            this.AtividadesCB.Name = "AtividadesCB";
            this.AtividadesCB.Size = new System.Drawing.Size(160, 21);
            this.AtividadesCB.TabIndex = 30;
            this.AtividadesCB.SelectedIndexChanged += new System.EventHandler(this.AtividadesCB_SelectedIndexChanged);
            this.AtividadesCB.SelectedValueChanged += new System.EventHandler(this.AtividadesCB_SelectedValueChanged);
            // 
            // AlnAtividadesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.AtividadesCB);
            this.Controls.Add(this.NomeLbl);
            this.Controls.Add(this.DescricaoRtxt);
            this.Controls.Add(this.DataEntLbl);
            this.Controls.Add(this.FundoPB);
            this.Controls.Add(this.XisPB);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MinPB);
            this.Controls.Add(this.BordaPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlnAtividadesF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlnAtividadesF";
            this.Activated += new System.EventHandler(this.AlnAtividadesF_Activated);
            this.Load += new System.EventHandler(this.AlnAtividadesF_Load);
            this.Shown += new System.EventHandler(this.AlnAtividadesF_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.XisPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox XisPB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox MinPB;
        private System.Windows.Forms.PictureBox BordaPB;
        private System.Windows.Forms.PictureBox FundoPB;
        private System.Windows.Forms.Label DataEntLbl;
        private System.Windows.Forms.RichTextBox DescricaoRtxt;
        private System.Windows.Forms.Label NomeLbl;
        private System.Windows.Forms.ComboBox AtividadesCB;
    }
}