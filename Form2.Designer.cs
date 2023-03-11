namespace MakeZip
{
    partial class frmInfo
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.CheckFolder = new System.Windows.Forms.CheckBox();
            this.checkFile = new System.Windows.Forms.CheckBox();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.btnSavefile = new System.Windows.Forms.Button();
            this.btnopenFileFolder = new System.Windows.Forms.Button();
            this.lblDestinationerror = new System.Windows.Forms.Label();
            this.lblSourceerror = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.btnZip = new System.Windows.Forms.Button();
            this.btnunzip = new System.Windows.Forms.Button();
            this.txtSourceLoc = new System.Windows.Forms.TextBox();
            this.txtDestinationLoc = new System.Windows.Forms.TextBox();
            this.lblpassincorrect = new System.Windows.Forms.Label();
            this.lblPasserror = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMakeZip = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTypetxt = new System.Windows.Forms.Label();
            this.lblPasstxt = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDestinationtxt = new System.Windows.Forms.Label();
            this.lblSourceTxt = new System.Windows.Forms.Label();
            this.lblDestinationPath = new System.Windows.Forms.Label();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnPattern = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.gbMain.Location = new System.Drawing.Point(3, 25);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(0, 0);
            this.gbMain.TabIndex = 25;
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
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(113, 105);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(190, 20);
            this.txtPass.TabIndex = 10;
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeDate.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTimeDate.ForeColor = System.Drawing.Color.White;
            this.lblTimeDate.Location = new System.Drawing.Point(397, 6);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(51, 12);
            this.lblTimeDate.TabIndex = 29;
            this.lblTimeDate.Text = "Time & Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(349, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "All right reserve by iMohsen02";
            // 
            // lblMakeZip
            // 
            this.lblMakeZip.AutoSize = true;
            this.lblMakeZip.BackColor = System.Drawing.Color.Transparent;
            this.lblMakeZip.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeZip.ForeColor = System.Drawing.Color.White;
            this.lblMakeZip.Location = new System.Drawing.Point(33, 2);
            this.lblMakeZip.Name = "lblMakeZip";
            this.lblMakeZip.Size = new System.Drawing.Size(133, 32);
            this.lblMakeZip.TabIndex = 27;
            this.lblMakeZip.Text = "Make Zip";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.lblTypetxt);
            this.groupBox1.Controls.Add(this.lblPasstxt);
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblDestinationtxt);
            this.groupBox1.Controls.Add(this.lblSourceTxt);
            this.groupBox1.Controls.Add(this.lblDestinationPath);
            this.groupBox1.Controls.Add(this.lblSourcePath);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.btnPattern);
            this.groupBox1.Location = new System.Drawing.Point(11, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 176);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zip & Unzip";
            // 
            // lblTypetxt
            // 
            this.lblTypetxt.AutoSize = true;
            this.lblTypetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.lblTypetxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(173)))), ((int)(((byte)(214)))));
            this.lblTypetxt.Location = new System.Drawing.Point(130, 89);
            this.lblTypetxt.Name = "lblTypetxt";
            this.lblTypetxt.Size = new System.Drawing.Size(0, 15);
            this.lblTypetxt.TabIndex = 33;
            // 
            // lblPasstxt
            // 
            this.lblPasstxt.AutoSize = true;
            this.lblPasstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.lblPasstxt.Enabled = false;
            this.lblPasstxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasstxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(173)))), ((int)(((byte)(214)))));
            this.lblPasstxt.Location = new System.Drawing.Point(130, 69);
            this.lblPasstxt.Name = "lblPasstxt";
            this.lblPasstxt.Size = new System.Drawing.Size(0, 15);
            this.lblPasstxt.TabIndex = 33;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.lbltime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbltime.Location = new System.Drawing.Point(174, 138);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(31, 15);
            this.lbltime.TabIndex = 33;
            this.lbltime.Text = "time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(40, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Succe ssfully Done!";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(25, 89);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 15);
            this.lblType.TabIndex = 33;
            this.lblType.Text = "Type :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(25, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 15);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "Password :";
            // 
            // lblDestinationtxt
            // 
            this.lblDestinationtxt.AutoSize = true;
            this.lblDestinationtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.lblDestinationtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(173)))), ((int)(((byte)(214)))));
            this.lblDestinationtxt.Location = new System.Drawing.Point(130, 50);
            this.lblDestinationtxt.Name = "lblDestinationtxt";
            this.lblDestinationtxt.Size = new System.Drawing.Size(0, 15);
            this.lblDestinationtxt.TabIndex = 32;
            // 
            // lblSourceTxt
            // 
            this.lblSourceTxt.AutoSize = true;
            this.lblSourceTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.lblSourceTxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(173)))), ((int)(((byte)(214)))));
            this.lblSourceTxt.Location = new System.Drawing.Point(130, 32);
            this.lblSourceTxt.Name = "lblSourceTxt";
            this.lblSourceTxt.Size = new System.Drawing.Size(0, 15);
            this.lblSourceTxt.TabIndex = 31;
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.lblDestinationPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.lblDestinationPath.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationPath.ForeColor = System.Drawing.Color.White;
            this.lblDestinationPath.Location = new System.Drawing.Point(25, 50);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(99, 15);
            this.lblDestinationPath.TabIndex = 32;
            this.lblDestinationPath.Text = "Destionatio Loc :";
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.lblSourcePath.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourcePath.ForeColor = System.Drawing.Color.White;
            this.lblSourcePath.Location = new System.Drawing.Point(25, 32);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(76, 15);
            this.lblSourcePath.TabIndex = 31;
            this.lblSourcePath.Text = "Source Loc :";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(405, 135);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "OK";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnPattern
            // 
            this.btnPattern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.btnPattern.Enabled = false;
            this.btnPattern.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPattern.Location = new System.Drawing.Point(6, 18);
            this.btnPattern.Name = "btnPattern";
            this.btnPattern.Size = new System.Drawing.Size(494, 151);
            this.btnPattern.TabIndex = 30;
            this.btnPattern.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MakeZip.Properties.Resources._2114;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 228);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMakeZip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.CheckBox CheckFolder;
        private System.Windows.Forms.CheckBox checkFile;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Button btnSavefile;
        private System.Windows.Forms.Button btnopenFileFolder;
        private System.Windows.Forms.Label lblDestinationerror;
        private System.Windows.Forms.Label lblSourceerror;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Button btnunzip;
        private System.Windows.Forms.TextBox txtSourceLoc;
        private System.Windows.Forms.TextBox txtDestinationLoc;
        private System.Windows.Forms.Label lblpassincorrect;
        private System.Windows.Forms.Label lblPasserror;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMakeZip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPattern;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPasstxt;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDestinationtxt;
        private System.Windows.Forms.Label lblSourceTxt;
        private System.Windows.Forms.Label lblDestinationPath;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.Label lblTypetxt;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltime;
    }
}