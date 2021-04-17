// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ImageSorter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            TextBoxIn.AllowDrop = true;
            TextBoxOut.AllowDrop = true;
        }

        private void ButtonIn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxIn.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonOut_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxOut.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            ShowLog("Обработка начата...");

            List<string> SortFiles = GetFiles(TextBoxIn.Text, "*.jpg", checkBoxHandleNestedDirectories.Checked);

            progressBar.Maximum = SortFiles.Count;

            foreach (string sf in SortFiles)
            {
                if (ProcessinFiles(TextBoxIn.Text, TextBoxOut.Text, Path.GetFileName(sf.ToString()), checkBoxMoveFiles.Checked))
                {
                    ShowLog("Обработан файл: " + Path.GetFileName(sf.ToString()));
                }
                else
                {
                    ShowLog("Ошибка обработки файла: " + Path.GetFileName(sf.ToString()));
                }

                progressBar.Value += 1;
            }

            ShowLog("Обработка файлов окончена.");
        }

        private Boolean ProcessinFiles(string inpath, string outpath, string filename, Boolean movefiles)
        {
            Boolean status = true;

            string infile = Path.Combine(inpath, filename);
            string newcatalog = Path.Combine(outpath, GetExifData(infile));
            string outfile = Path.Combine(newcatalog, filename);

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(newcatalog);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                if (movefiles)
                {
                    File.Move(sourceFileName: infile, destFileName: outfile);
                }
                else
                {
                    File.Copy(sourceFileName: infile, destFileName: outfile);
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

        private string GetExifData(string filename)
        {
            string ExifData;

            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    Image myImage = Image.FromStream(fs);               
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = new System.Text.RegularExpressions.Regex(":").Replace(System.Text.Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    ExifData = System.DateTime.Parse(dateTaken).ToString("yyyy-MM-dd");
                }
            }
            catch
            {
                ExifData = "Неизвестно";
            }

            return ExifData;
        }

        private void ShowLog(string message)
        {
            labelProgress.Text = message;
            textBoxLog.Text += message + '\r' + '\n';
            textBoxLog.SelectionStart = textBoxLog.Text.Length - 1;
            textBoxLog.ScrollToCaret();

            Application.DoEvents();
        }

        private void TextBoxIn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void TextBoxIn_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileInfo fileInf = new FileInfo(objects[0]);
                TextBoxIn.Text = fileInf.DirectoryName;
            }
        }

        private void TextBoxOut_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void TextBoxOut_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileInfo fileInf = new FileInfo(objects[0]);
                TextBoxOut.Text = fileInf.DirectoryName;
            }
        }
    }
}