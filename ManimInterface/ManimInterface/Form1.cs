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
using IronPython;

namespace ManimInterface
{
    public partial class Form1 : Form
    {
        string link = String.Empty;
        Process p = new Process();
        FolderBrowserDialog fdb = new FolderBrowserDialog();
        ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
        public Form1()
        {
            InitializeComponent();
        }

        private void directoryLink_Click(object sender, EventArgs e)
        {
            SaveLink(ref link);
        }

        private void CreateVideoButton_Click(object sender, EventArgs e)
        {
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $@"/c cd {link} /manim -pqh .\main.py Example";
            startInfo.CreateNoWindow = true;
            Process.Start(startInfo);
            
        }

        private void pythonFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadLink()
        {

        }
        public void SaveLink(ref string result)
        {
            try
            {
                fdb.ShowDialog();
                result = fdb.SelectedPath;
                labelLink.Text = result;
                var dirs = new DirectoryInfo(result);
                FileInfo[] files = dirs.GetFiles();
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in files)
                    {
                        PythonFiles python = new PythonFiles(f.Name);
                        ListViewItem item = new ListViewItem(python.FileName);
                        item.Tag = python;
                        pythonFiles.Items.Add(f.Name);
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Недопустимый путь файла");
            }
        }
    }
}
