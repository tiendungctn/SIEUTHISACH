namespace SieuThiSach.SystemForm
{
    partial class frmHistory
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dStartDate = new System.Windows.Forms.DateTimePicker();
            this.dEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.txtID2 = new System.Windows.Forms.TextBox();
            this.txtID1 = new System.Windows.Forms.TextBox();
            this.lblID1 = new System.Windows.Forms.Label();
            this.lblID2 = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(670, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dStartDate
            // 
            this.dStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dStartDate.Location = new System.Drawing.Point(50, 481);
            this.dStartDate.Name = "dStartDate";
            this.dStartDate.Size = new System.Drawing.Size(101, 20);
            this.dStartDate.TabIndex = 2;
            // 
            // dEndDate
            // 
            this.dEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dEndDate.Location = new System.Drawing.Point(177, 481);
            this.dEndDate.Name = "dEndDate";
            this.dEndDate.Size = new System.Drawing.Size(101, 20);
            this.dEndDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(589, 479);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Lọc";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHistory.FullRowSelect = true;
            this.lstHistory.GridLines = true;
            this.lstHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstHistory.Location = new System.Drawing.Point(12, 12);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(732, 460);
            this.lstHistory.TabIndex = 5;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            this.lstHistory.View = System.Windows.Forms.View.Details;
            this.lstHistory.DoubleClick += new System.EventHandler(this.lstHistory_DoubleClick);
            // 
            // txtID2
            // 
            this.txtID2.Location = new System.Drawing.Point(499, 481);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(84, 20);
            this.txtID2.TabIndex = 6;
            this.txtID2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID2_KeyPress);
            // 
            // txtID1
            // 
            this.txtID1.Location = new System.Drawing.Point(343, 481);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(84, 20);
            this.txtID1.TabIndex = 7;
            // 
            // lblID1
            // 
            this.lblID1.AutoSize = true;
            this.lblID1.Location = new System.Drawing.Point(283, 484);
            this.lblID1.Name = "lblID1";
            this.lblID1.Size = new System.Drawing.Size(24, 13);
            this.lblID1.TabIndex = 8;
            this.lblID1.Text = "ID1";
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.Location = new System.Drawing.Point(431, 484);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(24, 13);
            this.lblID2.TabIndex = 9;
            this.lblID2.Text = "ID2";
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(547, 510);
            this.txtPage.Name = "txtPage";
            this.txtPage.ReadOnly = true;
            this.txtPage.Size = new System.Drawing.Size(18, 20);
            this.txtPage.TabIndex = 10;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPage.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(670, 508);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(425, 508);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trang:";
            // 
            // frmHistory
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(756, 538);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.lblID2);
            this.Controls.Add(this.lblID1);
            this.Controls.Add(this.txtID1);
            this.Controls.Add(this.txtID2);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dEndDate);
            this.Controls.Add(this.dStartDate);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHistory_FormClosed);
            this.Load += new System.EventHandler(this.frmHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dStartDate;
        private System.Windows.Forms.DateTimePicker dEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.ListView lstHistory;
        public System.Windows.Forms.TextBox txtID2;
        private System.Windows.Forms.TextBox txtID1;
        private System.Windows.Forms.Label lblID1;
        private System.Windows.Forms.Label lblID2;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
    }
}