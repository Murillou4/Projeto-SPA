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
    public partial class AlnAtividadesF : Form
    {
        public bool voltar = false;
        public string cpf = "";
        public PrivateFontCollection pfc = new PrivateFontCollection();
        List<Atividade> slc = new List<Atividade>();
        public AlnAtividadesF()
        {
            InitializeComponent();
        }

        private void MinPB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void XisPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AlnAtividadesF_Load(object sender, EventArgs e)
        {
            XisPB.Parent = BordaPB;
            MinPB.Parent = BordaPB;
            DescricaoRtxt.BackColor = Color.FromArgb(255, 116, 116, 116);
            NomeLbl.Font = new Font(pfc.Families[0], 18, FontStyle.Bold);
            DescricaoRtxt.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            AtividadesCB.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
            DescricaoRtxt.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
            DataEntLbl.BackColor = Color.FromArgb(255, 116, 116, 116);
            AtividadesCB.Items.Add("Selecionar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            voltar = true;
        }

        private void FundoPB_Click(object sender, EventArgs e)
        {

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

        private void DataEntLbl_Click(object sender, EventArgs e)
        {

        }

        private void AlnAtividadesF_Shown(object sender, EventArgs e)
        {
            AtividadesCB.SelectedIndex = 0;
            List<string> l = Connection.Atividades(Connection.DadosAln(cpf)[3]);
            NomeLbl.Text = Connection.DadosAln(cpf)[1];
            Atividade obj = new Atividade();
            l.ForEach(delegate (string at)
            {
                string[] atividade = at.Split(';');
                AtividadesCB.Items.Add(atividade[0]);
                obj = new Atividade(atividade[0], atividade[1], atividade[2]);
                
                slc.Add(obj);
            });
            

        }



        private void FundoPB_Click_1(object sender, EventArgs e)
        {

      

        }

        private void AtividadesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void AtividadesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescricaoRtxt.Clear();
            DataEntLbl.Text = "Data de entrega ";
            if (AtividadesCB.SelectedIndex != 0)
            { 
                foreach (Atividade aux in slc)
                {

                    if (aux.getTitulo().Equals(AtividadesCB.Text))
                    {
                        DescricaoRtxt.Text = aux.getDesc();
                        DataEntLbl.Text += " " + aux.getData();

                    }
                }
            }
            else
            {
                DescricaoRtxt.Clear();
                DataEntLbl.Text = "Data de entrega ";
            }
        }

        private void BordaPB_Click(object sender, EventArgs e)
        {

        }

        private void AlnAtividadesF_Activated(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
