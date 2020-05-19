using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace FilesProcessApp
{
    public partial class FormFileProcess : Form
    {
        private string dir = "";
        public string Dir
        {
            get
            {
                return dir;
            }
            set
            {
                if (dir == value || !Directory.Exists(value))
                    return;

                dir = value;

                folder = new DirectoryInfo(dir);

                rightDesignate = false;
                right = "";
                    
                updateMatchedFiles();
            }
        }
        private DirectoryInfo folder;
        FileInfo[] files;
        private string left = "";
        private string right = "";
        bool rightDesignate = false;
        private Size border;
        private Size oldSize;
        bool sizeFirst = true;
        float rRightUp;
        float rLeft;

        public FormFileProcess()
        {
            InitializeComponent();

            Dir = tbPath.Text;
        }

        protected override void OnResize(EventArgs e)
        {
            if (sizeFirst)
            {
                int h = lbFileMatched.Height + lbFileUnmatched.Height;
                border.Height = this.Height - h;
                rRightUp = lbFileMatched.Height / (float)h;

                int w = gbFileName.Width + lbFileMatched.Width;
                border.Width = this.Width - w;
                rLeft = gbFileName.Width / (float)w;

                sizeFirst = false;
            }
            else
            {
                int h = this.Height - border.Height;
                int oldHeight = lbFileMatched.Height;
                lbFileMatched.Height = (int)(h * rRightUp);

                lbFileUnmatched.Top += lbFileMatched.Height - oldHeight;
                lbFileUnmatched.Height = h - lbFileMatched.Height;

                int w = this.Width - border.Width;
                int oldWidth = gbFileName.Width;
                gbFileName.Width = (int)(w * rLeft);

                int leftChange = gbFileName.Width - oldWidth;
                int rightNew = w - gbFileName.Width;

                lbFileMatched.Left += leftChange;
                lbFileMatched.Width = rightNew;

                lbFileUnmatched.Left += leftChange;
                lbFileUnmatched.Width = rightNew;

                tbPath.Width += leftChange;

                double inc = leftChange / 3.0;
                tbLeft.Width = tbMiddle.Width = tbRight.Width = tbLeftNew.Width =
                    tbMiddleNew.Width = tbRightNew.Width = tbLeft.Width + (int)inc;

                tbMiddle.Left = tbMiddleNew.Left = tbMiddle.Left + (int)inc;
                btChange.Left = tbRight.Left = tbRightNew.Left 
                              = tbRight.Left + (int)(inc * 2);
           }
            oldSize = this.Size;
        }

        private void updateMatchedFiles()
        {
            files = folder.GetFiles();

            if (files.Length == 0)
            {
                tsslStatus.Text = "No item here";
                return;
            }

            if (right == "" && !rightDesignate)
            { // right is not designate, so figure it out
                int i = 0;
                foreach (FileInfo file in files)
                { // skip hidden files
                    if (!IsHidden(file) )
                        break;
                    ++i;
                }
                if (i == files.Length)
                    return;

                tbRightNew.Text = tbRight.Text = right =
                    Path.GetExtension(files[i].Name).ToLower();
            }

            updateFileList();
        }

        static public bool IsHidden(FileInfo file)
        {
            return (file.Attributes & FileAttributes.Hidden) != 0;
        }

        private void updateFileList()
        {
            lbFileMatched.Items.Clear();
            lbFileUnmatched.Items.Clear();
            foreach (FileInfo file in files)
            {
                string f = file.Name;
                if (right != ".*")
                {
                    if (f.StartsWith(left) &&
                        f.EndsWith(right, StringComparison.InvariantCultureIgnoreCase) &&
                        !IsHidden(file))
                        lbFileMatched.Items.Add(f);
                    else
                        lbFileUnmatched.Items.Add(f);
                }
                else
                {
                    if (f.StartsWith(left) && !IsHidden(file))
                        lbFileMatched.Items.Add(f);
                    else
                        lbFileUnmatched.Items.Add(f);
                }
            }

            if (lbFileMatched.Items.Count != 0)
                lbFileMatched.SelectedIndex = 0;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (lbFileMatched.Items.Count == 0)
            {
                MessageBox.Show("No file selected!");
                return;
            }

            btChange.Enabled = false;
//            changeFileName();
            replaceFileName();
            btChange.Enabled = true;

            //if (right != ".*")
            //{
            //    tbLeft.Text = tbRight.Text = tbLeftNew.Text = tbRightNew.Text = "";
            //    rightDesignate = false;
            //}
            updateMatchedFiles();
        }

        private void changeFileName()
        {
            int inc = 0;
            if (tbMiddleNew.Text != tbMiddle.Text)
            {
                int neww = int.Parse(tbMiddleNew.Text);
                int old = int.Parse(tbMiddle.Text);
                inc = neww - old;
            }

            foreach (string fileName in lbFileMatched.Items)
            {
                FileInfo file = new FileInfo(Path.Combine(dir, fileName));
                string mid;
                if (right != ".*")
                    mid = fileName.Substring(
                        left.Length, fileName.Length - left.Length - right.Length);
                else
                    mid = fileName.Substring(
                         left.Length, fileName.LastIndexOf(".") - left.Length);
                if (inc != 0)
                {
                    string format = "D" + tbMiddleNew.Text.Length.ToString();
                    mid = (int.Parse(mid) + inc).ToString(format);
                }
                string newFileName;
                if (right != ".*")
                    newFileName = tbLeftNew.Text + mid + tbRightNew.Text;
                else
                    newFileName = tbLeftNew.Text + mid + 
                        fileName.Remove(0, fileName.LastIndexOf("."));
                file.MoveTo(Path.Combine(file.DirectoryName, newFileName));
            }
        }

        private void replaceFileName()
        {
            if (tbFind.Text.Length == 0)
                return;

            foreach (string fileName in lbFileMatched.Items)
            {
                FileInfo file = new FileInfo(Path.Combine(dir, fileName));
                StringBuilder sb = new StringBuilder(fileName);
                sb.Replace(tbFind.Text, tbReplace.Text);
                string newFileName = sb.ToString();
                file.MoveTo(Path.Combine(file.DirectoryName, newFileName));
            }
        }

        private void changePictureNameByDateShot()
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            foreach (string fn in lbFileMatched.Items)
            {
                string on = System.IO.Path.Combine(dir, fn);
                string t,
                       exifDTOrig = "",
                       dateTime = "";
                try
                {
                    using (Image image = Image.FromFile(on))
                    {
                        foreach (PropertyItem pi in image.PropertyItems)
                        {
                            if (pi.Id == 0x0132)
                                dateTime = encoding.GetString(pi.Value);
                            if (pi.Id == 0x9003)
                            {
                                exifDTOrig = encoding.GetString(pi.Value);
                                break;
                            }
                        }
                    }
                }
                catch
                {
                    continue;
                }
                if (exifDTOrig != "")
                    t = exifDTOrig;
                else
                    t = dateTime;
                t = t.Substring(0, 19);
                DateTime time = DateTime.ParseExact(t, "yyyy:MM:dd hh:mm:ss",
                    CultureInfo.InvariantCulture);
                t = time.ToString("yyyy-MM-dd_hh.mm.ss");
                string nn;
                nn = t + right;
                int i = 0;
                while (true)
                {
                    try
                    {
                        File.Move(on, Path.Combine(dir, nn));
                        break;
                    }
                    catch (IOException)
                    {
                        nn = t + "_" + (i++) + right;
                        continue;
                    }
                }
            }
        }
        private void changePictureNameByModifiedDate()
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            foreach (string fn in lbFileMatched.Items)
            {
                string on = System.IO.Path.Combine(dir, fn);
                string t;
                FileInfo fi = new FileInfo(on);
                DateTime time = fi.LastWriteTime;
                t = time.ToString("yyyy-MM-dd_hh.mm.ss");
                string nn;
                nn = t + right;
                int i = 0;
                while (true)
                {
                    try
                    {
                        File.Move(on, Path.Combine(dir, nn));
                        break;
                    }
                    catch (IOException)
                    {
                        nn = t + "_" + (i++) + right;
                        continue;
                    }
                }
            }
        }

        private void tbLeft_TextChanged(object sender, EventArgs e)
        {
            if (left != tbLeft.Text)
            {
                left = tbLeft.Text;
                tbLeftNew.Text = left;
                rightDesignate = true;
                updateMatchedFiles();
            }
        }

        private void tbRight_TextChanged(object sender, EventArgs e)
        {
            if (right != tbRight.Text)
            {
                right = tbRight.Text;
                tbRightNew.Text = right;
                rightDesignate = true;
                updateMatchedFiles();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            if (dlg.ShowDialog() == DialogResult.OK)
                Dir = dlg.SelectedPath;
        }

        private void txtBoxPath_TextChanged(object sender, EventArgs e)
        {
            Dir = tbPath.Text;
        }


        private void lbFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFileMatched.SelectedItem == null)
                return;

            string f = (string)lbFileMatched.SelectedItem;
            if (right != ".*")
                tbMiddleNew.Text = tbMiddle.Text = f.Substring(
                    left.Length, f.Length - left.Length - right.Length);
            else
                tbMiddleNew.Text = tbMiddle.Text = f.Substring(
                    left.Length, f.LastIndexOf(".") - left.Length);
        }

        private void lbFileUnmatched_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFileUnmatched.SelectedItem == null)
                return;

            string t = System.IO.Path.GetExtension((string)(lbFileUnmatched.SelectedItem));
            if (right != t)
                tbRightNew.Text = tbRight.Text = right = t;
                    
            updateFileList();
        }

        private void ChangePictureNameByDateShot_Click(object sender, EventArgs e)
        {
            if (lbFileMatched.Items.Count == 0)
            {
                MessageBox.Show("No file selected!");
                return;
            }

            btChange.Enabled = false;
            btChangePictureNameByDateShot.Enabled = false;
            changePictureNameByDateShot();
            btChange.Enabled = true;
            btChangePictureNameByDateShot.Enabled = true;

            if (right != ".*")
            {
                tbLeft.Text = tbRight.Text = tbLeftNew.Text = tbRightNew.Text = "";
                rightDesignate = false;
            }
            updateMatchedFiles();
        }
        private void btChangePictureNameByModifiedDate_Click(object sender, EventArgs e)
        {
            if (lbFileMatched.Items.Count == 0)
            {
                MessageBox.Show("No file selected!");
                return;
            }

            btChange.Enabled = false;
            btChangePictureNameByModifiedDate.Enabled = false;
            changePictureNameByModifiedDate();
            btChange.Enabled = true;
            btChangePictureNameByDateShot.Enabled = true;

            if (right != ".*")
            {
                tbLeft.Text = tbRight.Text = tbLeftNew.Text = tbRightNew.Text = "";
                rightDesignate = false;
            }
            updateMatchedFiles();

        }

        private void on_btExtract_Clicked(object sender, EventArgs e)
        {
            int spacing = 0;
            try
            {
                spacing = int.Parse(textBoxValue.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Input a integer greater than 1 before click the button.");
                return;
            }
            finally
            {
            }

            string dstFolder = System.IO.Path.Combine(dir, spacing.ToString());
            int n = FileProcess.ExtractFiles(dir, dstFolder, spacing);
            MessageBox.Show(n.ToString() + "files have been move to " + dstFolder);
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (textBoxInserted.Text=="")
            {
                MessageBox.Show("Please specify WHAT you want to insert!");
                return;
            }
            if (textBoxPosition.Text == "")
            {
                MessageBox.Show("Please specify WHERE you want to insert!");
                return;
            }

            int position;
            try
            {
                position = int.Parse(textBoxPosition.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Make sure POSITION is a NUMBER.");
                return;
            }
            finally
            {
            }

            if (lbFileMatched.Items.Count == 0)
            {
                MessageBox.Show("No file selected!");
                return;
            }

            //System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            foreach (string fn in lbFileMatched.Items)
            {
                string on = System.IO.Path.Combine(dir, fn);
                string left, right, nn;
                left = fn.Substring(0, position);
                right = fn.Substring(position);
                nn = left + textBoxInserted.Text + right;

                File.Move(on, Path.Combine(dir, nn));

            }

            updateMatchedFiles();
        }
    }
}