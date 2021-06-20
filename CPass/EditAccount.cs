using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CPass
{
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            if (Program.currAccountIndex == -1 || Program.currAccountIndex > Program.accountList.Count()) { this.Close(); }
            else
            {
                txtTitle.Text = Program.accountList[Program.currAccountIndex].title;
                txtUsername.Text = Program.accountList[Program.currAccountIndex].username;
                txtPassword.Text = Program.accountList[Program.currAccountIndex].password;
                txtNotes.Text = Program.accountList[Program.currAccountIndex].notes;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string path = @"..\Dependencies\Accounts.json";

            Program.accountList[Program.currAccountIndex].title = txtTitle.Text;
            Program.accountList[Program.currAccountIndex].username = txtUsername.Text;
            Program.accountList[Program.currAccountIndex].password = txtPassword.Text;
            Program.accountList[Program.currAccountIndex].notes = txtNotes.Text;

            string json = JsonConvert.SerializeObject(Program.accountList);
            File.WriteAllText(path, json);

            MessageBox.Show("Your " + Program.accountList[Program.currAccountIndex].title + " account has been successfully updated", "Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
