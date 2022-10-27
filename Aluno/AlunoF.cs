using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using Npgsql;

namespace SPA.Forms
{

    public partial class AlunoF : Form
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
        public bool Voltar;
        string a = Application.ExecutablePath;
        PrivateFontCollection pfc = new PrivateFontCollection();
        string[] b;
        Forms.AlunoPF alnPF = new AlunoPF();
        Aluno.RecuperaSenhaF Rcf = new Aluno.RecuperaSenhaF();
        Aluno.CriarSenhaF Csf = new Aluno.CriarSenhaF();
        public bool mover = false;
        Point posicao_inicia;
        public AlunoF()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }


        private void AlunoF_Load(object sender, EventArgs e)
        {
            Csf.pfc = pfc;
            EsqueciSenhaPB.Visible = false;
            a = a.Replace("SPA", "*");
            b = a.Split('*');
            b[0] += "SPA\\Fonte.otf";
            //Adiciona a fonte usada para todos a entradas de texto
            pfc.AddFontFile(b[0]);
            alnPF.pfc = pfc;
            Rcf.pfc = pfc;
            ActiveControl = BordaPB;
            SenhaTB.PasswordChar = '\u0000';
            Voltar = false;
            MinPB.Parent = BordaPB;
            MinPB.BackColor = Color.Transparent;
            BordaPB.BackColor = Color.Transparent;
            XisPB.Parent = BordaPB;
            XisPB.BackColor = Color.Transparent;
            CpfTB.BackColor = Color.FromArgb(255, 207, 255, 105);
            CpfTB.Font = new Font(pfc.Families[0], 14, FontStyle.Bold);
            SenhaTB.BackColor = Color.FromArgb(255, 207, 255, 105);
            SenhaTB.Font = new Font(pfc.Families[0], 14, FontStyle.Bold);
            SenhaTB.Text = "Senha";
            CpfTB.Text = "CPF";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Voltar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Voltar = true;

            EsqueciSenhaPB.Visible = false;
            SenhaTB.PasswordChar = '\u0000';
            SenhaTB.Text = "Senha";
            CpfTB.Text = "CPF";

        }

        private void MinPB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CpfTB_TextChanged(object sender, EventArgs e)
        {
            if (!Valida.ValidaCPF(CpfTB.Text) && CpfTB.Text!="CPF")
            {
                CpfInvLBL.Visible = true;
            }
            else
            {
                CpfInvLBL.Visible = false;
            }
        }

        

        private void CpfPB_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void CpfPB_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void CpfPB_Click(object sender, EventArgs e)
        {
            
        }

        private void CpfTB_Enter(object sender, EventArgs e)
        {
            if (CpfTB.Text.Equals("CPF")) CpfTB.Text = "";
        }

        private void CpfTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==27)
            {
                ActiveControl = BordaPB;
                if (CpfTB.Text == String.Empty)
                {
                    CpfTB.Text = "CPF";
                }

            }

            if(e.KeyValue==13)
            {

                ActiveControl = SenhaTB;
                
            }
        }

        private void SenhaTB_TextChanged(object sender, EventArgs e)
        {
            if(!SenhaTB.Text.Equals("Senha"))
            {
                SenhaTB.PasswordChar = '*';
            }
        }

        private void SenhaTB_Enter(object sender, EventArgs e)
        {
            if (SenhaTB.Text.Equals("Senha")) SenhaTB.Text = "";
        }

        private void CpfTB_Leave(object sender, EventArgs e)
        {
            if (CpfTB.Text == String.Empty) CpfTB.Text = "CPF";
        }

        private void SenhaTB_Leave(object sender, EventArgs e)
        {
            if (SenhaTB.Text == String.Empty)
            {
                SenhaTB.Text = "Senha";
                SenhaTB.PasswordChar = '\u0000';
            }
        }

        private void AlunoF_Shown(object sender, EventArgs e)
        {
            
            CpfInvLBL.Visible = false;
            ActiveControl = BordaPB;
            SenhaTB.PasswordChar = '\u0000';
            Voltar = false;
            MinPB.Parent = BordaPB;
            MinPB.BackColor = Color.Transparent;
            BordaPB.BackColor = Color.Transparent;
            XisPB.Parent = BordaPB;
            XisPB.BackColor = Color.Transparent;
            CpfTB.BackColor = Color.FromArgb(255, 207, 255, 105);
            CpfTB.Font = new Font(pfc.Families[0], 14, FontStyle.Bold);
            SenhaTB.BackColor = Color.FromArgb(255, 207, 255, 105);
            SenhaTB.Font = new Font(pfc.Families[0], 14, FontStyle.Bold);
            SenhaTB.Text = "Senha";
            CpfTB.Text = "CPF";
        }

        private void EntrarPB_Click(object sender, EventArgs e)
        {
            ActiveControl = BordaPB;

            if (Valida.ValidaCPF(CpfTB.Text))
            {
                DataTable _dt = new DataTable();
                string r = Connection.LoginTest("select * from alunos where CPF = @CPF", CpfTB.Text);
                if (r != string.Empty)
                {
                    
                    string[] aux = r.Split(';');
                    if (aux[1]==SenhaTB.Text)
                    {
                        string temp = aux[1];
                       
                        if (temp[0] == '#')
                        {
                            Csf.CPF = CpfTB.Text;
                            Csf.Show();
                            this.Hide();
                            SenhaTB.Text = "Senha";
                        }
                        else
                        {
                            this.Hide();
                            alnPF.Show();
                            alnPF.CPF = CpfTB.Text;
                            alnPF.voltar = false;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta para o CPF informado", "Senha invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EsqueciSenhaPB.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Seu CPF não está cadastrado no sistema, procure seu coordenador.","Erro CPF não cadastrado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                

               

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

        private void AlunoF_Click(object sender, EventArgs e)
        {
            ActiveControl = BordaPB;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(alnPF.voltar)
            {

                alnPF.Hide();
                this.Show();
                alnPF.voltar = false;
                CpfTB.Text = "CPF";
                SenhaTB.Text = "Senha";
                SenhaTB.PasswordChar = '\u0000';
            }

            if (Rcf.voltar)
            {
                Rcf.Hide();
                this.Show();
                Rcf.voltar = false;
                SenhaTB.Text = "Senha";
                SenhaTB.PasswordChar = '\u0000';
            }

            if(Csf.voltar)
            {
                Csf.Hide();
                this.Show();
                Csf.voltar = false;
                SenhaTB.Text = "Senha";
                SenhaTB.PasswordChar = '\u0000';
            }

        }

        private void XisPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void BordaPB_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicia = new Point(e.X, e.Y);
        }

        private void BordaPB_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void AlunoF_Activated(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void CpfTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EsqueciSenha_MouseEnter(object sender, EventArgs e)
        {
            EsqueciSenhaPB.Image = EsqueciAceso.Image;
        }

        private void EsqueciSenhaPB_MouseLeave(object sender, EventArgs e)
        {
            EsqueciSenhaPB.Image = EsqueciApagado.Image;
        }

        private void BordaPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicao_inicia.X, novo.Y - posicao_inicia.Y);

            }
        }

        private void EsqueciSenhaPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rcf.P_or_A = "Aluno";
            if (Valida.ValidaCPF(CpfTB.Text))
            {
                Rcf.CPF_Atual = CpfTB.Text;
            }
            else Rcf.CPF_Atual = "CPF";
            
            Rcf.Show();
            Rcf.voltar = false;
        }

        private void AlunoPB_Click(object sender, EventArgs e)
        {

        }

        private void CpfTB_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void SenhaTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                ActiveControl = BordaPB;
                if (SenhaTB.Text == String.Empty)
                {
                    SenhaTB.Text = "CPF";
                }

            }

            if (e.KeyValue == 13)
            {

                ActiveControl = BordaPB;

                if (Valida.ValidaCPF(CpfTB.Text))
                {
                    DataTable _dt = new DataTable();
                    string r = Connection.LoginTest("select * from alunos where CPF = @CPF", CpfTB.Text);
                    if (r != string.Empty)
                    {

                        string[] aux = r.Split(';');
                        if (aux[1] == SenhaTB.Text)
                        {
                            string temp = aux[1];

                            if (temp[0] == '#')
                            {
                                Csf.CPF = CpfTB.Text;
                                Csf.Show();
                                this.Hide();
                                SenhaTB.Text = "Senha";
                            }
                            else
                            {
                                this.Hide();
                                alnPF.Show();
                                alnPF.CPF = CpfTB.Text;
                                alnPF.voltar = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta para o CPF informado", "Senha invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            EsqueciSenhaPB.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seu CPF não está cadastrado no sistema, procure seu coordenador.", "Erro CPF não cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }




                }

            }
        }
    }
}
