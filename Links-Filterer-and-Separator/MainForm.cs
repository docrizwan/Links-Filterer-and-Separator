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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            /*
            // classic windows theme
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            */

            /*
            // disable windows theme
            FormBorderStyle = FormBorderStyle.None;
            */
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm(this);
            //Enabled = false;
            about.ShowDialog(this);
            
        }

        private void BtnInputFile_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
