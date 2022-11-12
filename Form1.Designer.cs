namespace WordProcessor3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openNotepadButton = new System.Windows.Forms.Button();
            this.closeNotepadButton = new System.Windows.Forms.Button();
            this.notepadProcess = new System.Diagnostics.Process();
            this.wordProcess = new System.Diagnostics.Process();
            this.openWordButton = new System.Windows.Forms.Button();
            this.closeWordButton = new System.Windows.Forms.Button();
            this.openChromeButton = new System.Windows.Forms.Button();
            this.closeChromeButton = new System.Windows.Forms.Button();
            this.programsGroupBox = new System.Windows.Forms.GroupBox();
            this.addScheduleButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chromeProcess = new System.Diagnostics.Process();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.programsGroupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openNotepadButton
            // 
            this.openNotepadButton.Location = new System.Drawing.Point(7, 32);
            this.openNotepadButton.Name = "openNotepadButton";
            this.openNotepadButton.Size = new System.Drawing.Size(106, 23);
            this.openNotepadButton.TabIndex = 0;
            this.openNotepadButton.Text = "Open Notepad";
            this.openNotepadButton.UseVisualStyleBackColor = true;
            this.openNotepadButton.Click += new System.EventHandler(this.openNotepadButton_Click);
            // 
            // closeNotepadButton
            // 
            this.closeNotepadButton.Location = new System.Drawing.Point(119, 32);
            this.closeNotepadButton.Name = "closeNotepadButton";
            this.closeNotepadButton.Size = new System.Drawing.Size(121, 23);
            this.closeNotepadButton.TabIndex = 1;
            this.closeNotepadButton.Text = "Close Notepad";
            this.closeNotepadButton.UseVisualStyleBackColor = true;
            this.closeNotepadButton.Click += new System.EventHandler(this.closeNotepadButton_Click);
            // 
            // notepadProcess
            // 
            this.notepadProcess.StartInfo.Domain = "";
            this.notepadProcess.StartInfo.FileName = "notepad.exe";
            this.notepadProcess.StartInfo.LoadUserProfile = false;
            this.notepadProcess.StartInfo.Password = null;
            this.notepadProcess.StartInfo.StandardErrorEncoding = null;
            this.notepadProcess.StartInfo.StandardOutputEncoding = null;
            this.notepadProcess.StartInfo.UserName = "";
            this.notepadProcess.SynchronizingObject = this;
            // 
            // wordProcess
            // 
            this.wordProcess.StartInfo.Domain = "";
            this.wordProcess.StartInfo.FileName = "Winword.exe";
            this.wordProcess.StartInfo.LoadUserProfile = false;
            this.wordProcess.StartInfo.Password = null;
            this.wordProcess.StartInfo.StandardErrorEncoding = null;
            this.wordProcess.StartInfo.StandardOutputEncoding = null;
            this.wordProcess.StartInfo.UserName = "";
            this.wordProcess.SynchronizingObject = this;
            // 
            // openWordButton
            // 
            this.openWordButton.Location = new System.Drawing.Point(7, 76);
            this.openWordButton.Name = "openWordButton";
            this.openWordButton.Size = new System.Drawing.Size(106, 23);
            this.openWordButton.TabIndex = 2;
            this.openWordButton.Text = "Open Word";
            this.openWordButton.UseVisualStyleBackColor = true;
            this.openWordButton.Click += new System.EventHandler(this.openWordButton_Click);
            // 
            // closeWordButton
            // 
            this.closeWordButton.Location = new System.Drawing.Point(119, 76);
            this.closeWordButton.Name = "closeWordButton";
            this.closeWordButton.Size = new System.Drawing.Size(121, 23);
            this.closeWordButton.TabIndex = 3;
            this.closeWordButton.Text = "Close Word";
            this.closeWordButton.UseVisualStyleBackColor = true;
            this.closeWordButton.Click += new System.EventHandler(this.closeWordButton_Click);
            // 
            // openChromeButton
            // 
            this.openChromeButton.Location = new System.Drawing.Point(7, 119);
            this.openChromeButton.Name = "openChromeButton";
            this.openChromeButton.Size = new System.Drawing.Size(106, 23);
            this.openChromeButton.TabIndex = 4;
            this.openChromeButton.Text = "Open Chrome";
            this.openChromeButton.UseVisualStyleBackColor = true;
            this.openChromeButton.Click += new System.EventHandler(this.openChromeButton_Click);
            // 
            // closeChromeButton
            // 
            this.closeChromeButton.Location = new System.Drawing.Point(120, 119);
            this.closeChromeButton.Name = "closeChromeButton";
            this.closeChromeButton.Size = new System.Drawing.Size(120, 23);
            this.closeChromeButton.TabIndex = 5;
            this.closeChromeButton.Text = "Close Chrome";
            this.closeChromeButton.UseVisualStyleBackColor = true;
            this.closeChromeButton.Click += new System.EventHandler(this.closeChromeButton_Click);
            // 
            // programsGroupBox
            // 
            this.programsGroupBox.Controls.Add(this.closeChromeButton);
            this.programsGroupBox.Controls.Add(this.openChromeButton);
            this.programsGroupBox.Controls.Add(this.closeWordButton);
            this.programsGroupBox.Controls.Add(this.openWordButton);
            this.programsGroupBox.Controls.Add(this.closeNotepadButton);
            this.programsGroupBox.Controls.Add(this.openNotepadButton);
            this.programsGroupBox.Location = new System.Drawing.Point(863, 247);
            this.programsGroupBox.Name = "programsGroupBox";
            this.programsGroupBox.Size = new System.Drawing.Size(248, 168);
            this.programsGroupBox.TabIndex = 6;
            this.programsGroupBox.TabStop = false;
            this.programsGroupBox.Text = "Call Programs";
            // 
            // addScheduleButton
            // 
            this.addScheduleButton.Location = new System.Drawing.Point(900, 197);
            this.addScheduleButton.Name = "addScheduleButton";
            this.addScheduleButton.Size = new System.Drawing.Size(184, 23);
            this.addScheduleButton.TabIndex = 7;
            this.addScheduleButton.Text = "Add Schedule to Array";
            this.addScheduleButton.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1123, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(534, 361);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // chromeProcess
            // 
            this.chromeProcess.StartInfo.Domain = "";
            this.chromeProcess.StartInfo.FileName = "chrome.exe";
            this.chromeProcess.StartInfo.LoadUserProfile = false;
            this.chromeProcess.StartInfo.Password = null;
            this.chromeProcess.StartInfo.StandardErrorEncoding = null;
            this.chromeProcess.StartInfo.StandardOutputEncoding = null;
            this.chromeProcess.StartInfo.UserName = "";
            this.chromeProcess.SynchronizingObject = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(878, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "I am available on"});
            this.comboBox1.Location = new System.Drawing.Point(728, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Select One"});
            this.comboBox2.Location = new System.Drawing.Point(601, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.addScheduleButton);
            this.Controls.Add(this.programsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.programsGroupBox.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openNotepadButton;
        private System.Windows.Forms.Button closeNotepadButton;
        private System.Diagnostics.Process notepadProcess;
        private System.Diagnostics.Process wordProcess;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Button addScheduleButton;
        private System.Windows.Forms.GroupBox programsGroupBox;
        private System.Windows.Forms.Button closeChromeButton;
        private System.Windows.Forms.Button openChromeButton;
        private System.Windows.Forms.Button closeWordButton;
        private System.Windows.Forms.Button openWordButton;
        private System.Diagnostics.Process chromeProcess;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

