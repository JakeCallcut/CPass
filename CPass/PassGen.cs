using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPass
{
    public partial class PassGen : Form
    {
        public PassGen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            char[] symbolsArray = { '!', '@', '*', '&', '#', '$', '^' };
            bool capitals; //1
            bool lowercase; //2
            bool numbers; //3
            bool symbols; //4
            int passLength;
            string password = "";

                if (optCapitals.Checked) { capitals = true; }
                else { capitals = false; }

                if (optLower.Checked) { lowercase = true; }
                else { lowercase = false; }

                if (optNumbers.Checked) { numbers = true; }
                else { numbers = false; }

                if (optSymbols.Checked) { symbols = true; }
                else { symbols = false; }

                passLength = barLength.Value;

            var rand = new Random();

            while (password.Length < passLength)
            {
                int nextChar = rand.Next(1, 4);
                if (nextChar == 1 && capitals == true)
                {
                   
                }
                else if (nextChar == 2 && lowercase == true)
                {

                }
                else if (nextChar == 3 && numbers == true)
                {
                    password = password + Convert.ToString(rand.Next(0, 9));
                }
                else if (nextChar == 4 && symbols == true)
                {
                    password = password + symbolsArray[rand.Next(0, 6)];
                }
            }


        }

        private void barLength_Scroll(object sender, EventArgs e){ lblLength.Text = Convert.ToString(barLength.Value); }
    }
}
