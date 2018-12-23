// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ImageSorter
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

            groupBoxIn.AllowDrop = true;
            groupBoxOut.AllowDrop = true;
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxIn.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOut.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void groupBoxIn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
            e.Effect = DragDropEffects.Move;
        }

        private void groupBoxIn_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileInfo fileInf = new FileInfo(objects[0]);
                textBoxIn.Text = fileInf.DirectoryName;
            }
        }

        private void groupBoxOut_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void groupBoxOut_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileInfo fileInf = new FileInfo(objects[0]);
                textBoxOut.Text = fileInf.DirectoryName;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = GetFiles(textBoxIn.Text, "*.jpg", checkBoxHandleNestedDirectories.Checked);
        }

        private List<string> GetFiles(string path, string pattern, Boolean recursion)
        {
            var files = new List<string>();

            try
            {
                files.AddRange(Directory.GetFiles(path, pattern, SearchOption.TopDirectoryOnly));

                if (recursion)
                    foreach (var directory in Directory.GetDirectories(path))
                        files.AddRange(GetFiles(directory, pattern, recursion));
            }
            catch (UnauthorizedAccessException) { }

            return files;
        }
    }
}
