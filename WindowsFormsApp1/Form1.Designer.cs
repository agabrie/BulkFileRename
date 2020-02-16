namespace WindowsFormsApp1
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblEpisodeNumber = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txfFilesRename = new System.Windows.Forms.TextBox();
            this.lblNameFormat = new System.Windows.Forms.Label();
            this.tblFiles = new System.Windows.Forms.ListView();
            this.lblPath = new System.Windows.Forms.Label();
            this.nudEpisodeNumber = new System.Windows.Forms.NumericUpDown();
            this.btnPreview = new System.Windows.Forms.Button();
            this.chkEpisodeSuffix = new System.Windows.Forms.CheckBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.tblOrdered = new System.Windows.Forms.ListView();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodeNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(664, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEditClick);
            // 
            // lblEpisodeNumber
            // 
            this.lblEpisodeNumber.AutoSize = true;
            this.lblEpisodeNumber.Location = new System.Drawing.Point(9, 420);
            this.lblEpisodeNumber.Name = "lblEpisodeNumber";
            this.lblEpisodeNumber.Size = new System.Drawing.Size(88, 13);
            this.lblEpisodeNumber.TabIndex = 1;
            this.lblEpisodeNumber.Text = "episode number :";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(664, 27);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolderClick);
            // 
            // txfFilesRename
            // 
            this.txfFilesRename.Location = new System.Drawing.Point(664, 339);
            this.txfFilesRename.Name = "txfFilesRename";
            this.txfFilesRename.Size = new System.Drawing.Size(100, 20);
            this.txfFilesRename.TabIndex = 5;
            // 
            // lblNameFormat
            // 
            this.lblNameFormat.AutoSize = true;
            this.lblNameFormat.Location = new System.Drawing.Point(664, 226);
            this.lblNameFormat.Name = "lblNameFormat";
            this.lblNameFormat.Size = new System.Drawing.Size(108, 13);
            this.lblNameFormat.TabIndex = 6;
            this.lblNameFormat.Text = "Series Name Format :";
            // 
            // tblFiles
            // 
            this.tblFiles.FullRowSelect = true;
            this.tblFiles.Location = new System.Drawing.Point(12, 12);
            this.tblFiles.Name = "tblFiles";
            this.tblFiles.Size = new System.Drawing.Size(324, 376);
            this.tblFiles.TabIndex = 8;
            this.tblFiles.UseCompatibleStateImageBehavior = false;
            this.tblFiles.View = System.Windows.Forms.View.Details;
            this.tblFiles.SelectedIndexChanged += new System.EventHandler(this.tblFilesSelectedIndexChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(13, 476);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(28, 13);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "path";
            // 
            // nudEpisodeNumber
            // 
            this.nudEpisodeNumber.Location = new System.Drawing.Point(126, 450);
            this.nudEpisodeNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEpisodeNumber.Name = "nudEpisodeNumber";
            this.nudEpisodeNumber.Size = new System.Drawing.Size(120, 20);
            this.nudEpisodeNumber.TabIndex = 10;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(583, 543);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreviewClick);
            // 
            // chkEpisodeSuffix
            // 
            this.chkEpisodeSuffix.AutoSize = true;
            this.chkEpisodeSuffix.Location = new System.Drawing.Point(664, 302);
            this.chkEpisodeSuffix.Name = "chkEpisodeSuffix";
            this.chkEpisodeSuffix.Size = new System.Drawing.Size(91, 17);
            this.chkEpisodeSuffix.TabIndex = 12;
            this.chkEpisodeSuffix.Text = "Episode Suffx";
            this.chkEpisodeSuffix.UseVisualStyleBackColor = true;
            this.chkEpisodeSuffix.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(664, 70);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 13;
            this.btnAddFile.Text = "button1";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFileClick1);
            // 
            // tblOrdered
            // 
            this.tblOrdered.FullRowSelect = true;
            this.tblOrdered.Location = new System.Drawing.Point(402, 12);
            this.tblOrdered.Name = "tblOrdered";
            this.tblOrdered.Size = new System.Drawing.Size(245, 376);
            this.tblOrdered.TabIndex = 14;
            this.tblOrdered.UseCompatibleStateImageBehavior = false;
            this.tblOrdered.View = System.Windows.Forms.View.Details;
            this.tblOrdered.SelectedIndexChanged += new System.EventHandler(this.TblOrdered_SelectedIndexChanged);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Location = new System.Drawing.Point(342, 154);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(53, 23);
            this.btnShiftLeft.TabIndex = 15;
            this.btnShiftLeft.Text = "<";
            this.btnShiftLeft.UseVisualStyleBackColor = true;
            this.btnShiftLeft.Click += new System.EventHandler(this.BtnShiftLeft_Click);
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Location = new System.Drawing.Point(343, 184);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(53, 23);
            this.btnShiftRight.TabIndex = 16;
            this.btnShiftRight.Text = ">";
            this.btnShiftRight.UseVisualStyleBackColor = true;
            this.btnShiftRight.Click += new System.EventHandler(this.BtnShiftRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 719);
            this.Controls.Add(this.btnShiftRight);
            this.Controls.Add(this.btnShiftLeft);
            this.Controls.Add(this.tblOrdered);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.chkEpisodeSuffix);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.nudEpisodeNumber);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.tblFiles);
            this.Controls.Add(this.lblNameFormat);
            this.Controls.Add(this.txfFilesRename);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lblEpisodeNumber);
            this.Controls.Add(this.btnEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodeNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblEpisodeNumber;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txfFilesRename;
        private System.Windows.Forms.Label lblNameFormat;
        private System.Windows.Forms.ListView tblFiles;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.NumericUpDown nudEpisodeNumber;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox chkEpisodeSuffix;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListView tblOrdered;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Button btnShiftRight;
    }
}

