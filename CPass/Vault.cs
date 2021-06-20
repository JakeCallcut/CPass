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

        private void Vault_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (passlist.SelectedIndex == -1 || passlist.SelectedIndex > Program.accountList.Count()) { }
            else
            {
                int selectedIndex = passlist.SelectedIndex;
                Clipboard.SetText(Program.accountList[selectedIndex].password);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _passGen = new PassGen();
            _passGen.Show();
        }

        private void lockVault_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Are you sure?", "Lock Vault?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void passlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (passlist.SelectedIndex == -1 || passlist.SelectedIndex > Program.accountList.Count()) { }
            else
            {
                accountinfo.Items.Clear();
                int selectedIndex = passlist.SelectedIndex;

                accountinfo.Items.Add(Program.accountList[selectedIndex].title);
                accountinfo.Items.Add("");
                accountinfo.Items.Add(Program.accountList[selectedIndex].username);
                accountinfo.Items.Add("");

                string hiddenPass = "";
                for (int i = 0; i < Program.accountList[selectedIndex].password.Length; i++)
                {
                    hiddenPass += "*";  
                }

                accountinfo.Items.Add(hiddenPass);

                if (Program.accountList[selectedIndex].notes == "") { }
                else
                {
                    accountinfo.Items.Add("");
                    accountinfo.Items.Add("Notes:");
                    accountinfo.Items.Add(Program.accountList[selectedIndex].notes);
                }
            }

        }

        public void LoadAccounts(string _path)
        {
            using (StreamReader r = new StreamReader(_path))
            {
                string json = r.ReadToEnd();
                Program.accountList = JsonConvert.DeserializeObject<List<Account>>(json);
            }
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if (passlist.SelectedIndex == -1 || passlist.SelectedIndex > Program.accountList.Count()) { }
            else
            {
                accountinfo.Items.Clear();
                int selectedIndex = passlist.SelectedIndex;

                accountinfo.Items.Add(Program.accountList[selectedIndex].title);
                accountinfo.Items.Add("");
                accountinfo.Items.Add(Program.accountList[selectedIndex].username);
                accountinfo.Items.Add("");
                accountinfo.Items.Add(Program.accountList[selectedIndex].password);

                if (Program.accountList[selectedIndex].notes == "") { }
                else
                {
                    accountinfo.Items.Add("");
                    accountinfo.Items.Add("Notes:");
                    accountinfo.Items.Add(Program.accountList[selectedIndex].notes);
                }
            }
        }

        private void copyUser_Click(object sender, EventArgs e)
        {
            if (passlist.SelectedIndex == -1 || passlist.SelectedIndex > Program.accountList.Count()) { }
            else
            {
                int selectedIndex = passlist.SelectedIndex;
                Clipboard.SetText(Program.accountList[selectedIndex].username);
            }
        }

        private void addAccount_Click(object sender, EventArgs e)
        {
            var _addAccount = new AddAccount();
            _addAccount.Show();
        }

        private void Vault_Activated(object sender, EventArgs e)
        {
            passlist.Items.Clear();
            string path = @"..\Dependencies\Accounts.json";
            LoadAccounts(path);

            using (StreamReader sr = File.OpenText(path))
            {
                for (int i = 0; i < Program.accountList.Count; i++)
                {
                    passlist.Items.Add(Program.accountList[i].title);
                }
            }
        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {

            if (passlist.SelectedIndex == -1 || passlist.SelectedIndex > Program.accountList.Count()) { }
            else
            {
                string path = @"..\Dependencies\Accounts.json";
                var selectedAcc = Program.accountList[passlist.SelectedIndex];

                Program.accountList.RemoveAt(passlist.SelectedIndex);        
                string json = JsonConvert.SerializeObject(Program.accountList);
                File.WriteAllText(path, json);

                MessageBox.Show("Your " + selectedAcc.title + " account has been successfully deleted", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editAccount_Click(object sender, EventArgs e)
        {
            Program.currAccountIndex = passlist.SelectedIndex;
            var _edit = new EditAccount();
            _edit.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
