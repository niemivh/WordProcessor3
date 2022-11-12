using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordProcessor3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openNotepadButton_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("notepad");
            if (processes.Length == 0)
            {
                notepadProcess.EnableRaisingEvents = true;
                notepadProcess.Start();
            }
            else
            {
                MessageBox.Show("Notepad is already running");
            }
        }

        private void closeNotepadButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("notepad");
                if (processes.Length != 0)
                {
                    notepadProcess.Kill();
                }
                else
                {
                    MessageBox.Show("Notepad is not running");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Notepad is running outside of program");
            }
            
        }

        private void openChromeButton_Click(object sender, EventArgs e)
        {

            Process[] processes = Process.GetProcessesByName("chrome");
            if (processes.Length == 0)
            {
                chromeProcess.EnableRaisingEvents = true;
                chromeProcess.Start();
            }
            else
            {
                MessageBox.Show("Chrome is already running");
            }
        }

        private void closeChromeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("chrome");
                if (processes.Length != 0)
                {
                    chromeProcess.Kill();
                }
                else
                {
                    MessageBox.Show("Chrome is not running");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Chrome open outside of program.");
            }
            
        }

        private void openWordButton_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("winword");
            if (processes.Length == 0)
            {
                wordProcess.EnableRaisingEvents = true;
                wordProcess.Start();
            }
            else
            {
                MessageBox.Show("Word is already running");
            }
           
        }

        private void closeWordButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("winword");
                if (processes.Length != 0)
                {
                    wordProcess.Kill();
                }
                else
                {
                    MessageBox.Show("Word is not running");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Word is running outside of program");
            }
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            {

                
                
            }
    }
}
