using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA.Forms.Aluno
{
    public partial class ConsultarNotasF : Form
    {

        public string CPF="";
        public bool voltar = false;
        public PrivateFontCollection pfc = new PrivateFontCollection();

        public ConsultarNotasF()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarNotasF_Load(object sender, EventArgs e)
        {
            XisPB.Parent = BordaPB;
            MinPB.Parent = BordaPB;
            label1.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            label2.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            label3.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            label4.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            label5.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            label6.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            NomeLbl.Font = new Font(pfc.Families[0], 18, FontStyle.Bold);
            label1.BackColor = label2.BackColor = label3.BackColor = label4.BackColor = label5.BackColor = label6.BackColor = Color.FromArgb(255,217,217,217);

        }

        private void ConsultarNotasF_Shown(object sender, EventArgs e)
        {
            string[] n = Connection.NotasAln(CPF);
            NomeLbl.Text = n[0];  
            label1.Text = n[1];
            label2.Text = n[2];
            label3.Text = n[3];
            label4.Text = n[4];
            label5.Text = n[5];
            label6.Text = n[6];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            voltar = true;
            
        }

        private void XisPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinPB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ConsultarNotasF_Activated(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
