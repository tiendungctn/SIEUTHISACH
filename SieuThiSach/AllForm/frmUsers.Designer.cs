namespace SieuThiSach
{
    partial class frmUsers
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
            this.grButton1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grDetail = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.dExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.chkUsingCheck = new System.Windows.Forms.CheckBox();
            this.chkChangePWDLogon = new System.Windows.Forms.CheckBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBranchID = new System.Windows.Forms.TextBox();
            this.TxtStaffId = new System.Windows.Forms.TextBox();
            this.lblNameBranch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpiredDate = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grButton1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grButton1
            // 
            this.grButton1.Controls.Add(this.btnExit);
            this.grButton1.Controls.Add(this.btnExcel);
            this.grButton1.Controls.Add(this.btnHistory);
            this.grButton1.Controls.Add(this.btnPrint);
            this.grButton1.Controls.Add(this.btnFind);
            this.grButton1.Controls.Add(this.btnDel);
            this.grButton1.Controls.Add(this.btnEdit);
            this.grButton1.Controls.Add(this.btnAdd);
            this.grButton1.Location = new System.Drawing.Point(620, 11);
            this.grButton1.Margin = new System.Windows.Forms.Padding(2);
            this.grButton1.Name = "grButton1";
            this.grButton1.Padding = new System.Windows.Forms.Padding(2);
            this.grButton1.Size = new System.Drawing.Size(149, 280);
            this.grButton1.TabIndex = 3;
            this.grButton1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(13, 241);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcel.Location = new System.Drawing.Point(13, 209);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(122, 28);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHistory.Location = new System.Drawing.Point(13, 177);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(122, 28);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "Lịch Sử";
            this.btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Location = new System.Drawing.Point(13, 145);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 28);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFind.Location = new System.Drawing.Point(13, 113);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(122, 28);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDel.Location = new System.Drawing.Point(13, 81);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(122, 28);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Location = new System.Drawing.Point(13, 49);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(13, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 24;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(596, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // grDetail
            // 
            this.grDetail.Controls.Add(this.btnCancel);
            this.grDetail.Controls.Add(this.btnCommit);
            this.grDetail.Controls.Add(this.dExpiredDate);
            this.grDetail.Controls.Add(this.chkUsingCheck);
            this.grDetail.Controls.Add(this.chkChangePWDLogon);
            this.grDetail.Controls.Add(this.TxtUserName);
            this.grDetail.Controls.Add(this.lblName);
            this.grDetail.Controls.Add(this.txtBranchID);
            this.grDetail.Controls.Add(this.TxtStaffId);
            this.grDetail.Controls.Add(this.lblNameBranch);
            this.grDetail.Controls.Add(this.label1);
            this.grDetail.Controls.Add(this.lblExpiredDate);
            this.grDetail.Controls.Add(this.lblStaffID);
            this.grDetail.Controls.Add(this.TxtUserId);
            this.grDetail.Controls.Add(this.lblUserID);
            this.grDetail.Location = new System.Drawing.Point(11, 295);
            this.grDetail.Margin = new System.Windows.Forms.Padding(2);
            this.grDetail.Name = "grDetail";
            this.grDetail.Padding = new System.Windows.Forms.Padding(2);
            this.grDetail.Size = new System.Drawing.Size(758, 96);
            this.grDetail.TabIndex = 4;
            this.grDetail.TabStop = false;
            this.grDetail.Text = "Thông tin chi tiết";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(622, 55);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCommit.Location = new System.Drawing.Point(622, 23);
            this.btnCommit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(122, 28);
            this.btnCommit.TabIndex = 15;
            this.btnCommit.Text = "Xác nhận";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // dExpiredDate
            // 
            this.dExpiredDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dExpiredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dExpiredDate.Location = new System.Drawing.Point(466, 24);
            this.dExpiredDate.Margin = new System.Windows.Forms.Padding(2);
            this.dExpiredDate.Name = "dExpiredDate";
            this.dExpiredDate.Size = new System.Drawing.Size(130, 23);
            this.dExpiredDate.TabIndex = 10;
            // 
            // chkUsingCheck
            // 
            this.chkUsingCheck.AutoSize = true;
            this.chkUsingCheck.Location = new System.Drawing.Point(534, 66);
            this.chkUsingCheck.Margin = new System.Windows.Forms.Padding(2);
            this.chkUsingCheck.Name = "chkUsingCheck";
            this.chkUsingCheck.Size = new System.Drawing.Size(62, 17);
            this.chkUsingCheck.TabIndex = 14;
            this.chkUsingCheck.Text = "Using ?";
            this.chkUsingCheck.UseVisualStyleBackColor = true;
            // 
            // chkChangePWDLogon
            // 
            this.chkChangePWDLogon.AutoSize = true;
            this.chkChangePWDLogon.Location = new System.Drawing.Point(399, 66);
            this.chkChangePWDLogon.Margin = new System.Windows.Forms.Padding(2);
            this.chkChangePWDLogon.Name = "chkChangePWDLogon";
            this.chkChangePWDLogon.Size = new System.Drawing.Size(117, 17);
            this.chkChangePWDLogon.TabIndex = 13;
            this.chkChangePWDLogon.Text = "Change password?";
            this.chkChangePWDLogon.UseVisualStyleBackColor = true;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(209, 24);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(167, 23);
            this.TxtUserName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(170, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtBranchID
            // 
            this.txtBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchID.Location = new System.Drawing.Point(229, 63);
            this.txtBranchID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(34, 23);
            this.txtBranchID.TabIndex = 12;
            this.txtBranchID.Text = "000";
            this.txtBranchID.Validated += new System.EventHandler(this.txtBranchID_Validated);
            // 
            // TxtStaffId
            // 
            this.TxtStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStaffId.Location = new System.Drawing.Point(60, 63);
            this.TxtStaffId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffId.Name = "TxtStaffId";
            this.TxtStaffId.Size = new System.Drawing.Size(101, 23);
            this.TxtStaffId.TabIndex = 11;
            // 
            // lblNameBranch
            // 
            this.lblNameBranch.Location = new System.Drawing.Point(267, 67);
            this.lblNameBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameBranch.Name = "lblNameBranch";
            this.lblNameBranch.Size = new System.Drawing.Size(109, 13);
            this.lblNameBranch.TabIndex = 6;
            this.lblNameBranch.Text = "Trụ Sở Chính";
            this.lblNameBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblNameBranch, "Tên Chi nhánh");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Branch ID";
            // 
            // lblExpiredDate
            // 
            this.lblExpiredDate.AutoSize = true;
            this.lblExpiredDate.Location = new System.Drawing.Point(396, 30);
            this.lblExpiredDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpiredDate.Name = "lblExpiredDate";
            this.lblExpiredDate.Size = new System.Drawing.Size(66, 13);
            this.lblExpiredDate.TabIndex = 8;
            this.lblExpiredDate.Text = "Expired date";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(14, 67);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(43, 13);
            this.lblStaffID.TabIndex = 6;
            this.lblStaffID.Text = "Staff ID";
            // 
            // TxtUserId
            // 
            this.TxtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserId.Location = new System.Drawing.Point(60, 24);
            this.TxtUserId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(101, 23);
            this.TxtUserId.TabIndex = 8;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(14, 29);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // frmUsers
            // 
            this.AcceptButton = this.btnCommit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(778, 401);
            this.ControlBox = false;
            this.Controls.Add(this.grDetail);
            this.Controls.Add(this.grButton1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản người sử dụng";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsers_KeyDown);
            this.grButton1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grDetail.ResumeLayout(false);
            this.grDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grButton1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.DateTimePicker dExpiredDate;
        private System.Windows.Forms.CheckBox chkUsingCheck;
        private System.Windows.Forms.CheckBox chkChangePWDLogon;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TxtStaffId;
        private System.Windows.Forms.Label lblExpiredDate;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtBranchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameBranch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExcel;
    }
}