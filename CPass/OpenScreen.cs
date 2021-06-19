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
    public partial class OpenScreen : Form
    {
        public OpenScreen()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var _vault = new Vault();
            _vault.Show();
            this.Hide();
        }

        private void OpenScreen_Load(object sender, EventArgs e)
        {

        }

        private void txtUserID_Click(object sender, EventArgs e)
        {
        }

        private void txtMaster_TextChanged(object sender, EventArgs e)
        {
            pnlPass.BackColor = Color.FromArgb(43, 129, 128);
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            pnlUsername.BackColor = Color.FromArgb(43, 129, 128);
        }
    }
}
