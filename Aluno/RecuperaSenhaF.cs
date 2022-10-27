using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA.Forms.Aluno
{
    public partial class RecuperaSenhaF : Form
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
        public string CPF_Atual = String.Empty;
        public PrivateFontCollection pfc = new PrivateFontCollection();
        public bool mover = false;
        int t = 60;
        Point posicao_inicia;
        public String P_or_A;
        public bool voltar;
        public string aux;
        public int env;
        Aluno.CriarSenhaF Csf = new Aluno.CriarSenhaF();
        public String GerarSenha()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz023456789*/&@";
            string pass = "#";
            Random random = new Random();
            for (int f = 0; f < 8; f++)
            {
                pass = pass + chars.Substring(random.Next(0, chars.Length - 1), 1);
            }

            return pass;
        }

        public void EnviarSenha(String emailDT)
        {
            aux = GerarSenha();
            SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("spa_noresponse@hotmail.com");
            mail.To.Add(emailDT);
            mail.Subject = "Recuperação de senha";
            mail.Body = "Sua nova senha é " + aux + "\nLembrando que essa é apenas uma senha para criação de uma nova\nPara criar a nova senha basta logar novamente com a informada neste e-mail";
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("spa_noresponse@hotmail.com", "Lilk123456");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }

        public RecuperaSenhaF()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void MinPB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RecuperaSenhaF_Load(object sender, EventArgs e)
        {
           
            EnviarNovamenteLbl.Visible = false;
            CpfInvLBL.Visible = false;
            Csf.pfc = pfc;
            ActiveControl = BordaPB;
            XisPB.Parent = BordaPB;
            MinPB.Parent = BordaPB;
            voltar = false;
            CpfTB.BackColor = Color.FromArgb(255, 207, 255, 105);
            CpfTB.Font = new Font(pfc.Families[0], 14, FontStyle.Bold);
            EmailTB.BackColor = Color.FromArgb(255, 207, 255, 105);
            EmailTB.Font = new Font(pfc.Families[0], 14, FontStyle.Bold);
            EmailTB.Text = "E-mail";
            CpfTB.Text = "CPF";
            EnviarNovamenteLbl.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
        }

        private void XisPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            voltar = true;
            t = 60;
        }

        private void EnviarPB_MouseEnter(object sender, EventArgs e)
        {
            EnviarPB.Image = Botoes.Images[1];
        }

        private void EnviarPB_Click(object sender, EventArgs e)
        {
            

            string[] dados = Connection.DadosAln(CpfTB.Text);
            if (!Valida.IsValidEmail(EmailTB.Text))
            {
                MessageBox.Show("E-mail informado não é valido, por favor informe o e-mail cadastrado corretamente","E-mail invalido",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (dados[0] == "NullCPF" || !Int64.TryParse(CpfTB.Text, out _))
            {
                MessageBox.Show("O CPF informa não pertence a nenhum aluno em nossa base de dados", "CPF não encontrado",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                ActiveControl = BordaPB;
            }
            else if (dados[4]==EmailTB.Text)
            {
                
                EnviarSenha(EmailTB.Text);
                Connection.AlterarSenha(CpfTB.Text,aux);
                MessageBox.Show("Se o e-mail informado for igual ao cadastrado no nosso sistema, será enviada uma nova senha para acesso", "Recuperação de senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveControl = BordaPB;
                EnviarNovamenteT.Enabled = true;
                EnviarNovamenteLbl.Visible = true;
                EnviarPB.Enabled = false;
                env = t;
                CpfInvLBL.Visible = false;
                EnviarPB.Visible = false;
                CpfTB.Enabled = false;
                EmailTB.Enabled = false;
            }
            else
            {
                MessageBox.Show("Se o e-mail informado for igual ao cadastrado no nosso sistema, será enviada uma nova senha de acesso para o e-mail informado", "Recuperação de senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveControl = BordaPB;
                EnviarNovamenteT.Enabled = true;
                EnviarNovamenteLbl.Visible = true;
                EnviarPB.Enabled = false;
                env = t;
                CpfInvLBL.Visible = false;
                EnviarPB.Visible = false;
                CpfTB.Enabled = false;
                EmailTB.Enabled = false;
            }

            

        }

        private void EnviarPB_MouseLeave(object sender, EventArgs e)
        {
            EnviarPB.Image = Botoes.Images[2];
        }

        

    

       

        private void EmailTB_MouseLeave(object sender, EventArgs e)
        {
            if (EmailTB.Text == "") EmailTB.Text = "E-mail";
        }

        private void BordaPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicao_inicia.X, novo.Y - posicao_inicia.Y);

            }
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

        private void CancelarPB_Click(object sender, EventArgs e)
        {
            voltar = true;
            t = 60;
        }

        private void RecuperaSenhaF_Activated(object sender, EventArgs e)
        {
            this.CenterToScreen();
            CpfInvLBL.Visible = false;
            CpfTB.Text = CPF_Atual;
            EmailTB.Text = "E-mail";
            ActiveControl = BordaPB;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void CpfTB_Enter(object sender, EventArgs e)
        {
            if (CpfTB.Text == "CPF") CpfTB.Text = "";
        }

        private void CpfTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EmailTB_Enter(object sender, EventArgs e)
        {
            if (EmailTB.Text == "E-mail") EmailTB.Text = "";
        }

        private void CpfTB_Leave(object sender, EventArgs e)
        {
            if (CpfTB.Text == "") CpfTB.Text = "CPF";
        }

        private void EmailTB_Leave(object sender, EventArgs e)
        {
            if (EmailTB.Text == "") EmailTB.Text = "E-mail";
        }

        private void CpfTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                ActiveControl = BordaPB;
                if (CpfTB.Text == String.Empty)
                {
                    CpfTB.Text = "CPF";
                    CpfInvLBL.Visible = false;
                }

                if(CpfTB.Text=="CPF")
                {
                    CpfInvLBL.Visible = false;
                }

            }

            if (e.KeyValue == 13)
            {
                ActiveControl = EmailTB;
            }
        }


        private void CpfTB_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void EmailTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                ActiveControl = BordaPB;
                if (EmailTB.Text == String.Empty)
                {
                    EmailTB.Text = "E-mail";
                }

            }

            if(e.KeyValue == 13)
            {
                string[] dados = Connection.DadosAln(CpfTB.Text);
                if (!Valida.IsValidEmail(EmailTB.Text))
                {
                    MessageBox.Show("E-mail informado não é valido, por favor informe o e-mail cadastrado corretamente", "E-mail invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dados[0] == "NullCPF" || !Int64.TryParse(CpfTB.Text, out _))
                {
                    MessageBox.Show("O CPF informa não pertence a nenhum aluno em nossa base de dados", "CPF não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActiveControl = BordaPB;
                }
                else if (dados[4] == EmailTB.Text)
                {
                    EnviarSenha(EmailTB.Text);
                    Connection.AlterarSenha(CpfTB.Text, aux);
                    MessageBox.Show("Se o e-mail informado for igual ao cadastrado no nosso sistema, será enviada uma nova senha para acesso", "Recuperação de senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActiveControl = BordaPB;
                    EnviarNovamenteT.Enabled = true;
                    EnviarNovamenteLbl.Visible = true;
                    EnviarPB.Enabled = false;
                    env = t;
                    CpfInvLBL.Visible = false;
                    EnviarPB.Visible = false;
                    CpfTB.Enabled = false;
                    EmailTB.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Se o e-mail informado for igual ao cadastrado no nosso sistema, será enviada uma nova senha de acesso para o e-mail informado", "Recuperação de senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActiveControl = BordaPB;
                    EnviarNovamenteT.Enabled = true;
                    EnviarNovamenteLbl.Visible = true;
                    EnviarPB.Enabled = false;
                    env = t;
                    CpfInvLBL.Visible = false;
                    EnviarPB.Visible = false;
                    CpfTB.Enabled = false;
                    EmailTB.Enabled = false;
                }
            }
        }

        private void RecuperaSenhaF_Click(object sender, EventArgs e)
        {
            ActiveControl = BordaPB;
            if (EmailTB.Text == String.Empty)
            {
                EmailTB.Text = "E-mail";
            }

            if (CpfTB.Text == String.Empty)
            {
                CpfTB.Text = "CPF";
                CpfInvLBL.Visible = false;
            }

        }

        private void CpfTB_TextChanged(object sender, EventArgs e)
        {
                if (!Valida.ValidaCPF(CpfTB.Text)) CpfInvLBL.Visible = true;
                else CpfInvLBL.Visible = false;    
        }

        private void RecuperaSenhaF_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void RecuperaSenhaF_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void EnviarNovamenteT_Tick(object sender, EventArgs e)
        {
         
            if(env > 0)
            {
                EnviarNovamenteLbl.Text = $"Aguarde {env} segundos para tentar novamente";
                env--;
            }
            else 
            {
                t = t * 3;
                env = t;
                EnviarNovamenteLbl.Visible = false;
                EnviarNovamenteT.Enabled = false;
                EnviarPB.Enabled = true;
                EnviarPB.Visible = true;
                CpfTB.Enabled = true;
                EmailTB.Enabled = true;
            }
        }
    }
}
