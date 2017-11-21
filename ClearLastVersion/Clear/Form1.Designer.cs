namespace Clear
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cLBOperation = new System.Windows.Forms.CheckedListBox();
            this.LBProcess = new System.Windows.Forms.Label();
            this.LBVideoController = new System.Windows.Forms.Label();
            this.LBRam = new System.Windows.Forms.Label();
            this.LBWindows = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAnalize = new System.Windows.Forms.Button();
            this.LVInformation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LVInfoFiles = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.MyCclearNotyfi = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnInternet = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cLBOperation
            // 
            this.cLBOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cLBOperation.CheckOnClick = true;
            this.cLBOperation.FormattingEnabled = true;
            this.cLBOperation.Location = new System.Drawing.Point(115, 64);
            this.cLBOperation.MultiColumn = true;
            this.cLBOperation.Name = "cLBOperation";
            this.cLBOperation.Size = new System.Drawing.Size(177, 334);
            this.cLBOperation.TabIndex = 5;
            // 
            // LBProcess
            // 
            this.LBProcess.AutoSize = true;
            this.LBProcess.Location = new System.Drawing.Point(295, 48);
            this.LBProcess.Name = "LBProcess";
            this.LBProcess.Size = new System.Drawing.Size(35, 13);
            this.LBProcess.TabIndex = 9;
            this.LBProcess.Text = "label1";
            // 
            // LBVideoController
            // 
            this.LBVideoController.AutoSize = true;
            this.LBVideoController.Location = new System.Drawing.Point(295, 35);
            this.LBVideoController.Name = "LBVideoController";
            this.LBVideoController.Size = new System.Drawing.Size(35, 13);
            this.LBVideoController.TabIndex = 10;
            this.LBVideoController.Text = "label1";
            // 
            // LBRam
            // 
            this.LBRam.AutoSize = true;
            this.LBRam.Location = new System.Drawing.Point(295, 20);
            this.LBRam.Name = "LBRam";
            this.LBRam.Size = new System.Drawing.Size(35, 13);
            this.LBRam.TabIndex = 11;
            this.LBRam.Text = "label1";
            // 
            // LBWindows
            // 
            this.LBWindows.AutoSize = true;
            this.LBWindows.Location = new System.Drawing.Point(295, 7);
            this.LBWindows.Name = "LBWindows";
            this.LBWindows.Size = new System.Drawing.Size(35, 13);
            this.LBWindows.TabIndex = 12;
            this.LBWindows.Text = "label1";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(678, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(298, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(455, 13);
            this.progressBar1.TabIndex = 6;
            // 
            // btnAnalize
            // 
            this.btnAnalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnalize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnalize.Location = new System.Drawing.Point(298, 404);
            this.btnAnalize.Name = "btnAnalize";
            this.btnAnalize.Size = new System.Drawing.Size(75, 28);
            this.btnAnalize.TabIndex = 3;
            this.btnAnalize.Text = "Analize";
            this.btnAnalize.UseVisualStyleBackColor = true;
            this.btnAnalize.Click += new System.EventHandler(this.btnAnalize_Click);
            // 
            // LVInformation
            // 
            this.LVInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LVInformation.ContextMenuStrip = this.contextMenuStrip1;
            this.LVInformation.FullRowSelect = true;
            this.LVInformation.GridLines = true;
            this.LVInformation.LargeImageList = this.imageList1;
            this.LVInformation.Location = new System.Drawing.Point(298, 83);
            this.LVInformation.MultiSelect = false;
            this.LVInformation.Name = "LVInformation";
            this.LVInformation.Size = new System.Drawing.Size(455, 315);
            this.LVInformation.SmallImageList = this.imageList1;
            this.LVInformation.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LVInformation.TabIndex = 8;
            this.LVInformation.UseCompatibleStateImageBehavior = false;
            this.LVInformation.View = System.Windows.Forms.View.Details;
            this.LVInformation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LVInformation_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type File:";
            this.columnHeader1.Width = 275;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size:";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Files";
            this.columnHeader3.Width = 83;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Chrome.png");
            this.imageList1.Images.SetKeyName(1, "icons8-firefox-16.png");
            this.imageList1.Images.SetKeyName(2, "icons8-internet-explorer-16.png");
            this.imageList1.Images.SetKeyName(3, "icons8-opera-16.png");
            this.imageList1.Images.SetKeyName(4, "icons8-windows-xp-16.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "MyCClear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(150, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "He clear all....";
            // 
            // LVInfoFiles
            // 
            this.LVInfoFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVInfoFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.LVInfoFiles.ContextMenuStrip = this.contextMenuStrip2;
            this.LVInfoFiles.GridLines = true;
            this.LVInfoFiles.Location = new System.Drawing.Point(298, 83);
            this.LVInfoFiles.MultiSelect = false;
            this.LVInfoFiles.Name = "LVInfoFiles";
            this.LVInfoFiles.Size = new System.Drawing.Size(455, 315);
            this.LVInfoFiles.SmallImageList = this.imageList1;
            this.LVInfoFiles.TabIndex = 16;
            this.LVInfoFiles.UseCompatibleStateImageBehavior = false;
            this.LVInfoFiles.View = System.Windows.Forms.View.Details;
            this.LVInfoFiles.Visible = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Way File:";
            this.columnHeader4.Width = 469;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.backToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(183, 48);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Image = global::Clear.Properties.Resources.icons8_Налево_Filled_16;
            this.btnBack.Location = new System.Drawing.Point(298, 64);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 19);
            this.btnBack.TabIndex = 17;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MyCclearNotyfi
            // 
            this.MyCclearNotyfi.Icon = ((System.Drawing.Icon)(resources.GetObject("MyCclearNotyfi.Icon")));
            this.MyCclearNotyfi.Text = "MyCClear";
            this.MyCclearNotyfi.Visible = true;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Image = global::Clear.Properties.Resources.icons8_about_50__1_;
            this.btnAbout.Location = new System.Drawing.Point(1, 250);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(114, 92);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "About ";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            this.btnAbout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseMove);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Clear.Properties.Resources.icons8_Показать_Filled_16;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openToolStripMenuItem.Text = "Open containing file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Image = global::Clear.Properties.Resources.icons8_Налево_Filled_16;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Image = global::Clear.Properties.Resources.icons8_Показать_Filled_16;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFile.Image = global::Clear.Properties.Resources.icons8_Папка_48__1_;
            this.btnFile.Location = new System.Drawing.Point(1, 157);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(114, 92);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "File Sysytem";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.bynFile_Click);
            this.btnFile.MouseLeave += new System.EventHandler(this.bynFile_MouseLeave);
            this.btnFile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bynFile_MouseMove);
            // 
            // btnInternet
            // 
            this.btnInternet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnInternet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInternet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInternet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInternet.Image = global::Clear.Properties.Resources.icons8_Microsoft_Edge_Filled_50;
            this.btnInternet.Location = new System.Drawing.Point(1, 64);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(114, 92);
            this.btnInternet.TabIndex = 0;
            this.btnInternet.Text = "Internet";
            this.btnInternet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInternet.UseVisualStyleBackColor = false;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            this.btnInternet.MouseLeave += new System.EventHandler(this.btnInternet_MouseLeave);
            this.btnInternet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnInternet_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(759, 438);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.LVInfoFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LVInformation);
            this.Controls.Add(this.cLBOperation);
            this.Controls.Add(this.btnAnalize);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.LBWindows);
            this.Controls.Add(this.LBRam);
            this.Controls.Add(this.LBVideoController);
            this.Controls.Add(this.LBProcess);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnInternet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MyCClear";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.CheckedListBox cLBOperation;
        private System.Windows.Forms.Label LBProcess;
        private System.Windows.Forms.Label LBVideoController;
        private System.Windows.Forms.Label LBRam;
        private System.Windows.Forms.Label LBWindows;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnAnalize;
        private System.Windows.Forms.ListView LVInformation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ListView LVInfoFiles;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon MyCclearNotyfi;
    }
}

