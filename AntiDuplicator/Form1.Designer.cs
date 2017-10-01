namespace AntiDuplicator
{
    partial class ad
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.filesGrid = new System.Windows.Forms.DataGridView();
            this.scanFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanFileHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanFileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanPath = new System.Windows.Forms.TextBox();
            this.scanAction = new System.Windows.Forms.Button();
            this.actionGo = new System.Windows.Forms.Button();
            this.adv = new System.Windows.Forms.PictureBox();
            this.addScanPath = new System.Windows.Forms.FolderBrowserDialog();
            this.action = new System.Windows.Forms.ComboBox();
            this.scanProcess = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.filesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adv)).BeginInit();
            this.SuspendLayout();
            // 
            // filesGrid
            // 
            this.filesGrid.AllowUserToAddRows = false;
            this.filesGrid.AllowUserToDeleteRows = false;
            this.filesGrid.AllowUserToResizeRows = false;
            this.filesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scanFileName,
            this.scanFileSize,
            this.scanFileHash,
            this.scanFileDate,
            this.scanFilePath});
            this.filesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.filesGrid.Location = new System.Drawing.Point(12, 35);
            this.filesGrid.Name = "filesGrid";
            this.filesGrid.ShowEditingIcon = false;
            this.filesGrid.Size = new System.Drawing.Size(680, 325);
            this.filesGrid.TabIndex = 0;
            // 
            // scanFileName
            // 
            this.scanFileName.HeaderText = "FileName";
            this.scanFileName.Name = "scanFileName";
            this.scanFileName.Width = 150;
            // 
            // scanFileSize
            // 
            this.scanFileSize.HeaderText = "FileSize";
            this.scanFileSize.Name = "scanFileSize";
            // 
            // scanFileHash
            // 
            this.scanFileHash.HeaderText = "FileHash";
            this.scanFileHash.Name = "scanFileHash";
            this.scanFileHash.Width = 200;
            // 
            // scanFileDate
            // 
            this.scanFileDate.HeaderText = "FileDate";
            this.scanFileDate.Name = "scanFileDate";
            // 
            // scanFilePath
            // 
            this.scanFilePath.HeaderText = "FilePath";
            this.scanFilePath.Name = "scanFilePath";
            this.scanFilePath.Width = 250;
            // 
            // scanPath
            // 
            this.scanPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanPath.Location = new System.Drawing.Point(12, 8);
            this.scanPath.Name = "scanPath";
            this.scanPath.ReadOnly = true;
            this.scanPath.Size = new System.Drawing.Size(300, 20);
            this.scanPath.TabIndex = 1;
            this.scanPath.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // scanAction
            // 
            this.scanAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanAction.Location = new System.Drawing.Point(318, 5);
            this.scanAction.Name = "scanAction";
            this.scanAction.Size = new System.Drawing.Size(75, 24);
            this.scanAction.TabIndex = 2;
            this.scanAction.Text = "Scan";
            this.scanAction.UseVisualStyleBackColor = true;
            this.scanAction.Click += new System.EventHandler(this.scanAction_Click);
            // 
            // actionGo
            // 
            this.actionGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionGo.Location = new System.Drawing.Point(617, 5);
            this.actionGo.Name = "actionGo";
            this.actionGo.Size = new System.Drawing.Size(75, 24);
            this.actionGo.TabIndex = 3;
            this.actionGo.Text = "GO!";
            this.actionGo.UseVisualStyleBackColor = true;
            // 
            // adv
            // 
            this.adv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.adv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adv.Location = new System.Drawing.Point(12, 366);
            this.adv.Name = "adv";
            this.adv.Size = new System.Drawing.Size(680, 64);
            this.adv.TabIndex = 5;
            this.adv.TabStop = false;
            // 
            // action
            // 
            this.action.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action.FormattingEnabled = true;
            this.action.Items.AddRange(new object[] {
            "DAR",
            "DAO",
            "DAY"});
            this.action.Location = new System.Drawing.Point(399, 7);
            this.action.MaxDropDownItems = 4;
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(212, 21);
            this.action.TabIndex = 6;
            // 
            // scanProcess
            // 
            this.scanProcess.WorkerReportsProgress = true;
            this.scanProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scanProcess_DoWork);
            this.scanProcess.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.scanProcess_ProgressChanged);
            this.scanProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.scanProcess_RunWorkerCompleted);
            // 
            // ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.action);
            this.Controls.Add(this.adv);
            this.Controls.Add(this.actionGo);
            this.Controls.Add(this.scanAction);
            this.Controls.Add(this.scanPath);
            this.Controls.Add(this.filesGrid);
            this.Name = "ad";
            this.Text = "AntiDuplicator";
            ((System.ComponentModel.ISupportInitialize)(this.filesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filesGrid;
        private System.Windows.Forms.TextBox scanPath;
        private System.Windows.Forms.Button scanAction;
        private System.Windows.Forms.Button actionGo;
        private System.Windows.Forms.PictureBox adv;
        private System.Windows.Forms.FolderBrowserDialog addScanPath;
        private System.Windows.Forms.ComboBox action;
        private System.ComponentModel.BackgroundWorker scanProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanFileHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanFileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanFilePath;

    }
}

