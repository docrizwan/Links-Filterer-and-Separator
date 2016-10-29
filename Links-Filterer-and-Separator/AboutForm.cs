using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Links_Filterer_and_Separator
{
    public partial class AboutForm : Form
    {
        private MainForm mainform;
        public AboutForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.mainform.Enabled = false;
            this.mainform.Cursor = Cursors.No;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainform.Enabled = true;
            this.mainform.Cursor = Cursors.Default;
        }
    }
}
