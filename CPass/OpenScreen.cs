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
            this.Close();
        }
    }
}
