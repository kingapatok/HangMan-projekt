using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace HangMan
{
    public partial class Form2 : Form
    {
        private Bitmap[] hangImages =  {HangMan.Properties.Resources.HangMan1, HangMan.Properties.Resources.HangMan2,
                                        HangMan.Properties.Resources.HangMan3, HangMan.Properties.Resources.HangMan4,
                                        HangMan.Properties.Resources.HangMan5, HangMan.Properties.Resources.HangMan6,
                                        HangMan.Properties.Resources.HangMan7};
        
        private int wrongGuesses = 0;
        private string current = "";
        private string copyCurrent = "-";
        private string[] words;
        public Form2()
        {
            InitializeComponent();
        }
        private void loadwords()
        {   //załączenie listy słów
            char[] delimiterChars = {','};
            string[] readText = File.ReadAllLines("słowa.txt");
            words = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                words[index++] = line[0];
            }
          
        }

        private void setupWordChoice()
        {   // zasada działania wyboru litery
            wrongGuesses = 0;
            hangImage.Image = hangImages[wrongGuesses];
            int guessIndex = (new Random()).Next(words.Length);
            current = words[guessIndex];

            copyCurrent = "";
            for (int index = 0; index < current.Length; )
            {
                copyCurrent += "_";
            }
            displayCopy();

        }
        private  void displayCopy()
        {
            lblShowWord.Text = "";
            for (int index = 0; index < copyCurrent.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index,1);
                lblShowWord.Text += " ";
            }
        }
        private void updateCopy(char guess)
        {

        }

        private void guessClick(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled =false;
            if (current.Contains(choice.Text))
            {
                
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);
                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();
            }
            else
            {
                wrongGuesses++;
            }

           // wrongGuesses++; //zmienia obrazek na kolejny
            if (wrongGuesses < 7)
            {
                hangImage.Image = hangImages[wrongGuesses];
            }
            else //komentuje rezultat
            {
                lblResult.Text = "Przegrana";
            }

            if (copyCurrent.Equals(current))
            {
                lblResult.Text = "WYGRANA!";
            }
        }

        private void hangImage_Click(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoice();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Application.Exit() ;
            
        }
    }
}
