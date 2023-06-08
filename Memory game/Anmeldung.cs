using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Memory_game
{
    public partial class Anmeldung : Form
    {
        public SoundPlayer player;
        //anwar 
        public Anmeldung()//3laui
        {
            InitializeComponent();
            player = new SoundPlayer("Hintergrund-Sound.wav"); //wav form damit windows form den sound erkennt 
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Ben_An.Text == "")
                {
                    textBox_Ben_An.Text = "Geben Sie den Benutzernamen ein";
                    return;
                }

                textBox_Ben_An.ForeColor = Color.White;
                panel_Meldung_An.Visible = false;

            }
            catch { }
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox_Ben_An.SelectAll();
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {

                    return;
                }

                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
                panel_Meldung_An2.Visible = false;
            }
            catch { }

        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void Button_Anmelden_An_Click(object sender, EventArgs e)
        {
            
            if (textBox_Ben_An.Text == "Geben Sie den Benutzernamen ein" || string.IsNullOrEmpty(textBox_Ben_An.Text))
            {
                panel_Meldung_An.Visible = true;
                textBox_Ben_An.Focus();
                return;
            }

            if (textBox2.Text == "Geben Sie den Passwort ein" || string.IsNullOrEmpty(textBox2.Text))
            {
                panel_Meldung_An2.Visible = true;
                textBox2.Focus();
                return;
            }
            //
            //player.PlayLooping(); // Sound in einer Endlosschleife abspielen

            // Öffne Form2, da alle Eingabefelder nicht leer sind
            Spiel_Menü form2 = new Spiel_Menü();
            form2.Show();

            // Schließe Form1
            this.Hide();
        }


        private void whatsapp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://wa.me/qr/QSYEBURJ54PVM1 ");

        }

        private void Insta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)         //watss +insta
        {
            Process.Start("https://www.instagram.com/s_a_n_w_a_r_h/");
        }

        private void Zeit_Tick_An(object sender, EventArgs e)
        {
            label_Zeit_An.Text = DateTime.Now.ToString("hh:mm:ss");         //uhr
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Zeit_An.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Account_erstellen_Click(object sender, EventArgs e)
        {
            if (textBox_Benutzer_Acc.Text == "Geben Sie den Benutzernamen ein")
            {
                pnlNameER.Visible = true;
                textBox_Benutzer_Acc.Focus();
                return;
            }
            if (Passwort_Acc.Text == "Geben Sie den Passwort ein")
            {
                pnlPassER.Visible = true;
                Passwort_Acc.Focus();
                return;
            }
            if (textBox_Passwort2_Acc.Text == "Geben Sie den Passwort ein")
            {
                pnlPass2ER.Visible = true;
                textBox_Passwort2_Acc.Focus();
                return;

            }
        }

        private void TextBox8_Click(object sender, EventArgs e)
        {
            textBox_Benutzer_Acc.SelectAll();
        }

        private void TextBox7_Click(object sender, EventArgs e)
        {
            Passwort_Acc.SelectAll();
        }

        private void TextBox10_Click(object sender, EventArgs e)
        {
            textBox_Passwort2_Acc.SelectAll();
        }

        private void linkLabel_Anmelden_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAnmelden.Visible = true;
            pnlAnmelden.Dock = DockStyle.Fill;
            pnlLogo.Dock = DockStyle.Left;
            pnlAccount.Visible = false;
        }

        private void Account_erstellen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAccount.Visible = true;          
            pnlAccount.Dock = DockStyle.Fill;
            pnlAnmelden.Visible = false;
        }
    }
}
