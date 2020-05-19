namespace FilesProcessApp
{
    partial class FormFileProcess
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btChange = new System.Windows.Forms.Button();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.lbFileMatched = new System.Windows.Forms.ListBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btExtract = new System.Windows.Forms.Button();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.label_extract = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.gbFileName = new System.Windows.Forms.GroupBox();
            this.btChangePictureNameByModifiedDate = new System.Windows.Forms.Button();
            this.labelFind = new System.Windows.Forms.Label();
            this.labelReplace = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btChangePictureNameByDateShot = new System.Windows.Forms.Button();
            this.labelReplace1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.tbRightNew = new System.Windows.Forms.TextBox();
            this.tbLeftNew = new System.Windows.Forms.TextBox();
            this.tbMiddleNew = new System.Windows.Forms.TextBox();
            this.tbMiddle = new System.Windows.Forms.TextBox();
            this.groupBoxExtract = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFileUnmatched = new System.Windows.Forms.ListBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInserted = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.labelAfter = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbFileName.SuspendLayout();
            this.groupBoxExtract.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(370, 229);
            this.btChange.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(126, 48);
            this.btChange.TabIndex = 6;
            this.btChange.Text = "&Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.Change_Click);
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(12, 77);
            this.tbLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(156, 31);
            this.tbLeft.TabIndex = 2;
            this.tbLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLeft.TextChanged += new System.EventHandler(this.tbLeft_TextChanged);
            // 
            // lbFileMatched
            // 
            this.lbFileMatched.FormattingEnabled = true;
            this.lbFileMatched.ItemHeight = 25;
            this.lbFileMatched.Location = new System.Drawing.Point(572, 106);
            this.lbFileMatched.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbFileMatched.Name = "lbFileMatched";
            this.lbFileMatched.Size = new System.Drawing.Size(548, 304);
            this.lbFileMatched.TabIndex = 1000;
            this.lbFileMatched.SelectedIndexChanged += new System.EventHandler(this.lbFileList_SelectedIndexChanged);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(90, 56);
            this.tbPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(466, 31);
            this.tbPath.TabIndex = 1;
            this.tbPath.TextChanged += new System.EventHandler(this.txtBoxPath_TextChanged);
            // 
            // btExtract
            // 
            this.btExtract.Location = new System.Drawing.Point(16, 42);
            this.btExtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btExtract.Name = "btExtract";
            this.btExtract.Size = new System.Drawing.Size(146, 48);
            this.btExtract.TabIndex = 100;
            this.btExtract.Text = "&Extract";
            this.btExtract.UseVisualStyleBackColor = true;
            this.btExtract.Click += new System.EventHandler(this.on_btExtract_Clicked);
            // 
            // tbRight
            // 
            this.tbRight.AcceptsReturn = true;
            this.tbRight.Location = new System.Drawing.Point(370, 77);
            this.tbRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(156, 31);
            this.tbRight.TabIndex = 4;
            this.tbRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRight.TextChanged += new System.EventHandler(this.tbRight_TextChanged);
            // 
            // label_extract
            // 
            this.label_extract.AutoSize = true;
            this.label_extract.Location = new System.Drawing.Point(176, 52);
            this.label_extract.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_extract.Name = "label_extract";
            this.label_extract.Size = new System.Drawing.Size(118, 25);
            this.label_extract.TabIndex = 10;
            this.label_extract.Text = "1 file out of";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(354, 42);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(122, 31);
            this.textBoxValue.TabIndex = 11;
            this.textBoxValue.Text = "3";
            this.textBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbFileName
            // 
            this.gbFileName.Controls.Add(this.btChangePictureNameByModifiedDate);
            this.gbFileName.Controls.Add(this.labelFind);
            this.gbFileName.Controls.Add(this.labelReplace);
            this.gbFileName.Controls.Add(this.label6);
            this.gbFileName.Controls.Add(this.label5);
            this.gbFileName.Controls.Add(this.label4);
            this.gbFileName.Controls.Add(this.btChangePictureNameByDateShot);
            this.gbFileName.Controls.Add(this.labelReplace1);
            this.gbFileName.Controls.Add(this.label2);
            this.gbFileName.Controls.Add(this.tbReplace);
            this.gbFileName.Controls.Add(this.tbFind);
            this.gbFileName.Controls.Add(this.btChange);
            this.gbFileName.Controls.Add(this.tbRightNew);
            this.gbFileName.Controls.Add(this.tbLeftNew);
            this.gbFileName.Controls.Add(this.tbMiddleNew);
            this.gbFileName.Controls.Add(this.tbMiddle);
            this.gbFileName.Controls.Add(this.tbLeft);
            this.gbFileName.Controls.Add(this.tbRight);
            this.gbFileName.Location = new System.Drawing.Point(8, 112);
            this.gbFileName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbFileName.Name = "gbFileName";
            this.gbFileName.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbFileName.Size = new System.Drawing.Size(552, 500);
            this.gbFileName.TabIndex = 200;
            this.gbFileName.TabStop = false;
            this.gbFileName.Text = "File Name";
            // 
            // btChangePictureNameByModifiedDate
            // 
            this.btChangePictureNameByModifiedDate.Location = new System.Drawing.Point(6, 431);
            this.btChangePictureNameByModifiedDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btChangePictureNameByModifiedDate.Name = "btChangePictureNameByModifiedDate";
            this.btChangePictureNameByModifiedDate.Size = new System.Drawing.Size(518, 48);
            this.btChangePictureNameByModifiedDate.TabIndex = 1015;
            this.btChangePictureNameByModifiedDate.Text = "Change Picture Name By Modified Date";
            this.btChangePictureNameByModifiedDate.UseVisualStyleBackColor = true;
            this.btChangePictureNameByModifiedDate.Click += new System.EventHandler(this.btChangePictureNameByModifiedDate_Click);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(26, 252);
            this.labelFind.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(54, 25);
            this.labelFind.TabIndex = 1014;
            this.labelFind.Text = "Find";
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(200, 252);
            this.labelReplace.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(91, 25);
            this.labelReplace.TabIndex = 1013;
            this.labelReplace.Text = "Replace";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 1012;
            this.label6.Text = "Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 1011;
            this.label5.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 1010;
            this.label4.Text = "Replace";
            // 
            // btChangePictureNameByDateShot
            // 
            this.btChangePictureNameByDateShot.Location = new System.Drawing.Point(6, 371);
            this.btChangePictureNameByDateShot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btChangePictureNameByDateShot.Name = "btChangePictureNameByDateShot";
            this.btChangePictureNameByDateShot.Size = new System.Drawing.Size(518, 48);
            this.btChangePictureNameByDateShot.TabIndex = 1003;
            this.btChangePictureNameByDateShot.Text = "Change Picture Name By Date Shot";
            this.btChangePictureNameByDateShot.UseVisualStyleBackColor = true;
            this.btChangePictureNameByDateShot.Click += new System.EventHandler(this.ChangePictureNameByDateShot_Click);
            // 
            // labelReplace1
            // 
            this.labelReplace1.AutoSize = true;
            this.labelReplace1.Location = new System.Drawing.Point(26, 179);
            this.labelReplace1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReplace1.Name = "labelReplace1";
            this.labelReplace1.Size = new System.Drawing.Size(91, 25);
            this.labelReplace1.TabIndex = 1009;
            this.labelReplace1.Text = "Replace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1005;
            this.label2.Text = "Inc/Dec";
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(190, 285);
            this.tbReplace.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(156, 31);
            this.tbReplace.TabIndex = 1008;
            this.tbReplace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(6, 285);
            this.tbFind.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(156, 31);
            this.tbFind.TabIndex = 1007;
            this.tbFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRightNew
            // 
            this.tbRightNew.Location = new System.Drawing.Point(370, 135);
            this.tbRightNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbRightNew.Name = "tbRightNew";
            this.tbRightNew.Size = new System.Drawing.Size(156, 31);
            this.tbRightNew.TabIndex = 1006;
            this.tbRightNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLeftNew
            // 
            this.tbLeftNew.Location = new System.Drawing.Point(12, 135);
            this.tbLeftNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbLeftNew.Name = "tbLeftNew";
            this.tbLeftNew.Size = new System.Drawing.Size(156, 31);
            this.tbLeftNew.TabIndex = 1005;
            this.tbLeftNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMiddleNew
            // 
            this.tbMiddleNew.Location = new System.Drawing.Point(190, 135);
            this.tbMiddleNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMiddleNew.Name = "tbMiddleNew";
            this.tbMiddleNew.Size = new System.Drawing.Size(156, 31);
            this.tbMiddleNew.TabIndex = 5;
            this.tbMiddleNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMiddle
            // 
            this.tbMiddle.Location = new System.Drawing.Point(190, 77);
            this.tbMiddle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.ReadOnly = true;
            this.tbMiddle.Size = new System.Drawing.Size(156, 31);
            this.tbMiddle.TabIndex = 3;
            this.tbMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxExtract
            // 
            this.groupBoxExtract.Controls.Add(this.textBoxValue);
            this.groupBoxExtract.Controls.Add(this.btExtract);
            this.groupBoxExtract.Controls.Add(this.label_extract);
            this.groupBoxExtract.Location = new System.Drawing.Point(8, 625);
            this.groupBoxExtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxExtract.Name = "groupBoxExtract";
            this.groupBoxExtract.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxExtract.Size = new System.Drawing.Size(552, 102);
            this.groupBoxExtract.TabIndex = 300;
            this.groupBoxExtract.TabStop = false;
            this.groupBoxExtract.Text = "File Extract";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1001;
            this.label1.Text = "Path: ";
            // 
            // lbFileUnmatched
            // 
            this.lbFileUnmatched.FormattingEnabled = true;
            this.lbFileUnmatched.ItemHeight = 25;
            this.lbFileUnmatched.Location = new System.Drawing.Point(572, 485);
            this.lbFileUnmatched.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbFileUnmatched.Name = "lbFileUnmatched";
            this.lbFileUnmatched.Size = new System.Drawing.Size(548, 229);
            this.lbFileUnmatched.TabIndex = 1002;
            this.lbFileUnmatched.SelectedIndexChanged += new System.EventHandler(this.lbFileUnmatched_SelectedIndexChanged);
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 934);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.ssStatus.Size = new System.Drawing.Size(1146, 22);
            this.ssStatus.TabIndex = 1004;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(0, 12);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 454);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 1013;
            this.label7.Text = "Unmatched Files";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 1014;
            this.label8.Text = "Matched Files";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInserted);
            this.groupBox1.Controls.Add(this.textBoxPosition);
            this.groupBox1.Controls.Add(this.btInsert);
            this.groupBox1.Controls.Add(this.labelAfter);
            this.groupBox1.Location = new System.Drawing.Point(8, 769);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(552, 102);
            this.groupBox1.TabIndex = 301;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // textBoxInserted
            // 
            this.textBoxInserted.Location = new System.Drawing.Point(174, 42);
            this.textBoxInserted.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxInserted.Name = "textBoxInserted";
            this.textBoxInserted.Size = new System.Drawing.Size(122, 31);
            this.textBoxInserted.TabIndex = 101;
            this.textBoxInserted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(406, 42);
            this.textBoxPosition.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(70, 31);
            this.textBoxPosition.TabIndex = 11;
            this.textBoxPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(16, 42);
            this.btInsert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(146, 48);
            this.btInsert.TabIndex = 100;
            this.btInsert.Text = "&Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Location = new System.Drawing.Point(312, 52);
            this.labelAfter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(55, 25);
            this.labelAfter.TabIndex = 10;
            this.labelAfter.Text = "after";
            // 
            // FormFileProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 956);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.lbFileUnmatched);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxExtract);
            this.Controls.Add(this.gbFileName);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lbFileMatched);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormFileProcess";
            this.Text = "File Process";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbFileName.ResumeLayout(false);
            this.gbFileName.PerformLayout();
            this.groupBoxExtract.ResumeLayout(false);
            this.groupBoxExtract.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.ListBox lbFileMatched;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btExtract;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.Label label_extract;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.GroupBox gbFileName;
        private System.Windows.Forms.GroupBox groupBoxExtract;
        private System.Windows.Forms.TextBox tbMiddleNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMiddle;
        private System.Windows.Forms.TextBox tbRightNew;
        private System.Windows.Forms.TextBox tbLeftNew;
        private System.Windows.Forms.ListBox lbFileUnmatched;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btChangePictureNameByDateShot;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelReplace1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btChangePictureNameByModifiedDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInserted;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label labelAfter;
    }
}

