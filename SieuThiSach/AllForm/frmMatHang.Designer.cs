namespace SieuThiSach.AllForm
{
    partial class frmMatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grButton1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.TxtGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.TxtGiaNhap = new System.Windows.Forms.TextBox();
            this.lblNhaCC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.grDetail = new System.Windows.Forms.GroupBox();
            this.TxtNhaCC = new System.Windows.Forms.TextBox();
            this.TxtNhomHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNhomHang = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsMENU = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grButton1.SuspendLayout();
            this.grDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsMENU.SuspendLayout();
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
            this.grButton1.TabIndex = 9;
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
            this.btnExit.TabIndex = 8;
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
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Excel";
            this.toolTip1.SetToolTip(this.btnExcel, "(CTRL + L)");
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
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
            this.toolTip1.SetToolTip(this.btnHistory, "(CTRL + H)");
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gainsboro;
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
            this.toolTip1.SetToolTip(this.btnFind, "(CTRL + F)");
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
            this.toolTip1.SetToolTip(this.btnDel, "(DELETE)");
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
            this.toolTip1.SetToolTip(this.btnEdit, "(CTRL + E)");
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
            this.toolTip1.SetToolTip(this.btnAdd, "(CTRL + N)");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.toolTip1.SetToolTip(this.btnCancel, "(ESCAPE)");
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
            this.toolTip1.SetToolTip(this.btnCommit, "(ENTER)");
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // TxtGiaBan
            // 
            this.TxtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGiaBan.Location = new System.Drawing.Point(513, 60);
            this.TxtGiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGiaBan.Name = "TxtGiaBan";
            this.TxtGiaBan.Size = new System.Drawing.Size(83, 23);
            this.TxtGiaBan.TabIndex = 14;
            this.TxtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGiaBan_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá bán";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(221, 23);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(169, 23);
            this.TxtName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(159, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên Sách:";
            // 
            // TxtGiaNhap
            // 
            this.TxtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGiaNhap.Location = new System.Drawing.Point(358, 60);
            this.TxtGiaNhap.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGiaNhap.Name = "TxtGiaNhap";
            this.TxtGiaNhap.Size = new System.Drawing.Size(83, 23);
            this.TxtGiaNhap.TabIndex = 13;
            this.TxtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGiaNhap_KeyPress);
            this.TxtGiaNhap.Validated += new System.EventHandler(this.TxtGiaNhap_Validated);
            // 
            // lblNhaCC
            // 
            this.lblNhaCC.Location = new System.Drawing.Point(159, 63);
            this.lblNhaCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaCC.Name = "lblNhaCC";
            this.lblNhaCC.Size = new System.Drawing.Size(140, 13);
            this.lblNhaCC.TabIndex = 6;
            this.lblNhaCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhà Cung Cấp:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(304, 64);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(50, 13);
            this.lblStaffID.TabIndex = 6;
            this.lblStaffID.Text = "Giá nhập";
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(72, 23);
            this.TxtID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(83, 23);
            this.TxtID.TabIndex = 9;
            this.TxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // grDetail
            // 
            this.grDetail.Controls.Add(this.TxtNhaCC);
            this.grDetail.Controls.Add(this.TxtNhomHang);
            this.grDetail.Controls.Add(this.btnCancel);
            this.grDetail.Controls.Add(this.btnCommit);
            this.grDetail.Controls.Add(this.TxtGiaBan);
            this.grDetail.Controls.Add(this.label3);
            this.grDetail.Controls.Add(this.TxtName);
            this.grDetail.Controls.Add(this.lblName);
            this.grDetail.Controls.Add(this.TxtGiaNhap);
            this.grDetail.Controls.Add(this.label2);
            this.grDetail.Controls.Add(this.lblNhomHang);
            this.grDetail.Controls.Add(this.lblNhaCC);
            this.grDetail.Controls.Add(this.label1);
            this.grDetail.Controls.Add(this.lblStaffID);
            this.grDetail.Controls.Add(this.TxtID);
            this.grDetail.Controls.Add(this.lblUserID);
            this.grDetail.Location = new System.Drawing.Point(11, 295);
            this.grDetail.Margin = new System.Windows.Forms.Padding(2);
            this.grDetail.Name = "grDetail";
            this.grDetail.Padding = new System.Windows.Forms.Padding(2);
            this.grDetail.Size = new System.Drawing.Size(758, 96);
            this.grDetail.TabIndex = 10;
            this.grDetail.TabStop = false;
            this.grDetail.Text = "Thông tin chi tiết";
            // 
            // TxtNhaCC
            // 
            this.TxtNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNhaCC.Location = new System.Drawing.Point(98, 58);
            this.TxtNhaCC.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNhaCC.Name = "TxtNhaCC";
            this.TxtNhaCC.Size = new System.Drawing.Size(57, 23);
            this.TxtNhaCC.TabIndex = 12;
            this.TxtNhaCC.TextChanged += new System.EventHandler(this.TxtNhaCC_TextChanged);
            this.TxtNhaCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNhaCC_KeyDown);
            this.TxtNhaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNhaCC_KeyPress);
            // 
            // TxtNhomHang
            // 
            this.TxtNhomHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNhomHang.Location = new System.Drawing.Point(461, 24);
            this.TxtNhomHang.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNhomHang.Name = "TxtNhomHang";
            this.TxtNhomHang.Size = new System.Drawing.Size(48, 23);
            this.TxtNhomHang.TabIndex = 11;
            this.TxtNhomHang.TextChanged += new System.EventHandler(this.TxtNhomHang_TextChanged);
            this.TxtNhomHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNhomHang_KeyDown);
            this.TxtNhomHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNhomHang_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhóm sách:";
            // 
            // lblNhomHang
            // 
            this.lblNhomHang.Location = new System.Drawing.Point(513, 29);
            this.lblNhomHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhomHang.Name = "lblNhomHang";
            this.lblNhomHang.Size = new System.Drawing.Size(84, 13);
            this.lblNhomHang.TabIndex = 6;
            this.lblNhomHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(14, 29);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(53, 13);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "Mã Sách:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ContextMenuStrip = this.cmsMENU;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 24;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(596, 280);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // cmsMENU
            // 
            this.cmsMENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.cmsMENU.Name = "cmsMENU";
            this.cmsMENU.Size = new System.Drawing.Size(112, 48);
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.test1ToolStripMenuItem.Text = "Sửa";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.test2ToolStripMenuItem.Text = "Lịch sử";
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // frmMatHang
            // 
            this.AcceptButton = this.btnCommit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(778, 401);
            this.Controls.Add(this.grButton1);
            this.Controls.Add(this.grDetail);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMatHang";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Danh mục Sách";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMatHang_FormClosed);
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMatHang_KeyDown);
            this.grButton1.ResumeLayout(false);
            this.grDetail.ResumeLayout(false);
            this.grDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsMENU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grButton1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox TxtGiaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TxtGiaNhap;
        private System.Windows.Forms.Label lblNhaCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.GroupBox grDetail;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNhomHang;
        private System.Windows.Forms.TextBox TxtNhomHang;
        private System.Windows.Forms.TextBox TxtNhaCC;
        private System.Windows.Forms.ContextMenuStrip cmsMENU;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}