namespace Links_Filterer_and_Separator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputFile = new System.Windows.Forms.Label();
            this.InputFolder = new System.Windows.Forms.Label();
            this.OutputFolder = new System.Windows.Forms.Label();
            this.BtnInputFile = new System.Windows.Forms.Button();
            this.BtnInputFolder = new System.Windows.Forms.Button();
            this.BtnOutputFolder = new System.Windows.Forms.Button();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputFile
            // 
            this.InputFile.AutoSize = true;
            this.InputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFile.Location = new System.Drawing.Point(12, 46);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(67, 15);
            this.InputFile.TabIndex = 0;
            this.InputFile.Text = "Input File";
            // 
            // InputFolder
            // 
            this.InputFolder.AutoSize = true;
            this.InputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFolder.Location = new System.Drawing.Point(12, 83);
            this.InputFolder.Name = "InputFolder";
            this.InputFolder.Size = new System.Drawing.Size(84, 15);
            this.InputFolder.TabIndex = 1;
            this.InputFolder.Text = "Input Folder";
            // 
            // OutputFolder
            // 
            this.OutputFolder.AutoSize = true;
            this.OutputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFolder.Location = new System.Drawing.Point(12, 148);
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.Size = new System.Drawing.Size(94, 15);
            this.OutputFolder.TabIndex = 2;
            this.OutputFolder.Text = "Output Folder";
            // 
            // BtnInputFile
            // 
            this.BtnInputFile.Location = new System.Drawing.Point(132, 43);
            this.BtnInputFile.Name = "BtnInputFile";
            this.BtnInputFile.Size = new System.Drawing.Size(75, 23);
            this.BtnInputFile.TabIndex = 3;
            this.BtnInputFile.Text = "Browse...";
            this.BtnInputFile.UseVisualStyleBackColor = true;
            this.BtnInputFile.Click += new System.EventHandler(this.BtnInputFile_Click);
            // 
            // BtnInputFolder
            // 
            this.BtnInputFolder.Location = new System.Drawing.Point(132, 80);
            this.BtnInputFolder.Name = "BtnInputFolder";
            this.BtnInputFolder.Size = new System.Drawing.Size(75, 23);
            this.BtnInputFolder.TabIndex = 4;
            this.BtnInputFolder.Text = "Browse...";
            this.BtnInputFolder.UseVisualStyleBackColor = true;
            // 
            // BtnOutputFolder
            // 
            this.BtnOutputFolder.Location = new System.Drawing.Point(132, 145);
            this.BtnOutputFolder.Name = "BtnOutputFolder";
            this.BtnOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.BtnOutputFolder.TabIndex = 5;
            this.BtnOutputFolder.Text = "Browse...";
            this.BtnOutputFolder.UseVisualStyleBackColor = true;
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(229, 24);
            this.MenuBar.TabIndex = 6;
            this.MenuBar.Text = "Menu Bar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 195);
            this.Controls.Add(this.BtnOutputFolder);
            this.Controls.Add(this.BtnInputFolder);
            this.Controls.Add(this.BtnInputFile);
            this.Controls.Add(this.OutputFolder);
            this.Controls.Add(this.InputFolder);
            this.Controls.Add(this.InputFile);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Links Separator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputFile;
        private System.Windows.Forms.Label InputFolder;
        private System.Windows.Forms.Label OutputFolder;
        private System.Windows.Forms.Button BtnInputFile;
        private System.Windows.Forms.Button BtnInputFolder;
        private System.Windows.Forms.Button BtnOutputFolder;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

