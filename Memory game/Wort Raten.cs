using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Memory_game
{
    public partial class Wort_Raten : Form
    {
        List<string> words = new List<string>();
        string newText;
        int i = 0;
        int guessed = 0;

        public Wort_Raten()
        {
            InitializeComponent();
            //Setup();

        }
        //dsfsdfsd
//        private void KeyIsPressed(object sender, KeyPressEventArgs e)
//        {
//            if (e.KeyChar == (char)Keys.Enter)
//            {
//                if (words[i].ToLower() == textBox1.Text.ToLower())
//                {
//                    if (i < words.Count - 1)
//                    {
//                        MessageBox.Show("Correct!", "Moo Says: ");
//                        textBox1.Text = "";
//                        i += 1;
//                        newText = Scramble(words[i]);
//                        lblWord.Text = newText;
//                        lblInfo.Text = "Words: " + (i + 1) + " of " + words.Count;
//                        guessed = 0;
//                        lblGussed.Text = "Guessed: " + guessed + " times.";
//                    }
//                    else
//                    {
//                        lblWord.Text = "You Win, Well done";
//                        return;
//                    }
//                }
//                else
//                {
//                    guessed += 1;
//                    lblGussed.Text = "Guessed: " + guessed + " times.";
//                }
//                e.Handled = true;
//            }
//        }
//        private void Setup()
//        {
//            words = File.ReadLines("words.txt").ToList();
//            newText = Scramble(words[i]);
//            lblWord.Text = newText;
//            lblInfo.Text = "Words: " + (i + 1) + " of " + words.Count;
//        }
//        private string Scramble(string text)
//        {
//            return new string(text.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
//        }
    }
}