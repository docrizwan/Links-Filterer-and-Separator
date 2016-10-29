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
            FileChooser.InitialDirectory = @"C:\.."; // "Documents" directory
            FileChooser.Title = "Select simple text file (*.txt) ...";
            FileChooser.Filter = "Text File (*.txt) | *.txt";

            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm(this);
            //Enabled = false;
            about.ShowDialog(this);
            
        }

        private void BtnInputFile_Click(object sender, EventArgs e)
        {
            BtnInputFolder.Enabled = false;
            InputFolder.Font = new Font(InputFolder.Font.Name, InputFolder.Font.SizeInPoints, FontStyle.Strikeout);

            if (FileChooser.ShowDialog() == DialogResult.OK)
            {
                //FileFilterer(FileChooser.FileName);

            }
            else
            {
                BtnInputFolder.Enabled = true;
                //InputFolder.ResetText();
                InputFolder.Font = new Font(InputFolder.Font.Name, InputFolder.Font.SizeInPoints, FontStyle.Bold);
                /*
                var userchoice = MessageBox.Show("Some error happened.", "Wrong File", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
                if (userchoice == DialogResult.Retry)
                {

                }
                else if(userchoice == DialogResult.Cancel)
                {
                    
                }
                */
            }


            /*
            foreach (var item in OutputFilesEnum.AllConstants)
            {
                Console.WriteLine("Key: {0}, \t\tValue: {1}", item.Key, item.Value);
            }
            */
            //InputFile.Text = OutputFilesEnum.GetFileName(OutputFilesEnum.OutputFiles.LinksGoogle).ToString();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //BtnInputFile.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            BtnInputFile.TabStop = false;
            BtnInputFolder.TabStop = false;
            BtnOutputFolder.TabStop = false;
            Submit.TabStop = false;
            AddToFile.TabStop = false;
        }

        
        private void FileFilterer()
        {
            if (FileChooser.FileName != null)
            {

            }
            
        }

        private void BtnInputFolder_Click(object sender, EventArgs e)
        {
            BtnInputFile.Enabled = false;
            InputFile.Font = new Font(InputFile.Font.Name, InputFile.Font.SizeInPoints, FontStyle.Strikeout);
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                BtnInputFile.Enabled = true;
                //InputFile.ResetText();
                InputFile.Font = new Font(InputFile.Font.Name, InputFile.Font.SizeInPoints, FontStyle.Bold);
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            if(FileChooser.FileName != null && FolderBrowser.SelectedPath == null)
            {

            }
            else if (FileChooser.FileName == null && FolderBrowser.SelectedPath != null)
            {

            }
            else
            {
                Enabled = false;
                var userchoice = MessageBox.Show("You must choose a file or folder as input.\n (Only *.txt files are allowed)", "z", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                if(userchoice == DialogResult.Retry)
                {
                    Enabled = true;
                }
                else if (userchoice == DialogResult.Cancel)
                {
                    Dispose();
                    Close();
                }
            }
        }
    }
}
