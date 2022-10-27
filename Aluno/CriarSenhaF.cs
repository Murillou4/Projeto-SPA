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

namespace SPA.Forms.Aluno
{
    public partial class CriarSenhaF : Form
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
        public bool voltar=false;
        public string CPF;
        public CriarSenhaF()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SenhaTB.PasswordChar = '\u0000';
            SenhaTB.Text = "Senha";
            ConfirmarSenhaTB.PasswordChar = '\u0000';
            ConfirmarSenhaTB.Text = "Confirmar senha";
            voltar = true;
        }

        private void CriarSenhaF_Load(object sender, EventArgs e)
        {
            ActiveControl = CriarNovaSenhaPB;
            SenhaTB.PasswordChar = '\u0000';
            SenhaTB.Text = "Senha";
            ConfirmarSenhaTB.PasswordChar = '\u0000';
            ConfirmarSenhaTB.Text = "Confirmar senha";
            SenhaTB.BackColor = Color.FromArgb(255, 227, 255, 167);
            SenhaTB.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            ConfirmarSenhaTB.BackColor = Color.FromArgb(255, 227, 255, 167);
            ConfirmarSenhaTB.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
        }

        private void SenhaTB_TextChanged(object sender, EventArgs e)
        {
            if (!SenhaTB.Text.Equals("Senha"))
            {
                SenhaTB.PasswordChar = '*';
            }
        }

        private void ConfirmarSenhaTB_TextChanged(object sender, EventArgs e)
        {
            if (!ConfirmarSenhaTB.Text.Equals("Confirmar senha"))
            {
                ConfirmarSenhaTB.PasswordChar = '*';
            }
        }

        private void EnviarPB_Click(object sender, EventArgs e)
        {
            String aux = SenhaTB.Text;
            bool isM = false;
            bool hasNumber = false;
            for(int i = 0; i < aux.Length; i++)
            {
                if (int.TryParse(aux[i].ToString(), out _))
                {
                    hasNumber = true;
                }
                if (Char.IsUpper(aux[i])) isM=true;
            }

            if(!isM)
            {
                MessageBox.Show("A senha deve conter pelo menos uma letra maiuscula", "Senha não atende aos requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!hasNumber)
            {
                MessageBox.Show("A senha deve conter pelo menos um número", "Senha não atende aos requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(SenhaTB.Text.Length<8)
            {
                MessageBox.Show("A senha deve conter pelo menos 8 digitos", "Senha não atende aos requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(SenhaTB.Text!=ConfirmarSenhaTB.Text)
            {
                MessageBox.Show("As senhas estão divergentes", "Senha não atende aos requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SenhaTB.Text[0]=='#')
            {
                MessageBox.Show("A senha não pode iniciar com #", "Senha não atende aos requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Connection.AlterarSenha(CPF, SenhaTB.Text);
                MessageBox.Show("Senha alterada com sucesso", "Senha alterada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                voltar = true;
            }
        }

        private void CriarSenhaF_Activated(object sender, EventArgs e)
        {
            ActiveControl = CriarNovaSenhaPB;
        }

        private void SenhaTB_Enter(object sender, EventArgs e)
        {
            if (SenhaTB.Text == "Senha") SenhaTB.Text = "";
        }

        private void EnviarPB_MouseEnter(object sender, EventArgs e)
        {

        }

        private void EnviarPB_MouseLeave(object sender, EventArgs e)
        {

        }

        private void EnviarNovamenteT_Tick(object sender, EventArgs e)
        {

        }

        private void ConfirmarSenhaTB_Enter(object sender, EventArgs e)
        {
            if (ConfirmarSenhaTB.Text == "Confirmar Senha") ConfirmarSenhaTB.Text = "";
        }

        private void SenhaTB_Leave(object sender, EventArgs e)
        {
            if (SenhaTB.Text == "") SenhaTB.Text = "Senha";
        }

        private void ConfirmarSenhaTB_Leave(object sender, EventArgs e)
        {
            if (ConfirmarSenhaTB.Text == "") ConfirmarSenhaTB.Text = "Confirmar Senha";
        }
    }
}
