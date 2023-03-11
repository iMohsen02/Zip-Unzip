namespace MakeZip
{
    partial class frmMain
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtDestinationLoc = new System.Windows.Forms.TextBox();
            this.txtSourceLoc = new System.Windows.Forms.TextBox();
            this.btnunzip = new System.Windows.Forms.Button();
            this.btnZip = new System.Windows.Forms.Button();
            this.lblLoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblSourceerror = new System.Windows.Forms.Label();
            this.lblDestinationerror = new System.Windows.Forms.Label();
            this.btnopenFileFolder = new System.Windows.Forms.Button();
            this.btnSavefile = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.CheckFolder = new System.Windows.Forms.CheckBox();
            this.checkFile = new System.Windows.Forms.CheckBox();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.lblpassincorrect = new System.Windows.Forms.Label();
            this.lblPasserror = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topbprderMove = new System.Windows.Forms.Label();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::MakeZip.Properties.Resources._150_1504639_red_cross_mark_clipart_printable_cancel_clipart;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(507, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCloseForm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Make Zip";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(113, 105);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(190, 25);
            this.txtPass.TabIndex = 10;
            // 
            // txtDestinationLoc
            // 
            this.txtDestinationLoc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDestinationLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestinationLoc.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationLoc.Location = new System.Drawing.Point(113, 70);
            this.txtDestinationLoc.Name = "txtDestinationLoc";
            this.txtDestinationLoc.Size = new System.Drawing.Size(356, 20);
            this.txtDestinationLoc.TabIndex = 10;
            this.txtDestinationLoc.TextChanged += new System.EventHandler(this.txtDestinationLoc_TextChanged);
            // 
            // txtSourceLoc
            // 
            this.txtSourceLoc.BackColor = System.Drawing.Color.Silver;
            this.txtSourceLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSourceLoc.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceLoc.Location = new System.Drawing.Point(113, 36);
            this.txtSourceLoc.Name = "txtSourceLoc";
            this.txtSourceLoc.ReadOnly = true;
            this.txtSourceLoc.Size = new System.Drawing.Size(356, 20);
            this.txtSourceLoc.TabIndex = 10;
            this.txtSourceLoc.TextChanged += new System.EventHandler(this.txtSourceLoc_TextChanged);
            // 
            // btnunzip
            // 
            this.btnunzip.BackColor = System.Drawing.Color.White;
            this.btnunzip.Location = new System.Drawing.Point(413, 133);
            this.btnunzip.Name = "btnunzip";
            this.btnunzip.Size = new System.Drawing.Size(87, 27);
            this.btnunzip.TabIndex = 8;
            this.btnunzip.Text = "Unzip File";
            this.btnunzip.UseVisualStyleBackColor = false;
            this.btnunzip.Click += new System.EventHandler(this.btnunzip_Click);
            // 
            // btnZip
            // 
            this.btnZip.BackColor = System.Drawing.Color.White;
            this.btnZip.Enabled = false;
            this.btnZip.Location = new System.Drawing.Point(318, 133);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(87, 27);
            this.btnZip.TabIndex = 9;
            this.btnZip.Text = "Zip Files";
            this.btnZip.UseVisualStyleBackColor = false;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.BackColor = System.Drawing.Color.Transparent;
            this.lblLoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.White;
            this.lblLoc.Location = new System.Drawing.Point(7, 37);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(76, 15);
            this.lblLoc.TabIndex = 10;
            this.lblLoc.Text = "Source Loc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destionatio Loc :";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Enabled = false;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(7, 109);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 15);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "Password :";
            // 
            // lblSourceerror
            // 
            this.lblSourceerror.AutoSize = true;
            this.lblSourceerror.BackColor = System.Drawing.Color.Maroon;
            this.lblSourceerror.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceerror.ForeColor = System.Drawing.Color.White;
            this.lblSourceerror.Location = new System.Drawing.Point(114, 55);
            this.lblSourceerror.Name = "lblSourceerror";
            this.lblSourceerror.Size = new System.Drawing.Size(124, 14);
            this.lblSourceerror.TabIndex = 18;
            this.lblSourceerror.Text = "Field can\'t be empety ... !";
            this.lblSourceerror.Visible = false;
            // 
            // lblDestinationerror
            // 
            this.lblDestinationerror.AutoSize = true;
            this.lblDestinationerror.BackColor = System.Drawing.Color.DarkRed;
            this.lblDestinationerror.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationerror.ForeColor = System.Drawing.Color.White;
            this.lblDestinationerror.Location = new System.Drawing.Point(114, 90);
            this.lblDestinationerror.Name = "lblDestinationerror";
            this.lblDestinationerror.Size = new System.Drawing.Size(124, 14);
            this.lblDestinationerror.TabIndex = 18;
            this.lblDestinationerror.Text = "Field can\'t be empety ... !";
            this.lblDestinationerror.Visible = false;
            // 
            // btnopenFileFolder
            // 
            this.btnopenFileFolder.BackColor = System.Drawing.Color.White;
            this.btnopenFileFolder.Location = new System.Drawing.Point(472, 34);
            this.btnopenFileFolder.Name = "btnopenFileFolder";
            this.btnopenFileFolder.Size = new System.Drawing.Size(28, 25);
            this.btnopenFileFolder.TabIndex = 19;
            this.btnopenFileFolder.Text = "...";
            this.btnopenFileFolder.UseVisualStyleBackColor = false;
            this.btnopenFileFolder.Click += new System.EventHandler(this.btnSctStrtloc_Click);
            // 
            // btnSavefile
            // 
            this.btnSavefile.BackColor = System.Drawing.Color.White;
            this.btnSavefile.Location = new System.Drawing.Point(472, 68);
            this.btnSavefile.Name = "btnSavefile";
            this.btnSavefile.Size = new System.Drawing.Size(28, 25);
            this.btnSavefile.TabIndex = 19;
            this.btnSavefile.Text = "...";
            this.btnSavefile.UseVisualStyleBackColor = false;
            this.btnSavefile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.Color.Transparent;
            this.gbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbMain.Controls.Add(this.CheckFolder);
            this.gbMain.Controls.Add(this.checkFile);
            this.gbMain.Controls.Add(this.checkPass);
            this.gbMain.Controls.Add(this.btnSavefile);
            this.gbMain.Controls.Add(this.btnopenFileFolder);
            this.gbMain.Controls.Add(this.lblDestinationerror);
            this.gbMain.Controls.Add(this.lblSourceerror);
            this.gbMain.Controls.Add(this.lblPass);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.lblLoc);
            this.gbMain.Controls.Add(this.btnZip);
            this.gbMain.Controls.Add(this.btnunzip);
            this.gbMain.Controls.Add(this.txtSourceLoc);
            this.gbMain.Controls.Add(this.txtDestinationLoc);
            this.gbMain.Controls.Add(this.lblpassincorrect);
            this.gbMain.Controls.Add(this.lblPasserror);
            this.gbMain.Controls.Add(this.txtPass);
            this.gbMain.Location = new System.Drawing.Point(10, 35);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(506, 176);
            this.gbMain.TabIndex = 9;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Zip & Unzip";
            // 
            // CheckFolder
            // 
            this.CheckFolder.AutoSize = true;
            this.CheckFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckFolder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckFolder.ForeColor = System.Drawing.Color.White;
            this.CheckFolder.Location = new System.Drawing.Point(112, 151);
            this.CheckFolder.Name = "CheckFolder";
            this.CheckFolder.Size = new System.Drawing.Size(60, 19);
            this.CheckFolder.TabIndex = 20;
            this.CheckFolder.Text = "Folder";
            this.CheckFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckFolder.UseVisualStyleBackColor = true;
            this.CheckFolder.Click += new System.EventHandler(this.CheckFolder_Click);
            // 
            // checkFile
            // 
            this.checkFile.AutoSize = true;
            this.checkFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFile.ForeColor = System.Drawing.Color.White;
            this.checkFile.Location = new System.Drawing.Point(59, 151);
            this.checkFile.Name = "checkFile";
            this.checkFile.Size = new System.Drawing.Size(47, 19);
            this.checkFile.TabIndex = 20;
            this.checkFile.Text = "File";
            this.checkFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkFile.UseVisualStyleBackColor = true;
            this.checkFile.Click += new System.EventHandler(this.checkFile_Click);
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPass.ForeColor = System.Drawing.Color.White;
            this.checkPass.Location = new System.Drawing.Point(10, 151);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(49, 19);
            this.checkPass.TabIndex = 20;
            this.checkPass.Text = "Pass";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // lblpassincorrect
            // 
            this.lblpassincorrect.AutoSize = true;
            this.lblpassincorrect.BackColor = System.Drawing.Color.Maroon;
            this.lblpassincorrect.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassincorrect.ForeColor = System.Drawing.Color.White;
            this.lblpassincorrect.Location = new System.Drawing.Point(113, 130);
            this.lblpassincorrect.Name = "lblpassincorrect";
            this.lblpassincorrect.Size = new System.Drawing.Size(178, 14);
            this.lblpassincorrect.TabIndex = 21;
            this.lblpassincorrect.Text = "Incorrect password, please try again..";
            this.lblpassincorrect.Visible = false;
            // 
            // lblPasserror
            // 
            this.lblPasserror.AutoSize = true;
            this.lblPasserror.BackColor = System.Drawing.Color.Maroon;
            this.lblPasserror.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasserror.ForeColor = System.Drawing.Color.White;
            this.lblPasserror.Location = new System.Drawing.Point(113, 130);
            this.lblPasserror.Name = "lblPasserror";
            this.lblPasserror.Size = new System.Drawing.Size(130, 14);
            this.lblPasserror.TabIndex = 18;
            this.lblPasserror.Text = "Field Can\'t Be Empety ... !";
            this.lblPasserror.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(348, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "All right reserve by iMohsen02";
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeDate.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTimeDate.ForeColor = System.Drawing.Color.White;
            this.lblTimeDate.Location = new System.Drawing.Point(417, 30);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(51, 12);
            this.lblTimeDate.TabIndex = 24;
            this.lblTimeDate.Text = "Time & Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // topbprderMove
            // 
            this.topbprderMove.AutoSize = true;
            this.topbprderMove.BackColor = System.Drawing.Color.Transparent;
            this.topbprderMove.Location = new System.Drawing.Point(0, 0);
            this.topbprderMove.Name = "topbprderMove";
            this.topbprderMove.Size = new System.Drawing.Size(512, 17);
            this.topbprderMove.TabIndex = 25;
            this.topbprderMove.Text = "                                                                                 " +
    "                                             ";
            this.topbprderMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topborderMoveClick);
            this.topbprderMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topborderMoveUp);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnZip;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MakeZip.Properties.Resources._2114;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(528, 228);
            this.ControlBox = false;
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.topbprderMove);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make ZipFile";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtDestinationLoc;
        private System.Windows.Forms.TextBox txtSourceLoc;
        private System.Windows.Forms.Button btnunzip;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblSourceerror;
        private System.Windows.Forms.Label lblDestinationerror;
        private System.Windows.Forms.Button btnopenFileFolder;
        private System.Windows.Forms.Button btnSavefile;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Label lblPasserror;
        private System.Windows.Forms.CheckBox CheckFolder;
        private System.Windows.Forms.CheckBox checkFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblpassincorrect;
        private System.Windows.Forms.Label topbprderMove;
    }
}

