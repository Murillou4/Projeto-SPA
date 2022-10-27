using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA.Forms
{
    public partial class ProfessorF : Form
    {
        public bool voltar = false;
        public bool fechar = false;
        public bool mover = false;
        Point posicao_inicia;
        public ProfessorF()
        {
            InitializeComponent();
        }

        private void ProfessorF_Load(object sender, EventArgs e)
        {
            voltar = false;
            XisPB.Parent = BordaPB;
            MinPB.Parent = BordaPB;
        }

        private void BordaPB_Click(object sender, EventArgs e)
        {

        }

        private void XisPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinPB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ProfessorF_Activated(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void BordaPB_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void BordaPB_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicia = new Point(e.X, e.Y);
        }

        private void BordaPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicao_inicia.X, novo.Y - posicao_inicia.Y);

            }
        }

        private void EntrarPB_MouseEnter(object sender, EventArgs e)
        {
            EntrarPB.Image = EntrarImages.Images[0];
        }

        private void EntrarPB_MouseLeave(object sender, EventArgs e)
        {
            EntrarPB.Image = EntrarImages.Images[1];
        }
    }
}
