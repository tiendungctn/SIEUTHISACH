namespace SieuThiSach.AllForm
{
    partial class frmExecl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.txtWS = new System.Windows.Forms.TextBox();
            this.txtColNam = new System.Windows.Forms.TextBox();
            this.txtDat = new System.Windows.Forms.TextBox();
            this.cbxWS = new System.Windows.Forms.CheckBox();
            this.cbxColNam = new System.Windows.Forms.CheckBox();
            this.cbxDat = new System.Windows.Forms.CheckBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cbbTenCotCu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenCotMoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblColumnsName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(11, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 24;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(596, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(532, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(451, 299);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 7;
            this.btnCommit.Text = "Nhập";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // txtWS
            // 
            this.txtWS.Location = new System.Drawing.Point(94, 301);
            this.txtWS.Name = "txtWS";
            this.txtWS.Size = new System.Drawing.Size(30, 20);
            this.txtWS.TabIndex = 2;
            this.txtWS.Text = "1";
            this.txtWS.TextChanged += new System.EventHandler(this.txtWS_TextChanged);
            this.txtWS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWS_KeyPress);
            // 
            // txtColNam
            // 
            this.txtColNam.Location = new System.Drawing.Point(199, 301);
            this.txtColNam.Name = "txtColNam";
            this.txtColNam.Size = new System.Drawing.Size(30, 20);
            this.txtColNam.TabIndex = 4;
            this.txtColNam.Text = "1";
            this.txtColNam.TextChanged += new System.EventHandler(this.txtColNam_TextChanged);
            this.txtColNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColNam_KeyPress);
            // 
            // txtDat
            // 
            this.txtDat.Location = new System.Drawing.Point(300, 301);
            this.txtDat.Name = "txtDat";
            this.txtDat.Size = new System.Drawing.Size(30, 20);
            this.txtDat.TabIndex = 6;
            this.txtDat.Text = "2";
            this.txtDat.TextChanged += new System.EventHandler(this.txtDat_TextChanged);
            this.txtDat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDat_KeyPress);
            // 
            // cbxWS
            // 
            this.cbxWS.AutoSize = true;
            this.cbxWS.Location = new System.Drawing.Point(11, 303);
            this.cbxWS.Name = "cbxWS";
            this.cbxWS.Size = new System.Drawing.Size(83, 17);
            this.cbxWS.TabIndex = 9;
            this.cbxWS.Text = "Work Sheet";
            this.cbxWS.UseVisualStyleBackColor = true;
            this.cbxWS.CheckedChanged += new System.EventHandler(this.cbxWS_CheckedChanged);
            // 
            // cbxColNam
            // 
            this.cbxColNam.AutoSize = true;
            this.cbxColNam.Location = new System.Drawing.Point(130, 303);
            this.cbxColNam.Name = "cbxColNam";
            this.cbxColNam.Size = new System.Drawing.Size(63, 17);
            this.cbxColNam.TabIndex = 10;
            this.cbxColNam.Text = "Tên cột";
            this.cbxColNam.UseVisualStyleBackColor = true;
            this.cbxColNam.CheckedChanged += new System.EventHandler(this.cbxColNam_CheckedChanged);
            // 
            // cbxDat
            // 
            this.cbxDat.AutoSize = true;
            this.cbxDat.Location = new System.Drawing.Point(235, 303);
            this.cbxDat.Name = "cbxDat";
            this.cbxDat.Size = new System.Drawing.Size(59, 17);
            this.cbxDat.TabIndex = 11;
            this.cbxDat.Text = "Dữ liệu";
            this.cbxDat.UseVisualStyleBackColor = true;
            this.cbxDat.CheckedChanged += new System.EventHandler(this.cbxDat_CheckedChanged);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(370, 299);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(75, 23);
            this.btnSapXep.TabIndex = 12;
            this.btnSapXep.Text = "Sắp xếp lại";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // cbbTenCotCu
            // 
            this.cbbTenCotCu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenCotCu.FormattingEnabled = true;
            this.cbbTenCotCu.Location = new System.Drawing.Point(79, 331);
            this.cbbTenCotCu.Name = "cbbTenCotCu";
            this.cbbTenCotCu.Size = new System.Drawing.Size(100, 21);
            this.cbbTenCotCu.TabIndex = 13;
            this.cbbTenCotCu.SelectedIndexChanged += new System.EventHandler(this.cbbTenCotCu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Cột Cũ";
            // 
            // cbbTenCotMoi
            // 
            this.cbbTenCotMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenCotMoi.FormattingEnabled = true;
            this.cbbTenCotMoi.Location = new System.Drawing.Point(256, 331);
            this.cbbTenCotMoi.Name = "cbbTenCotMoi";
            this.cbbTenCotMoi.Size = new System.Drawing.Size(100, 21);
            this.cbbTenCotMoi.TabIndex = 13;
            this.cbbTenCotMoi.SelectionChangeCommitted += new System.EventHandler(this.cbbTenCotMoi_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Cột Mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(383, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "*Không nhập dữ liệu lặp hoặc tính toán được";
            // 
            // lblColumnsName
            // 
            this.lblColumnsName.AutoSize = true;
            this.lblColumnsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnsName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblColumnsName.Location = new System.Drawing.Point(12, 6);
            this.lblColumnsName.Name = "lblColumnsName";
            this.lblColumnsName.Size = new System.Drawing.Size(96, 13);
            this.lblColumnsName.TabIndex = 52;
            this.lblColumnsName.Text = "Tên Cột Bảng Gốc";
            // 
            // frmExecl
            // 
            this.AcceptButton = this.btnCommit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(617, 361);
            this.ControlBox = false;
            this.Controls.Add(this.lblColumnsName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTenCotMoi);
            this.Controls.Add(this.cbbTenCotCu);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.cbxDat);
            this.Controls.Add(this.cbxColNam);
            this.Controls.Add(this.cbxWS);
            this.Controls.Add(this.txtDat);
            this.Controls.Add(this.txtColNam);
            this.Controls.Add(this.txtWS);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExecl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load dữ liệu Excel";
            this.Load += new System.EventHandler(this.frmExecl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox txtWS;
        private System.Windows.Forms.TextBox txtColNam;
        private System.Windows.Forms.TextBox txtDat;
        private System.Windows.Forms.CheckBox cbxWS;
        private System.Windows.Forms.CheckBox cbxColNam;
        private System.Windows.Forms.CheckBox cbxDat;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.ComboBox cbbTenCotCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTenCotMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblColumnsName;
    }
}