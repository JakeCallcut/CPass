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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var _account = new Account();
            _account.title = txtTitle.Text;
            _account.username = txtUsername.Text;
            _account.password = txtPassword.Text;
            _account.notes = txtNotes.Text;

            //Program.accountList[]
        }
    }
}
