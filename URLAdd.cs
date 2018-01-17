using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XVG_Bot
{
    public partial class URLAdd : Form
    {
        public URLAdd()
        {
            InitializeComponent();
        }

        GetHTML linkto = new GetHTML();
        private void URLGo_Click(object sender, EventArgs e)
        {
            if (txtURL.Text != null)
            {
            }
            else
            {
                MessageBox.Show("A URL must be added or close this window!", "URL Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
