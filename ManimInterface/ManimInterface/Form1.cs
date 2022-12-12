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
using System.Diagnostics;

namespace ManimInterface
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog fdb = new FolderBrowserDialog();
        Process p = new Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void directoryLink_Click(object sender, EventArgs e)
        {
            fdb.ShowDialog();
            string link = fdb.SelectedPath;
            labelLink.Text = link;

        }

        private void CreateVideoButton_Click(object sender, EventArgs e)
        {
            p.Start();
        }
    }
}
