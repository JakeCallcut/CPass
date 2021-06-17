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

namespace CPass
{
    public partial class Vault : Form
    {
        public Vault()
        {
            InitializeComponent();
        }

        private void Vault_Load(object sender, EventArgs e)
        {
            string path = @"f:\Github repos\CPass\CPass\Dependencies\Accounts.txt\";
            if (!File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        string title = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (s.Substring(i, 1) == ",")
                            {
                                i = s.Length;
                            }
                            else
                            {
                                title = title + s.Substring(i, 1);
                            }
                        }
                        passlist.Items.Add(title);
                    }
                }
            }
            else
            {
                MessageBox.Show("Accounts.txt is missing", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
