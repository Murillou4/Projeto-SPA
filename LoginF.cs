using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SPA
{

    public partial class LoginF : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Forms.AlunoF aln = new Forms.AlunoF();
        public Forms.ProfessorF prof = new Forms.ProfessorF();
       


        public LoginF()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        

        private void XisPB_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void XisPB_MouseEnter(object sender, EventArgs e)
        {
          
            
        }

        private void XisPB_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void XisPB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinPB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AlunoLogin_MouseEnter(object sender, EventArgs e)
        {
            AlunoLogin.Image = AlunoImages.Images[0];
            AlunoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

        }

        private void AlunoLogin_MouseLeave(object sender, EventArgs e)
        {
            AlunoLogin.Image = AlunoImages.Images[1];
            AlunoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        private void ProfessorLogin_MouseEnter(object sender, EventArgs e)
        {
            ProfessorLogin.Image = ProfessorImages.Images[0];
            ProfessorLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        private void ProfessorLogin_MouseLeave(object sender, EventArgs e)
        {
            ProfessorLogin.Image = ProfessorImages.Images[1];
            ProfessorLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        private void AlunoLogin_Click(object sender, EventArgs e)
        {
            
            aln.Show();
            this.Hide();
            aln.Voltar = false;
        }

        private void ProfessorLogin_Click(object sender, EventArgs e)
        {
            prof.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aln.Voltar)
            {
                this.Show();
                aln.Voltar = false;
                this.CenterToScreen();
            }



        }

        private void BordaPB_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XisPB.Parent = BordaPB;
            XisPB.BackColor = Color.Transparent;
            MinPB.Parent = BordaPB;
            MinPB.BackColor = Color.Transparent;
        }

        public bool mover = false;
        Point posicao_inicia;
        private void BordaPB_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicia = new Point(e.X, e.Y);
        }

        private void BordaPB_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void BordaPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicao_inicia.X, novo.Y - posicao_inicia.Y);

            }
        }

        private void LoginF_Shown(object sender, EventArgs e)
        {
            this.CenterToScreen();   
        }
    }
}
