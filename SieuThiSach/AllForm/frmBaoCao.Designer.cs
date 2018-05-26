namespace SieuThiSach.AllForm
{
    partial class frmBaoCao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbPhanLoai = new System.Windows.Forms.ComboBox();
            this.txtNhomHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKyHan = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLoiNhuan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSLXuat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(211, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 24;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(885, 654);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhaCC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbbPhanLoai);
            this.groupBox1.Controls.Add(this.txtNhomHang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaDV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbKyHan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 317);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Location = new System.Drawing.Point(71, 274);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(117, 20);
            this.txtNhaCC.TabIndex = 17;
            this.txtNhaCC.TextChanged += new System.EventHandler(this.txtNhaCC_TextChanged);
            this.txtNhaCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhaCC_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nhà CC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Phân loại:";
            // 
            // cbbPhanLoai
            // 
            this.cbbPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhanLoai.FormattingEnabled = true;
            this.cbbPhanLoai.Items.AddRange(new object[] {
            "Mặt Hàng",
            "Nhóm Hàng",
            "Nhà Cung Cấp"});
            this.cbbPhanLoai.Location = new System.Drawing.Point(66, 157);
            this.cbbPhanLoai.Name = "cbbPhanLoai";
            this.cbbPhanLoai.Size = new System.Drawing.Size(122, 21);
            this.cbbPhanLoai.TabIndex = 14;
            this.cbbPhanLoai.TextChanged += new System.EventHandler(this.cbbPhanLoai_TextChanged);
            // 
            // txtNhomHang
            // 
            this.txtNhomHang.Location = new System.Drawing.Point(71, 248);
            this.txtNhomHang.Name = "txtNhomHang";
            this.txtNhomHang.Size = new System.Drawing.Size(117, 20);
            this.txtNhomHang.TabIndex = 13;
            this.txtNhomHang.TextChanged += new System.EventHandler(this.txtNhomHang_TextChanged);
            this.txtNhomHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhomHang_KeyDown);
            this.txtNhomHang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNhomHang_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nhóm sách:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(71, 222);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(117, 20);
            this.txtMaHang.TabIndex = 11;
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            this.txtMaHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaHang_KeyDown);
            this.txtMaHang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaHang_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã sách:";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(71, 196);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(117, 20);
            this.txtMaDV.TabIndex = 9;
            this.txtMaDV.TextChanged += new System.EventHandler(this.txtMaDV_TextChanged);
            this.txtMaDV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaDV_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Đơn vị:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(95, 106);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(93, 20);
            this.txtYear.TabIndex = 7;
            this.txtYear.Validated += new System.EventHandler(this.txtYear_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(95, 80);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(93, 20);
            this.txtMonth.TabIndex = 5;
            this.txtMonth.Validated += new System.EventHandler(this.txtMonth_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tháng:";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(95, 54);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(93, 20);
            this.txtDay.TabIndex = 3;
            this.txtDay.Validated += new System.EventHandler(this.txtDay_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kỳ hạn:";
            // 
            // cbbKyHan
            // 
            this.cbbKyHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKyHan.FormattingEnabled = true;
            this.cbbKyHan.Items.AddRange(new object[] {
            "Theo Ngày",
            "Theo Tháng",
            "Theo Năm"});
            this.cbbKyHan.Location = new System.Drawing.Point(66, 19);
            this.cbbKyHan.Name = "cbbKyHan";
            this.cbbKyHan.Size = new System.Drawing.Size(122, 21);
            this.cbbKyHan.TabIndex = 0;
            this.cbbKyHan.TextChanged += new System.EventHandler(this.cbbKyHan_TextChanged);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(107, 613);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(99, 23);
            this.btnIn.TabIndex = 20;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(107, 642);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLoiNhuan);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDoanhThu);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtChiPhi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtSLXuat);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSLNhap);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 156);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng hợp";
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.Location = new System.Drawing.Point(92, 123);
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.ReadOnly = true;
            this.txtLoiNhuan.Size = new System.Drawing.Size(96, 20);
            this.txtLoiNhuan.TabIndex = 27;
            this.txtLoiNhuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Tổng Lợi nhuận:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(92, 97);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.ReadOnly = true;
            this.txtDoanhThu.Size = new System.Drawing.Size(96, 20);
            this.txtDoanhThu.TabIndex = 25;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tổng Doanh thu:";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(92, 71);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.ReadOnly = true;
            this.txtChiPhi.Size = new System.Drawing.Size(96, 20);
            this.txtChiPhi.TabIndex = 23;
            this.txtChiPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tổng Chi phí:";
            // 
            // txtSLXuat
            // 
            this.txtSLXuat.Location = new System.Drawing.Point(92, 45);
            this.txtSLXuat.Name = "txtSLXuat";
            this.txtSLXuat.ReadOnly = true;
            this.txtSLXuat.Size = new System.Drawing.Size(96, 20);
            this.txtSLXuat.TabIndex = 21;
            this.txtSLXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tổng SL Bán:";
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(92, 19);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.ReadOnly = true;
            this.txtSLNhap.Size = new System.Drawing.Size(96, 20);
            this.txtSLNhap.TabIndex = 19;
            this.txtSLNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tổng SL Nhập:";
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1107, 676);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaoCao";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Doanh thu";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbKyHan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhomHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbPhanLoai;
        private System.Windows.Forms.TextBox txtNhaCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSLXuat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLoiNhuan;
        private System.Windows.Forms.Label label14;
    }
}