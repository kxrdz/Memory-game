using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Dmo.Effect;

namespace Memory_game
{
    public partial class Spiel_Menü : Form
    {
        private SoundPlayer player;
        private MMDeviceEnumerator enumerator;  //NAudio.CoreAudioApi-Namespace
        private MMDevice device;

        public Spiel_Menü()
        {
            InitializeComponent();
            pnlHighscore.Visible = false;
            pnlInfo.Visible = false;
            pnlSpielen.Visible = false;
            pnlEinstellung.Visible = false;


            player = new SoundPlayer("Hintergrund-Sound.wav");
            enumerator = new MMDeviceEnumerator();
            device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia); //MMDeviceEnumerator- und MMDevice-Objekt


            //device-Objekt

            _lbl_Hs_Puzzel.Text = Anmeldung.DM.ds.Tables["User"].Rows[0][3].ToString();
            _lbl_Hs_Karten.Text = Anmeldung.DM.ds.Tables["User"].Rows[0][2].ToString();
            _lbl_Hs_wort.Text = Anmeldung.DM.ds.Tables["User"].Rows[0][4].ToString();
        }

        private void Button_Exit_Spiel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Exit_Spiel_Highscore_Click(object sender, EventArgs e)
        {
            this.Close();
            Spiel_Menü form2 = new Spiel_Menü();
            form2.Show();
        }

        private void Button_Exit_Spiel_Fenster_Click(object sender, EventArgs e)
        {
            this.Close();
            Spiel_Menü form2 = new Spiel_Menü();
            form2.Show();

            //this.WindowState = FormWindowState.Normal;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
            Spiel_Menü form2 = new Spiel_Menü();
            form2.Show();
        }

        private void Button_Exit_Spiel_Info_Click(object sender, EventArgs e)
        {
            this.Close();
            Spiel_Menü form2 = new Spiel_Menü();
            form2.Show();
        }

        private void Button_Einstellung_Spiel_Click(object sender, EventArgs e)
        {
            pnlEinstellung.Visible = true;
            pnlEinstellung.Dock = DockStyle.Fill;
            pnlHighscore.Visible = false;
            pnlInfo.Visible = false;
            pnlSpielen.Visible = false;
        }

        private void Button_Spielen_Spiel_Click(object sender, EventArgs e)//
        {
            pnlSpielen.Visible = true;
            pnlSpielen.Dock = DockStyle.Fill;
            pnlHighscore.Visible = false;
            pnlInfo.Visible = false;
            pnlEinstellung.Visible = false;
        }

        private void Button_Highscore_Spiel_Click(object sender, EventArgs e)
        {
            pnlHighscore.Visible = true;
            pnlHighscore.Dock = DockStyle.Fill;
            pnlInfo.Visible = false;
            pnlSpielen.Visible = false;
            pnlEinstellung.Visible = false;
        }

        private void Button_Info_Spiel_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = true;
            pnlInfo.Dock = DockStyle.Fill;
            pnlHighscore.Visible = false;
            pnlEinstellung.Visible = false;
            pnlSpielen.Visible = false;
        }

        private void Button_AB_Spiel_Einstellung_Click(object sender, EventArgs e)
        {
            player.Stop(); // Sound stoppen, wenn das Formular geschlossen wird
            this.Close();
            Anmeldung form1 = new Anmeldung();
            form1.Show();
        }

        private void Button_Sound_Max_Click(object sender, EventArgs e) // Max
        {
            SetVolume(1.0f);
        }

        private void Button_Sound_Mittel_Click(object sender, EventArgs e) // Mittel
        {
            SetVolume(0.3f);
        }

        private void Button_Sound_Null_Click(object sender, EventArgs e) // Lautlos
        {
            SetVolume(0.0f);
        }

        private void SetVolume(float volume)
        {
            device.AudioEndpointVolume.MasterVolumeLevelScalar = volume; //Sound Einstellung
        }

        private void Karten_Spiel_Logo_Click(object sender, EventArgs e)
        {
            Kartenpaare_suchen form3 = new Kartenpaare_suchen();
            form3.Show();
        }

        private void Puzzle_Spiel_Logo_Click(object sender, EventArgs e)
        {
            Puzzle form4 = new Puzzle();
            form4.Show();
        }

        private void Zeit_Spiel_Tick(object sender, EventArgs e)
        {
            label_Zeit_Spiel.Text = DateTime.Now.ToString("hh:mm:ss");         //uhr
        }

        private void Spiel_Menü_Load(object sender, EventArgs e)
        {
            Zeit_Spiel.Start();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Wort_Raten wort_Raten = new Wort_Raten();
            wort_Raten.Show();
        }
    }
}
