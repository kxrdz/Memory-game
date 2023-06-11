using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Memory_game
{
    public partial class Puzzle : Form
    {
        int Verbleibende_Zeit = 300;
        private bool spielGestartet = false;
        private int Index_leeren_Bildbox, versuche = 0;
        private List<Bitmap> Bilder_list = new List<Bitmap>();
        private Stopwatch Zeit = new Stopwatch();
        private bool pauseAktiviert = false;

        public Puzzle()
        {
            InitializeComponent();
            Bilder_list.AddRange(new Bitmap[]
            {
                Properties.Resources._21,
                Properties.Resources._22,
                Properties.Resources._23,
                Properties.Resources._24,
                Properties.Resources._25,
                Properties.Resources._26,
                Properties.Resources._27,
                Properties.Resources._28,
                Properties.Resources._29,
                Properties.Resources.Weiß
            });
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            Mischen();
        }

        private void Mischen()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 ist nicht vorhanden, da es das letzte Teil ist.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = Bilder_list[j];
                    if (j == 9)
                        Index_leeren_Bildbox = i; //Speicherung den Index der leeren Bildbox
                }
            } while (Gewinn_Prüfen());
        }

        private void pbx1_Click(object sender, EventArgs e)
        {
            if (!spielGestartet)
            {
                Puzzle_Verbliebende_Zeit.Start();
                spielGestartet = true;
            }

            if (!pauseAktiviert)
            {
                int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);

                if (Index_leeren_Bildbox != inPictureBoxIndex)
                {
                    List<int> FourBrothers = new List<int>(new int[]
                    {
                        ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1),
                        inPictureBoxIndex - 3,
                        (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1,
                        inPictureBoxIndex + 3
                    });

                    if (FourBrothers.Contains(Index_leeren_Bildbox))
                    {
                        PictureBox emptyPictureBox = (PictureBox)gbPuzzleBox.Controls[Index_leeren_Bildbox];
                        PictureBox clickedPictureBox = (PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex];

                        emptyPictureBox.Image = clickedPictureBox.Image;
                        clickedPictureBox.Image = Bilder_list[9];
                        Index_leeren_Bildbox = inPictureBoxIndex;

                        lb_gemachte_bew.Text = "Bewegungen gemacht: " + (++versuche);

                        if (Gewinn_Prüfen())
                        {
                            Puzzle_Verbliebende_Zeit.Stop();
                            (gbPuzzleBox.Controls[8] as PictureBox).Image = Bilder_list[8];
                            MessageBox.Show("Glückwunsch... : " + Zeit.Elapsed.ToString().Remove(8) +
                                "\nInsgesamt durchgeführte Bewegungen : " + versuche, "Puzzle");

                            versuche = 0;
                            lb_gemachte_bew.Text = "Bewegungen gemacht : 0";
                            label_verbleibende_Zeit_Puzzle.Text = "verbleibende Zeit: ";
                            Zeit.Reset();
                            lb_gemachte_bew.ResetText();
                            Mischen();
                        }
                    }
                }
            }
        }

        private bool Gewinn_Prüfen()
        {
            for (int i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != Bilder_list[i])
                    return false;
            }

            return true;
        }

        private void Button_Neu_Starten_Click(object sender, EventArgs e)
        {
            DialogResult JaoderNein = new DialogResult();

            if (label_verbleibende_Zeit_Puzzle.Text != "verbleibende Zeit: ")
            {
                JaoderNein = MessageBox.Show("Sind Sie sicher, dass Sie den Spiel  NEU STARTEN Wollen?", "Puzzle Spiel",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (JaoderNein == DialogResult.Yes || label_verbleibende_Zeit_Puzzle.Text == "verbleibende Zeit: ")
            {
                Mischen();
                Zeit.Reset();
                label_verbleibende_Zeit_Puzzle.Text = "verbleibende Zeit:";
                lb_gemachte_bew.Text = "Bewegungen Gemacht: 0";
                pauseAktiviert = false;
                btnPause.Text = "Pause";
                spielGestartet = false;
                versuche = 0;
            }
        }

        private void Puzzle_Verbliebende_Zeit_Tick(object sender, EventArgs e)
        {
            if (--Verbleibende_Zeit == 0) // reduzierung der Wert der Variablen um 1.
            {
                Puzzle_Verbliebende_Zeit.Enabled = !Puzzle_Verbliebende_Zeit.Enabled;
                label_verbleibende_Zeit_Puzzle.Text = "Die Zeit ist abgelaufen.";
                MessageBox.Show("DIE ZEIT IST UM \nVersuche es noch einmal :)", "Ende des Spiels");
            }
            else
                label_verbleibende_Zeit_Puzzle.Text = "verbleibende Zeit: " + Verbleibende_Zeit;
        }

        private void Button_Exit_Puzzle_Click(object sender, EventArgs e)
        {
            this.Close();
            Spiel_Menü form2 = new Spiel_Menü();
            form2.Show();
        }

        private void Anhalten_oder_fortsetzen(object sender, EventArgs e)
        {
            if (!spielGestartet)
                return;

            pauseAktiviert = !pauseAktiviert;

            if (pauseAktiviert)
            {
                Puzzle_Verbliebende_Zeit.Stop();
                btnPause.Text = "Fortsetzen";
            }
            else
            {
                Puzzle_Verbliebende_Zeit.Start();
                btnPause.Text = "Pause";
            }
        }
    }
}
