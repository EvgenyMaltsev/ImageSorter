// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ImageSorter
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonIn = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.TextBoxIn = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.TextBoxOut = new System.Windows.Forms.TextBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxLeaveErrorFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxHandleNestedDirectories = new System.Windows.Forms.CheckBox();
            this.checkBoxMoveFiles = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIn
            // 
            this.buttonIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIn.ImageKey = "Cornmanthe3rd-Plex-System-folder-yellow.ico";
            this.buttonIn.ImageList = this.imageList;
            this.buttonIn.Location = new System.Drawing.Point(817, 23);
            this.buttonIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(22, 22);
            this.buttonIn.TabIndex = 1;
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.ButtonIn_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Cornmanthe3rd-Plex-System-folder-yellow.ico");
            // 
            // TextBoxIn
            // 
            this.TextBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxIn.Location = new System.Drawing.Point(106, 23);
            this.TextBoxIn.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxIn.Name = "TextBoxIn";
            this.TextBoxIn.ReadOnly = true;
            this.TextBoxIn.Size = new System.Drawing.Size(699, 22);
            this.TextBoxIn.TabIndex = 0;
            this.TextBoxIn.TabStop = false;
            this.TextBoxIn.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxIn_DragDrop);
            this.TextBoxIn.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxIn_DragEnter);
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(718, 193);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(121, 28);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "Сортировка";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOut.ImageKey = "Cornmanthe3rd-Plex-System-folder-yellow.ico";
            this.buttonOut.ImageList = this.imageList;
            this.buttonOut.Location = new System.Drawing.Point(817, 57);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(22, 22);
            this.buttonOut.TabIndex = 1;
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.ButtonOut_Click);
            // 
            // TextBoxOut
            // 
            this.TextBoxOut.Location = new System.Drawing.Point(106, 57);
            this.TextBoxOut.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxOut.Name = "TextBoxOut";
            this.TextBoxOut.ReadOnly = true;
            this.TextBoxOut.Size = new System.Drawing.Size(699, 22);
            this.TextBoxOut.TabIndex = 0;
            this.TextBoxOut.TabStop = false;
            this.TextBoxOut.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxOut_DragDrop);
            this.TextBoxOut.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxOut_DragEnter);
            // 
            // labelProgress
            // 
            this.labelProgress.Location = new System.Drawing.Point(9, 119);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(827, 16);
            this.labelProgress.TabIndex = 1;
            this.labelProgress.Text = "Ожидание...";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 139);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(827, 28);
            this.progressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Источник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Назначение";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 259);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGo);
            this.tabPage1.Controls.Add(this.labelProgress);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.buttonOut);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonIn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TextBoxIn);
            this.tabPage1.Controls.Add(this.TextBoxOut);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основное";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxLeaveErrorFiles);
            this.tabPage2.Controls.Add(this.checkBoxHandleNestedDirectories);
            this.tabPage2.Controls.Add(this.checkBoxMoveFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeaveErrorFiles
            // 
            this.checkBoxLeaveErrorFiles.AutoSize = true;
            this.checkBoxLeaveErrorFiles.Location = new System.Drawing.Point(12, 72);
            this.checkBoxLeaveErrorFiles.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLeaveErrorFiles.Name = "checkBoxLeaveErrorFiles";
            this.checkBoxLeaveErrorFiles.Size = new System.Drawing.Size(234, 21);
            this.checkBoxLeaveErrorFiles.TabIndex = 3;
            this.checkBoxLeaveErrorFiles.Text = "Оставлять ошибочные файлы ";
            this.checkBoxLeaveErrorFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxHandleNestedDirectories
            // 
            this.checkBoxHandleNestedDirectories.AutoSize = true;
            this.checkBoxHandleNestedDirectories.Checked = true;
            this.checkBoxHandleNestedDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHandleNestedDirectories.Location = new System.Drawing.Point(12, 14);
            this.checkBoxHandleNestedDirectories.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxHandleNestedDirectories.Name = "checkBoxHandleNestedDirectories";
            this.checkBoxHandleNestedDirectories.Size = new System.Drawing.Size(268, 21);
            this.checkBoxHandleNestedDirectories.TabIndex = 2;
            this.checkBoxHandleNestedDirectories.Text = "Обрабатывать вложенные каталоги";
            this.checkBoxHandleNestedDirectories.UseVisualStyleBackColor = true;
            // 
            // checkBoxMoveFiles
            // 
            this.checkBoxMoveFiles.AutoSize = true;
            this.checkBoxMoveFiles.Checked = true;
            this.checkBoxMoveFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMoveFiles.Location = new System.Drawing.Point(12, 43);
            this.checkBoxMoveFiles.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMoveFiles.Name = "checkBoxMoveFiles";
            this.checkBoxMoveFiles.Size = new System.Drawing.Size(163, 21);
            this.checkBoxMoveFiles.TabIndex = 1;
            this.checkBoxMoveFiles.Text = "Перемещать файлы";
            this.checkBoxMoveFiles.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(848, 230);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Журнал работы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(3, 3);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(842, 224);
            this.textBoxLog.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 259);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировщик фотографий, версия 1.0.0.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxIn;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.TextBox TextBoxOut;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxLeaveErrorFiles;
        private System.Windows.Forms.CheckBox checkBoxHandleNestedDirectories;
        private System.Windows.Forms.CheckBox checkBoxMoveFiles;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}

