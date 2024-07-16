using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.panel1.Width < 564)
            {
                this.panel1.Size = new System.Drawing.Size(this.panel1.Width + 2, 5);
            }
            else
            {
                this.Close();
            }
        }
    }
}
