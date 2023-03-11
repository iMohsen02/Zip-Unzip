using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using Ionic.Zip;


namespace MakeZip
{

    public partial class frmMain : Form
    {
        //public string Sourcepath;
        //public string spath { get { return Sourcepath; } }
        //string Destinationpath;
        //public string dpath { get { return Destinationpath; } }
        //string Passwordtxt;
        //public string ptxt { get { return Passwordtxt; } }
        //string Type;
        //public string TypeDo { get { return Type; } }
        #region prop
        private string _Sourcepath;
        public string spath
        {
            get { return _Sourcepath; }
            set { _Sourcepath = value; }

        }

        private string _Destinationpath;
        public string dpath
        {
            get { return _Destinationpath; }
            set { _Destinationpath = value; }
        }

        private string _Passwordtxt;
        public string ptxt
        {
            get { return _Passwordtxt; }
            set { _Passwordtxt = value; }
        }

        private string _Type;
        public string TypeDo
        {
            get { return _Type; }
            set { _Type = value; }
        }

        #endregion prop

        public frmMain()
        {
            InitializeComponent();



        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //   lblTimeDate.Font.Size= new System
            lblTimeDate.Text = DateTime.Now.ToString("yyyy/mm/dd    hh:mm:ss");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTimeDate.Text = DateTime.Now.ToString("yyyy/m//d    hh:mm:ss");
        }

        private void btnCloseForm(object sender, EventArgs e)
        {
            base.Dispose();
        }

