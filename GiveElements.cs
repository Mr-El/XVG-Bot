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
    public partial class GiveElements : Form
    {
        public GiveElements()
        {
            InitializeComponent();
        }

        private void addMiner_Click(object sender, EventArgs e)
        {
            
            int addMinerName = 0;
            if (addMinerName == 0)
            {
                ++addMinerName;
            }
            else if (addMinerName == 1)
            {
                minerName2.Visible = true;
            }

            int elementNameAdd = 0;
            ++elementNameAdd;
            switch (elementNameAdd) {
                case 0:
                    break;
                case 1:
                    element2.Visible = true;
                    break;
                case 2:
                    element3.Visible = true;
                    break;
            }
            
        }
    }
}
