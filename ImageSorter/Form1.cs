// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ImageSorter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            groupBoxIn.AllowDrop = true;
            groupBoxOut.AllowDrop = true;
        }

        private void ButtonIn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxIn.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonOut_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOut.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void GroupBoxIn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void GroupBoxIn_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileInfo fileInf = new FileInfo(objects[0]);
                textBoxIn.Text = fileInf.DirectoryName;
            }
        }

        private void GroupBoxOut_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void GroupBoxOut_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileInfo fileInf = new FileInfo(objects[0]);
                textBoxOut.Text = fileInf.DirectoryName;
            }
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            labelProgress.Text = "Обработка начата...";

            List<string> SortFiles = new List<string>();

            SortFiles = GetFiles(textBoxIn.Text, "*.jpg", checkBoxHandleNestedDirectories.Checked);

            progressBar.Maximum = SortFiles.Count;

            foreach (string sf in SortFiles)
            {
                if (ProcessinFiles(textBoxIn.Text, textBoxOut.Text, Path.GetFileName(sf.ToString()), checkBoxMoveFiles.Checked))
                {
                    textBoxLog.Text += "Обработан файл: " + Path.GetFileName(sf.ToString()) + '\r' + '\n';
                    labelProgress.Text = "Обработан файл: " + Path.GetFileName(sf.ToString());
                }
                else
                {
                    textBoxLog.Text += "Ошибка обработки файла: " + Path.GetFileName(sf.ToString()) + '\r' + '\n';
                    labelProgress.Text = "Ошибка обработки файла: " + Path.GetFileName(sf.ToString());
                }

                textBoxLog.SelectionStart = textBoxLog.Text.Length - 1;
                textBoxLog.ScrollToCaret();
                progressBar.Value += 1;
                Application.DoEvents();
            }

            labelProgress.Text = "Обработка файлов окончена.";
            textBoxLog.Text += "Обработка файлов окончена.";
            textBoxLog.SelectionStart = textBoxLog.Text.Length - 1;
            textBoxLog.ScrollToCaret();
        }

        private Boolean ProcessinFiles(string inpath, string outpath, string filename, Boolean movefiles)
        {
            Boolean status = true;

            string infile = Path.Combine(inpath, filename);
            string outfile = Path.Combine(outpath, filename);

            try
            {
                if (movefiles)
                {
                    File.Move(Path.Combine(inpath, filename), Path.Combine(outpath, filename));
                }
                else
                {
                    File.Copy(Path.Combine(inpath, filename), Path.Combine(outpath, filename));
                }
            }
            catch
            {
                status = false;
            }

            return status;
        }

        private List<string> GetFiles(string path, string pattern, Boolean recursion)
        {
            List<string> files = new List<string>();

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