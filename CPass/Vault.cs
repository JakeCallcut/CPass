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
using Newtonsoft.Json;


namespace CPass
{
    public partial class Vault : Form
    {
        public Vault()
        {
            InitializeComponent();
        }

        List<Account> accountList = new List<Account>();        

        private void Vault_Load(object sender, EventArgs e)
        {
            string path = @"f:\Github repos\CPass\CPass\Dependencies\Accounts.json";
            LoadJson(path);

            using (StreamReader sr = File.OpenText(path))
            {
                for (int i = 0; i < accountList.Count; i++)
                {
                    passlist.Items.Add(accountList[i].title);
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _passGen = new PassGen();
            _passGen.Show();
        }

        private void lockVault_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Lock Vault?");
            Application.Exit();
        }

        private void passlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void LoadJson(string _path)
        {
            using (StreamReader r = new StreamReader(_path))
            {
                string json = r.ReadToEnd();
                accountList = JsonConvert.DeserializeObject<List<Account>>(json);
            }
        }
    }
}
