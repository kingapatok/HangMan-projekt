using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form2 : Form
    {
        private Bitmap[] hangImages =  {HangMan.Properties.Resources.HangMan1, HangMan.Properties.Resources.HangMan2,
                                        HangMan.Properties.Resources.HangMan3, HangMan.Properties.Resources.HangMan4,
                                        HangMan.Properties.Resources.HangMan5, HangMan.Properties.Resources.HangMan6,
                                        HangMan.Properties.Resources.HangMan7};

        public Form2()
        {
            InitializeComponent();
        }

        private void guessClick(object sender, EventArgs e)
        {
            
        }
    }
}
