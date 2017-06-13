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

namespace HangMan
{
    public partial class Form2 : Form
    {
        private Bitmap[] hangImages =  {HangMan.Properties.Resources.HangMan1, HangMan.Properties.Resources.HangMan2,
                                        HangMan.Properties.Resources.HangMan3, HangMan.Properties.Resources.HangMan4,
                                        HangMan.Properties.Resources.HangMan5, HangMan.Properties.Resources.HangMan6,
                                        HangMan.Properties.Resources.HangMan7};

        private int wrongGuess = 0;
        private string current = "";
        private string copyCurrent = "";
        private string[] words;
        public Form2()
        {
            InitializeComponent();
        }
        private void loadwords()
        { //załączenie listy słów
            char[] delimiterChars = {','};
            string[] readText = File.ReadAllLines("słowa.txt");
            words = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                words[index++] = line[1];
            }
          
        }

        private void setupWordChoice()
        {
            wrongGuess = 0;
            hangImage.Image = hangImages[wrongGuess];
            int guessIndex = (new Random()).Next(words.Length); 
            current = words[guessIndex];

            copyCurrent = "";
            for (int index = 0; index < current.Length; index++)
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
            wrongGuess++; //zmienia obrazek na kolejny
            if (wrongGuess < 7)
            {
                hangImage.Image = hangImages[wrongGuess];
            }
            else
            {
                lblResult.Text = "Przegrana";
            }
        }

        private void hangImage_Click(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoice();
        }
    }
}