        private void btnSctStrtloc_Click(object sender, EventArgs e)
        {
            if (btnZip.Enabled)
            {
                if (CheckFolder.Checked)
                {


                    FolderBrowserDialog folder = new FolderBrowserDialog();

                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        txtSourceLoc.Text = folder.SelectedPath.ToString();
                    }

                }
                if (checkFile.Checked)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Multiselect = true;


                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtSourceLoc.Text = openFileDialog.FileName.ToString();
                    }
                }

            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSourceLoc.Text = openFileDialog.FileName.ToString();
                }
            }

        }

        private void checkFile_Click(object sender, EventArgs e)
        {
            //checkFile.ForeColor = System.Drawing.Color.White;
            //CheckFolder.ForeColor = System.Drawing.Color.White;

            lblSourceerror.Visible = false;
            lblDestinationerror.Visible = false;

            //checkFile.Checked = false;
            //CheckFolder.Checked = true;

            if (checkFile.Checked)
            {
                CheckFolder.Checked = false;
            }
            if (checkFile.Checked || CheckFolder.Checked)
            {
                btnZip.Enabled = true;
            }
            //if (CheckFolder.Checked)
            //{
            //    checkFile.Checked = false;
            //}
            else
            {
                btnZip.Enabled = false;
            }


            txtSourceLoc.Text = "";
            txtDestinationLoc.Text = "";
        }

        private void CheckFolder_Click(object sender, EventArgs e)
        {
            //checkFile.ForeColor = System.Drawing.Color.White;
            //CheckFolder.ForeColor = System.Drawing.Color.White;

            lblSourceerror.Visible = false;
            lblDestinationerror.Visible = false;

            //checkFile.Checked = false;
            //CheckFolder.Checked = true;

            //if (checkFile.Checked)
            //{
            //    CheckFolder.Checked = false;
            //}
            if (CheckFolder.Checked)
            {
                checkFile.Checked = false;
            }
            if (checkFile.Checked || CheckFolder.Checked)
            {
                btnZip.Enabled = true;
            }
            else
            {
                btnZip.Enabled = false;
            }


            txtSourceLoc.Text = "";
            txtDestinationLoc.Text = "";
        }

        //private void CheckFolder_CheckedChanged(object sender, EventArgs e)
        //{
        //    //checkFile.ForeColor = System.Drawing.Color.White;
        //    //CheckFolder.ForeColor = System.Drawing.Color.White;

        //    lblSourceerror.Visible = false;
        //    lblDestinationerror.Visible = false;

        //    checkFile.Checked = false;
        //    //CheckFolder.Checked = true;
        //    if (checkFile.Checked || CheckFolder.Checked)
        //    {
        //        btnZip.Enabled = true;
        //    }
        //    else
        //    {
        //        btnZip.Enabled = false;
        //    }


        //    txtSourceLoc.Text = "";
        //    txtDestinationLoc.Text = "";
        //}

        //private void checkFile_CheckedChanged(object sender, EventArgs e)
        //{
        //    //checkFile.ForeColor = System.Drawing.Color.White;
        //    //CheckFolder.ForeColor = System.Drawing.Color.White;

        //    lblSourceerror.Visible = false;
        //    lblDestinationerror.Visible = false;

        //    CheckFolder.Checked = false;
        //    //checkFile.Checked = true;
        //    if (checkFile.Checked || CheckFolder.Checked)
        //    {
        //        btnZip.Enabled = true;
        //    }
        //    else
        //    {
        //        btnZip.Enabled = false;
        //    }

        //    txtSourceLoc.Text = "";
        //    txtDestinationLoc.Text = "";
        //}

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            lblPasserror.Visible = false;
            lblpassincorrect.Visible = false;
            if (checkPass.Checked)
            {
                txtPass.Text = "";
                lblPass.Enabled = true;
                txtPass.Enabled = true;
            }
            else
            {
                txtPass.Text = "";
                lblPass.Enabled = false;
                txtPass.Enabled = false;

            }
        }

        private void txtSourceLoc_TextChanged(object sender, EventArgs e)
        {
            if (txtSourceLoc.Text == "")
            {
                lblSourceerror.Visible = true;
            }
            else
            {
                lblSourceerror.Visible = false;
            }
        }

        private void txtDestinationLoc_TextChanged(object sender, EventArgs e)
        {
            if (txtDestinationLoc.Text == "")
            {
                lblDestinationerror.Visible = true;
            }
            else
            {
                lblDestinationerror.Visible = false;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            if (btnZip.Enabled)
            {
                savefile.DefaultExt = ".zip";
                int ZipCounter = 1;
                savefile.FileName = "ZipFile" + ZipCounter.ToString();
            }
            else
            {
                savefile.FileName = "New File";
            }
            if (savefile.ShowDialog() == DialogResult.OK)
            {

                //while (savefile.CheckFileExists == true)
                //{
                //    ZipCounter += 1;
                //    savefile.FileName = "ZipFile" + ZipCounter.ToString();
                //}
                txtDestinationLoc.Text = savefile.FileName.ToString();
            }
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkFile.Checked && !CheckFolder.Checked)
                {
                    checkFile.ForeColor = System.Drawing.Color.Red;
                    CheckFolder.ForeColor = System.Drawing.Color.Red;
                }
                if (CheckFolder.Checked && txtDestinationLoc.Text != "" && txtSourceLoc.Text != "")
                {
                    //System.IO.Compression.ZipFile.CreateFromDirectory(txtSourceLoc.Text.ToString(), txtDestinationLoc.Text.ToString(), CompressionLevel.Optimal, true,Encoding.UTF8);
                    using (Ionic.Zip.ZipFile zips = new Ionic.Zip.ZipFile())
                    {
                        if (checkPass.Checked && txtPass.Text == "")
                        {
                            lblPasserror.Visible = true;
                        }
                        else if (checkPass.Checked && txtPass.Text != "")
                        {
                            zips.Password = txtPass.Text.ToString();
                        }
                        else
                        {
                            frmInfo Infoform = new frmInfo();
                            Infoform.spath = txtSourceLoc.Text.ToString();
                            Infoform.dpath = txtDestinationLoc.Text.ToString();
                            Infoform.ptxt = txtPass.Text.ToString();
                            Infoform.TypeDo = "Zip/folder zipped (ಠಿ_ಠ)";
                            Infoform.ShowDialog();

                            zips.AddDirectory(txtSourceLoc.Text.ToString());
                            zips.Save(txtDestinationLoc.Text.ToString());
                        }
                    }
                }
                else if (checkFile.Checked && txtSourceLoc.Text != "" && txtDestinationLoc.Text != "")
                {
                    using (Ionic.Zip.ZipFile Zip = new Ionic.Zip.ZipFile())
                    {
                        if (checkPass.Checked && txtPass.Text == "")
                        {
                            lblPasserror.Visible = true;
                        }
                        else if (checkPass.Checked && txtPass.Text != "")
                        {
                            Zip.Password = txtPass.Text.ToString();
                        }
                        else
                        {
                            Zip.AddFile(txtSourceLoc.Text.ToString(), "");
                            Zip.Save(txtDestinationLoc.Text.ToString());

                            frmInfo Infoform = new frmInfo();
                            Infoform.spath = txtSourceLoc.Text.ToString();
                            Infoform.dpath = txtDestinationLoc.Text.ToString();
                            Infoform.ptxt = txtPass.Text.ToString();
                            Infoform.TypeDo = "Zip/file zipped (ಠಿ_ಠ)";
                            Infoform.ShowDialog();

                            txtPass.Text = "";
                            txtSourceLoc.Text = "";
                            txtDestinationLoc.Text = "";

                        }

                    }
                }
                if (txtDestinationLoc.Text == "")
                {
                    lblDestinationerror.Visible = true;
                }
                if (txtSourceLoc.Text == "")
                {
                    lblSourceerror.Visible = true;
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString(), "Error occure", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnunzip_Click(object sender, EventArgs e)
        {
            if (txtSourceLoc.Text != "" && txtDestinationLoc.Text != "")
            {

                try
                {

                    using (Ionic.Zip.ZipFile zips = new Ionic.Zip.ZipFile(txtSourceLoc.Text.ToString()))
                    {
                        if (checkPass.Checked && txtPass.Text != "")
                        {
                            zips.Password = txtPass.Text.ToString();
                        }
                        zips.ExtractAll(txtDestinationLoc.Text.ToString(), ExtractExistingFileAction.OverwriteSilently);
                    }

                    frmInfo Infoform = new frmInfo();
                    Infoform.spath = txtDestinationLoc.Text.ToString();
                    Infoform.dpath = txtDestinationLoc.Text.ToString();
                    Infoform.ptxt = txtPass.Text.ToString();
                    Infoform.TypeDo = "Extract File (ಠಿ_ಠ)";
                    Infoform.ShowDialog();

                    txtPass.Text = "";
                    txtSourceLoc.Text = "";
                    txtDestinationLoc.Text = "";

                    //MessageBox.Show("Unzip was Succedssful", "Successfully Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    if (ex.Message == "Exception of type 'Ionic.Zip.BadPasswordException' was thrown." || ex.Message == "The password did not match.")
                    {
                        lblpassincorrect.Visible = true;
                        checkPass.Checked = true;
                        lblpassincorrect.Visible = true;
                        //txtPass.ForeColor = System.Drawing.Color.Red;
                        //txtPass.Text = "Incorrect password, try again..";
                    }
                    else
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error occure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (txtSourceLoc.Text == "")
            {
                lblSourceerror.Visible = true;
            }
            if (txtDestinationLoc.Text == "")
            {
                lblDestinationerror.Visible = true;
            }
        }
     
        int x;
        int y;
        private void topborderMoveClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void topborderMoveUp(object sender, MouseEventArgs e)
        {
            x = x - e.X;
            y = y - e.Y;
            this.Location = new Point(this.Location.X - x, this.Location.Y - y);
        }
    }
}