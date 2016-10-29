namespace Links_Filterer_and_Separator
{
    partial class AboutForm
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
            this.AboutText1 = new System.Windows.Forms.Label();
            this.AboutText2 = new System.Windows.Forms.Label();
            this.AboutText3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutText1
            // 
            this.AboutText1.AutoSize = true;
            this.AboutText1.Location = new System.Drawing.Point(12, 9);
            this.AboutText1.Name = "AboutText1";
            this.AboutText1.Size = new System.Drawing.Size(190, 13);
            this.AboutText1.TabIndex = 0;
            this.AboutText1.Text = "This takes a text file (*.txt) or a folder of";
            // 
            // AboutText2
            // 
            this.AboutText2.AutoSize = true;
            this.AboutText2.Location = new System.Drawing.Point(12, 37);
            this.AboutText2.Name = "AboutText2";
            this.AboutText2.Size = new System.Drawing.Size(214, 13);
            this.AboutText2.TabIndex = 1;
            this.AboutText2.Text = "of files and an output folder. And filters links.";
            // 
            // AboutText3
            // 
            this.AboutText3.AutoSize = true;
            this.AboutText3.Location = new System.Drawing.Point(12, 69);
            this.AboutText3.Name = "AboutText3";
            this.AboutText3.Size = new System.Drawing.Size(79, 13);
            this.AboutText3.TabIndex = 2;
            this.AboutText3.Text = "and filters links.";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 195);
            this.Controls.Add(this.AboutText3);
            this.Controls.Add(this.AboutText2);
            this.Controls.Add(this.AboutText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutForm_FormClosed);
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutText1;
        private System.Windows.Forms.Label AboutText2;
        private System.Windows.Forms.Label AboutText3;
    }
}