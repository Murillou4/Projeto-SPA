using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA.Forms
{
    
    public partial class AlunoPF : Form
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

        public PrivateFontCollection pfc = new PrivateFontCollection();
        public Forms.Aluno.ConsultarNotasF Cnf = new Aluno.ConsultarNotasF();
        public Forms.Aluno.AlnAtividadesF AlnAt = new Aluno.AlnAtividadesF();
        public string CPF="";
        public bool voltar=false;
        public AlunoPF()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void ConsultaPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cnf.voltar = false;
            Cnf.Show();
        }

        private void MinPB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void XisPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AlunoPF_Load(object sender, EventArgs e)
        {
            XisPB.Parent = BordaPB;
            MinPB.Parent = BordaPB;
            Cnf.pfc = pfc;
            AlnAt.pfc = pfc;
        }

        private void AlunoPF_Shown(object sender, EventArgs e)
        {
            Cnf.CPF = CPF;
            AlnAt.cpf = CPF;
            voltar = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            voltar = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Cnf.voltar)
            {
                Cnf.Hide();
                this.Show();
                voltar = false;
                Cnf.voltar = false;
            }
            if (AlnAt.voltar)
            {
                AlnAt.Hide();
                this.Show();
                AlnAt.voltar = false;
            }
            
        }

        private void BordaPB_Click(object sender, EventArgs e)
        {

        }

        private void AtividadesPB_Click(object sender, EventArgs e)
        {
            AlnAt.Show();
            this.Hide();
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

        private void AlunoPF_Activated(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
