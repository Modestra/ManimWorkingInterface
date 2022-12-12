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
        FolderBrowserDialog fdb = new FolderBrowserDialog();
        ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
        public Form1()
        {
            InitializeComponent();
        }

        private void directoryLink_Click(object sender, EventArgs e)
        {
            try
            {
                fdb.ShowDialog();
                string link = fdb.SelectedPath;
                labelLink.Text = link;
                var dirs = new DirectoryInfo(link);
                FileInfo[] files = dirs.GetFiles("*.py");
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in files)
                    {
                        PythonFiles python = new PythonFiles(f.Name);
                        ListViewItem item = new ListViewItem(python.FileName);
                        item.Tag = python;
                        pythonFiles.Items.Add(item);
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

        private void CreateVideoButton_Click(object sender, EventArgs e)
        {
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c python";
            Process.Start(startInfo);
        }

        private void pythonFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Тут должно быть открытие файла и поиск там всех классов
        }
    }
}
