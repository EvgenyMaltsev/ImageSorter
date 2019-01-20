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
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxLeaveErrorFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxHandleNestedDirectories = new System.Windows.Forms.CheckBox();
            this.checkBoxMoveFiles = new System.Windows.Forms.CheckBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.buttonOut = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.groupBoxIn.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxOut.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIn.Controls.Add(this.buttonIn);
            this.groupBoxIn.Controls.Add(this.textBoxIn);
            this.groupBoxIn.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(618, 81);
            this.groupBoxIn.TabIndex = 0;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "[ Источник ]";
            this.groupBoxIn.DragDrop += new System.Windows.Forms.DragEventHandler(this.GroupBoxIn_DragDrop);
            this.groupBoxIn.DragEnter += new System.Windows.Forms.DragEventHandler(this.GroupBoxIn_DragEnter);
            // 
            // buttonIn
            // 
            this.buttonIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIn.ImageKey = "Cornmanthe3rd-Plex-System-folder-yellow.ico";
            this.buttonIn.ImageList = this.imageList;
            this.buttonIn.Location = new System.Drawing.Point(578, 30);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(30, 30);
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
            // textBoxIn
            // 
            this.textBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIn.Location = new System.Drawing.Point(15, 36);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.ReadOnly = true;
            this.textBoxIn.Size = new System.Drawing.Size(557, 20);
            this.textBoxIn.TabIndex = 0;
            this.textBoxIn.TabStop = false;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.checkBoxLeaveErrorFiles);
            this.groupBoxSettings.Controls.Add(this.checkBoxHandleNestedDirectories);
            this.groupBoxSettings.Controls.Add(this.checkBoxMoveFiles);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 274);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(618, 62);
            this.groupBoxSettings.TabIndex = 2;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "[ Параметры ]";
            // 
            // checkBoxLeaveErrorFiles
            // 
            this.checkBoxLeaveErrorFiles.AutoSize = true;
            this.checkBoxLeaveErrorFiles.Location = new System.Drawing.Point(428, 36);
            this.checkBoxLeaveErrorFiles.Name = "checkBoxLeaveErrorFiles";
            this.checkBoxLeaveErrorFiles.Size = new System.Drawing.Size(180, 17);
            this.checkBoxLeaveErrorFiles.TabIndex = 2;
            this.checkBoxLeaveErrorFiles.Text = "Оставлять ошибочные файлы ";
            this.checkBoxLeaveErrorFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxHandleNestedDirectories
            // 
            this.checkBoxHandleNestedDirectories.AutoSize = true;
            this.checkBoxHandleNestedDirectories.Checked = true;
            this.checkBoxHandleNestedDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHandleNestedDirectories.Location = new System.Drawing.Point(182, 36);
            this.checkBoxHandleNestedDirectories.Name = "checkBoxHandleNestedDirectories";
            this.checkBoxHandleNestedDirectories.Size = new System.Drawing.Size(210, 17);
            this.checkBoxHandleNestedDirectories.TabIndex = 1;
            this.checkBoxHandleNestedDirectories.Text = "Обрабатывать вложенные каталоги";
            this.checkBoxHandleNestedDirectories.UseVisualStyleBackColor = true;
            // 
            // checkBoxMoveFiles
            // 
            this.checkBoxMoveFiles.AutoSize = true;
            this.checkBoxMoveFiles.Checked = true;
            this.checkBoxMoveFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMoveFiles.Location = new System.Drawing.Point(15, 36);
            this.checkBoxMoveFiles.Name = "checkBoxMoveFiles";
            this.checkBoxMoveFiles.Size = new System.Drawing.Size(129, 17);
            this.checkBoxMoveFiles.TabIndex = 0;
            this.checkBoxMoveFiles.Text = "Перемещать файлы";
            this.checkBoxMoveFiles.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(539, 513);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(91, 23);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "Сортировка";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut.Controls.Add(this.buttonOut);
            this.groupBoxOut.Controls.Add(this.textBoxOut);
            this.groupBoxOut.Location = new System.Drawing.Point(12, 99);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(618, 81);
            this.groupBoxOut.TabIndex = 1;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "[ Назначение ]";
            this.groupBoxOut.DragDrop += new System.Windows.Forms.DragEventHandler(this.GroupBoxOut_DragDrop);
            this.groupBoxOut.DragEnter += new System.Windows.Forms.DragEventHandler(this.GroupBoxOut_DragEnter);
            // 
            // buttonOut
            // 
            this.buttonOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOut.ImageKey = "Cornmanthe3rd-Plex-System-folder-yellow.ico";
            this.buttonOut.ImageList = this.imageList;
            this.buttonOut.Location = new System.Drawing.Point(578, 30);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(30, 30);
            this.buttonOut.TabIndex = 1;
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.ButtonOut_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut.Location = new System.Drawing.Point(15, 36);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(557, 20);
            this.textBoxOut.TabIndex = 0;
            this.textBoxOut.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelProgress);
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Прогресс ]";
            // 
            // labelProgress
            // 
            this.labelProgress.Location = new System.Drawing.Point(15, 26);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(593, 13);
            this.labelProgress.TabIndex = 1;
            this.labelProgress.Text = "Ожидание...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 42);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(593, 23);
            this.progressBar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Журнал работы ]";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(15, 37);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(593, 108);
            this.textBoxLog.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировщик фотографий, версия 1.0.0.0";
            this.groupBoxIn.ResumeLayout(false);
            this.groupBoxIn.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxOut.ResumeLayout(false);
            this.groupBoxOut.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.CheckBox checkBoxLeaveErrorFiles;
        private System.Windows.Forms.CheckBox checkBoxHandleNestedDirectories;
        private System.Windows.Forms.CheckBox checkBoxMoveFiles;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}

