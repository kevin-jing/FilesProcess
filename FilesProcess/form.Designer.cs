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
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.labelAfter = new System.Windows.Forms.Label();
            this.textBoxInserted = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gbFileName.SuspendLayout();
            this.groupBoxExtract.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(185, 110);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(63, 23);
            this.btChange.TabIndex = 6;
            this.btChange.Text = "&Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.Change_Click);
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(6, 37);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(80, 21);
            this.tbLeft.TabIndex = 2;
            this.tbLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLeft.TextChanged += new System.EventHandler(this.tbLeft_TextChanged);
            // 
            // lbFileMatched
            // 
            this.lbFileMatched.FormattingEnabled = true;
            this.lbFileMatched.ItemHeight = 12;
            this.lbFileMatched.Location = new System.Drawing.Point(286, 51);
            this.lbFileMatched.Name = "lbFileMatched";
            this.lbFileMatched.Size = new System.Drawing.Size(276, 148);
            this.lbFileMatched.TabIndex = 1000;
            this.lbFileMatched.SelectedIndexChanged += new System.EventHandler(this.lbFileList_SelectedIndexChanged);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(45, 27);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(235, 21);
            this.tbPath.TabIndex = 1;
            this.tbPath.TextChanged += new System.EventHandler(this.txtBoxPath_TextChanged);
            // 
            // btExtract
            // 
            this.btExtract.Location = new System.Drawing.Point(8, 20);
            this.btExtract.Name = "btExtract";
            this.btExtract.Size = new System.Drawing.Size(73, 23);
            this.btExtract.TabIndex = 100;
            this.btExtract.Text = "&Extract";
            this.btExtract.UseVisualStyleBackColor = true;
            this.btExtract.Click += new System.EventHandler(this.on_btExtract_Clicked);
            // 
            // tbRight
            // 
            this.tbRight.AcceptsReturn = true;
            this.tbRight.Location = new System.Drawing.Point(185, 37);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(80, 21);
            this.tbRight.TabIndex = 4;
            this.tbRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRight.TextChanged += new System.EventHandler(this.tbRight_TextChanged);
            // 
            // label_extract
            // 
            this.label_extract.AutoSize = true;
            this.label_extract.Location = new System.Drawing.Point(88, 25);
            this.label_extract.Name = "label_extract";
            this.label_extract.Size = new System.Drawing.Size(98, 13);
            this.label_extract.TabIndex = 10;
            this.label_extract.Text = "1 file out of";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(177, 20);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(63, 21);
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
            this.gbFileName.Location = new System.Drawing.Point(4, 54);
            this.gbFileName.Name = "gbFileName";
            this.gbFileName.Size = new System.Drawing.Size(276, 240);
            this.gbFileName.TabIndex = 200;
            this.gbFileName.TabStop = false;
            this.gbFileName.Text = "File Name";
            // 
            // btChangePictureNameByModifiedDate
            // 
            this.btChangePictureNameByModifiedDate.Location = new System.Drawing.Point(3, 207);
            this.btChangePictureNameByModifiedDate.Name = "btChangePictureNameByModifiedDate";
            this.btChangePictureNameByModifiedDate.Size = new System.Drawing.Size(259, 23);
            this.btChangePictureNameByModifiedDate.TabIndex = 1015;
            this.btChangePictureNameByModifiedDate.Text = "Change Picture Name By Modified Date";
            this.btChangePictureNameByModifiedDate.UseVisualStyleBackColor = true;
            this.btChangePictureNameByModifiedDate.Click += new System.EventHandler(this.btChangePictureNameByModifiedDate_Click);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(13, 121);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(35, 13);
            this.labelFind.TabIndex = 1014;
            this.labelFind.Text = "Find";
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(100, 121);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(56, 13);
            this.labelReplace.TabIndex = 1013;
            this.labelReplace.Text = "Replace";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1012;
            this.label6.Text = "Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1011;
            this.label5.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1010;
            this.label4.Text = "Replace";
            // 
            // btChangePictureNameByDateShot
            // 
            this.btChangePictureNameByDateShot.Location = new System.Drawing.Point(3, 178);
            this.btChangePictureNameByDateShot.Name = "btChangePictureNameByDateShot";
            this.btChangePictureNameByDateShot.Size = new System.Drawing.Size(259, 23);
            this.btChangePictureNameByDateShot.TabIndex = 1003;
            this.btChangePictureNameByDateShot.Text = "Change Picture Name By Date Shot";
            this.btChangePictureNameByDateShot.UseVisualStyleBackColor = true;
            this.btChangePictureNameByDateShot.Click += new System.EventHandler(this.ChangePictureNameByDateShot_Click);
            // 
            // labelReplace1
            // 
            this.labelReplace1.AutoSize = true;
            this.labelReplace1.Location = new System.Drawing.Point(13, 86);
            this.labelReplace1.Name = "labelReplace1";
            this.labelReplace1.Size = new System.Drawing.Size(56, 13);
            this.labelReplace1.TabIndex = 1009;
            this.labelReplace1.Text = "Replace";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1005;
            this.label2.Text = "Inc/Dec";

            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(95, 137);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(80, 21);
            this.tbReplace.TabIndex = 1008;
            this.tbReplace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(3, 137);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(80, 21);
            this.tbFind.TabIndex = 1007;
            this.tbFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRightNew
            // 
            this.tbRightNew.Location = new System.Drawing.Point(185, 65);
            this.tbRightNew.Name = "tbRightNew";
            this.tbRightNew.Size = new System.Drawing.Size(80, 21);
            this.tbRightNew.TabIndex = 1006;
            this.tbRightNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLeftNew
            // 
            this.tbLeftNew.Location = new System.Drawing.Point(6, 65);
            this.tbLeftNew.Name = "tbLeftNew";
            this.tbLeftNew.Size = new System.Drawing.Size(80, 21);
            this.tbLeftNew.TabIndex = 1005;
            this.tbLeftNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMiddleNew
            // 
            this.tbMiddleNew.Location = new System.Drawing.Point(95, 65);
            this.tbMiddleNew.Name = "tbMiddleNew";
            this.tbMiddleNew.Size = new System.Drawing.Size(80, 21);
            this.tbMiddleNew.TabIndex = 5;
            this.tbMiddleNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMiddle
            // 
            this.tbMiddle.Location = new System.Drawing.Point(95, 37);
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.ReadOnly = true;
            this.tbMiddle.Size = new System.Drawing.Size(80, 21);
            this.tbMiddle.TabIndex = 3;
            this.tbMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxExtract
            // 
            this.groupBoxExtract.Controls.Add(this.textBoxValue);
            this.groupBoxExtract.Controls.Add(this.btExtract);
            this.groupBoxExtract.Controls.Add(this.label_extract);
            this.groupBoxExtract.Location = new System.Drawing.Point(4, 300);
            this.groupBoxExtract.Name = "groupBoxExtract";
            this.groupBoxExtract.Size = new System.Drawing.Size(276, 49);
            this.groupBoxExtract.TabIndex = 300;
            this.groupBoxExtract.TabStop = false;
            this.groupBoxExtract.Text = "File Extract";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1001;
            this.label1.Text = "Path: ";
            // 
            // lbFileUnmatched
            // 
            this.lbFileUnmatched.FormattingEnabled = true;
            this.lbFileUnmatched.ItemHeight = 12;
            this.lbFileUnmatched.Location = new System.Drawing.Point(286, 233);
            this.lbFileUnmatched.Name = "lbFileUnmatched";
            this.lbFileUnmatched.Size = new System.Drawing.Size(276, 112);
            this.lbFileUnmatched.TabIndex = 1002;
            this.lbFileUnmatched.SelectedIndexChanged += new System.EventHandler(this.lbFileUnmatched_SelectedIndexChanged);
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 437);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(573, 22);
            this.ssStatus.TabIndex = 1004;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 1013;
            this.label7.Text = "Unmatched Files";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 1014;
            this.label8.Text = "Matched Files";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInserted);
            this.groupBox1.Controls.Add(this.textBoxPosition);
            this.groupBox1.Controls.Add(this.btInsert);
            this.groupBox1.Controls.Add(this.labelAfter);
            this.groupBox1.Location = new System.Drawing.Point(4, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 49);
            this.groupBox1.TabIndex = 301;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(203, 20);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(37, 21);
            this.textBoxPosition.TabIndex = 11;
            this.textBoxPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(8, 20);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(73, 23);
            this.btInsert.TabIndex = 100;
            this.btInsert.Text = "&Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Location = new System.Drawing.Point(156, 25);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(42, 13);
            this.labelAfter.TabIndex = 10;
            this.labelAfter.Text = "after";
            // 
            // textBoxInserted
            // 
            this.textBoxInserted.Location = new System.Drawing.Point(87, 20);
            this.textBoxInserted.Name = "textBoxInserted";
            this.textBoxInserted.Size = new System.Drawing.Size(63, 21);
            this.textBoxInserted.TabIndex = 101;
            this.textBoxInserted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormFileProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 459);
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

