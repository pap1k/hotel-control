using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursuch
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Form1.isAdminFormActive = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1.isAdminFormActive = false;
            this.Close();
        }
    }
}
